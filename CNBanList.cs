using System;
using GameCore;
using LabApi.Events;
using System.Threading;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using Version = System.Version;
using System.Collections.Generic;
using LabApi.Loader;
using LabApi.Features.Console;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Linq;

namespace CNBanList;

internal class CNBanList : Plugin
{
    public override string Name { get; } = "CNBanList";

    public override string Description { get; } = "A SCP:SL Plugin for CN Blacklist";

    public override string Author { get; } = "m";

    public override Version Version { get; } = new Version(2, 0, 2, 0);

    public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);

    public EventsHandler Events { get;  } = new();

    public MainConfig? PluginConfig;

    private static long timestamp = -1;
    public static List<string> Keywords = new List<string>();
    public static List<CNBanInfo> BanList = new List<CNBanInfo>();
    public static Thread? DownloadThread;


    public override void LoadConfigs()
    {
        base.LoadConfigs();
        PluginConfig = this.LoadConfig<MainConfig>("config.yml");
    }

    public override void Enable()
    {
        if (PluginConfig == null)
        {
            Logger.Error("配置文件错误，请检查！");
            return;
        }

        DownloadThread = new Thread(new ThreadStart(this.BanListDownloader))
        {
            Priority = ThreadPriority.Lowest,
            IsBackground = true,
            Name = "SCPSL: CNBanList Downloader"
        };
        DownloadThread.Start();

        Keywords = Util.ReadLocalKeywords();
        
        CustomHandlersManager.RegisterEventsHandler(Events);

        Logger.Info($"插件已加载, 本地关键词数量: {Keywords.Count}");
    }

    public override void Disable()
    {
        CustomHandlersManager.UnregisterEventsHandler(Events);
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

                        foreach (var single in content) {
                            string? reason = single.Length > 2 ? string.Join(" ", single.Skip(2)) : null;

                            int type = int.Parse(single[1]);
                            string? userId = null, ip = null;
                            if (type == 0) userId = single[0]; else ip = single[0];

                            if (Util.IsInBlacklist(userId, ip) == null)
                                BanList.Add(new CNBanInfo { type = type, value = single[0], reason = reason });
                        }

                        if (long.TryParse(raw.Last() ?? "-1", out long servertime) & servertime != -1)
                            timestamp = servertime;
                    }
                }
                catch (Exception ex)
                {
                    DebugLog.LogError($"Downloading Banlist Error: {ex.Message}");
                }

                Thread.Sleep(5 * 60 * 1000);
            }
        }
        catch (ThreadAbortException) { }
    }

}