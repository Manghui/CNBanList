﻿using MEC;
using Mirror;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace CNBanList
{
    public class Main
    {
        public class CNBanInfo
        {
            public int type;
            public string value;
        }

        private static long timestamp = -1;

        public static List<string> Keywords;
        public static Thread DownloadThread;
        public static List<CNBanInfo> BanList;

        [PluginConfig] public MainConfig PluginConfig;

        [PluginEntryPoint("CNBanList", "1.0.2", "", "-")]
        [PluginPriority(PluginAPI.Enums.LoadPriority.Lowest)]
        public void OnEnabled()
        {
            DownloadThread = new Thread(new ThreadStart(this.BanListDownloader))
            {
                Priority = ThreadPriority.Lowest,
                IsBackground = true,
                Name = "SCPSL: CNBanList Downloader"
            };
            DownloadThread.Start();
            var filePath = FileManager.GetAppFolder(true, false, "") + "CNbans_keywords.txt";

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, DefaultValue.Keywords);
            
            //load keywords
            Keywords = Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(filePath))).ToLower().Replace("\r","").Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            EventManager.RegisterEvents(this);

            Log.Info("Plugin Loaded");
        }


        public void BanListDownloader() 
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                BanList = new List<CNBanInfo>();
                while (true)
                {
                    try
                    {
                        HttpResponseMessage response = httpClient.GetAsync(string.Format("https://api.manghui.net/t/getbanlist?time={0}", timestamp)).Result;
                        HttpStatusCode statusCode = response.StatusCode;
                        if (statusCode == HttpStatusCode.OK)
                        {
                            var raw = response.Content.ReadAsStringAsync().Result.Split('\n').ToList();

                            var content = raw.Select(str => str.Split('_')).Where(element => element.Length > 1);

                            foreach (var single in content)
                                BanList.Add(new CNBanInfo { type = int.Parse(single[1]), value = single[0] });

                            if (long.TryParse(raw.Last() ?? "-1", out long servertime) & servertime != -1)
                                timestamp = servertime;
                        }
                    }
                    catch (Exception ex)
                    {
                        DebugLog.LogError($"Downloading Banlist Error: {ex.Message}");
                    }

                    Thread.Sleep(60000);
                }
            }
            catch (ThreadAbortException) { }
        }

        public static bool IpMatch(string pattern, string ipAddress) => Regex.IsMatch(ipAddress, "^" + Regex.Escape(pattern).Replace("\\*", ".*") + "$");

        [PluginEvent]
        private void PlayerPreAuthing(PlayerPreauthEvent ev)
        {
            if (BanList.Any(p => 
                (p.type == 0 && p.value == ev.UserId) || 
                (p.type == 1 && IpMatch(p.value, ev.IpAddress))
            ))
            {
                AddBanLog($"{ev.UserId} | {ev.IpAddress} | 拒绝加入");
                CustomLiteNetLib4MirrorTransport.ProcessCancellationData
                    (ev.ConnectionRequest, PreauthCancellationData.Reject(
                        $"[CN SL-AC] 你已被国服反作弊系统永久封禁  用户ID: [{ev.UserId}] IP地址: [{ev.IpAddress}]\n" +
                        $"您在游戏中使用了包括但不限于外挂，BUG等非法手段，遭到举报并核实后封禁，并永久无法加入任何参与国服联盟封禁的服务器。\n" +
                        $"具体详情请访问 ac.cnscpsl.cn\n"
                    , true));
            }
        }

        [PluginEvent]
        private void PlayerJoined(PlayerJoinedEvent ev)
        {
            var nickName = ev.Player.Nickname.ToLower();
            string skey = Keywords.FirstOrDefault(key => nickName.Contains(key));

            if (skey != null)
            {
                AddBanLog($"{ev.Player.UserId} | {ev.Player.Nickname} | 包含关键词: {skey}");
                Timing.CallDelayed(2f, () =>
                {
                    ev.Player.Ban($"您的Steam昵称中包含了极度敏感的词汇，出于安全考虑，您无法加入此服务器，\n" + $"请修改您的昵称并重启游戏后尝试加入，如有疑问请联系服务器管理员", 120);
                    Log.Info($"玩家{ev.Player.Nickname}加入游戏被拦截，关键词：{skey}");
                } );
            }
        }
        private void AddBanLog(string content) {
            var Folder = FileManager.GetAppFolder(true, false, "");
            if (!Directory.Exists(Folder))
                return;
            try
            {
                File.AppendAllText(Folder + "CNban_logs.txt",$"{Server.Port} - {DateTime.Now.ToString("u")} - {content}\r\n");
            } catch { }
        }
    }
}
