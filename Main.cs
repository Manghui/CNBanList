using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;

namespace CNBanList
{
    public class BanInfo
    {
        public int type;
        public string value;
    }

    public class Main
    {
        private static long timestamp = -1;

        public static Thread DownloadThread;
        public static List<BanInfo> BanList;

        [PluginEntryPoint("CNBanList", "1.0.0", "", "-")]
        [PluginPriority(PluginAPI.Enums.LoadPriority.Lowest)]
        public void OnEnabled()
        {
            DownloadThread = new Thread(new ThreadStart(this.Downloader))
            {
                Priority = ThreadPriority.Lowest,
                IsBackground = true,
                Name = "SCPSL: CNBanList Downloader"
            };
            DownloadThread.Start();
            EventManager.RegisterEvents(this);
        }

        public void Downloader()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                BanList = new List<BanInfo>();
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
                                BanList.Add(new BanInfo { type = int.Parse(single[1]), value = single[0] });

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

        [PluginEvent]
        private void Player_PreAuthenticating(PlayerPreauthEvent ev)
        {
            if (BanList.Any(p => (p.type == 0 && p.value == ev.UserId) || (p.type == 1 && p.value == ev.IpAddress))) {
                CustomLiteNetLib4MirrorTransport.ProcessCancellationData
                    (ev.ConnectionRequest, PreauthCancellationData.Reject($"[CN SL-AC] 你已被国服反作弊系统永久封禁  用户ID: [{ev.UserId}] IP地址: [{ev.IpAddress}]\n" +
                    $"您在游戏中使用了包括但不限于外挂，BUG等非法手段，遭到举报并核实后封禁，并永久无法加入任何参与国服联盟封禁的服务器。\n" +
                    $"具体详情请访问 ac.cnscpsl.cn\n", true));
            }
        }
    }
}
