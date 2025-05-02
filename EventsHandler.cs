using System.Linq;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.CustomHandlers;
using LabApi.Features.Console;
using MEC;

namespace CNBanList;

internal class EventsHandler : CustomEventsHandler
{

    public override void OnPlayerJoined(PlayerJoinedEventArgs ev)
    {
        var nickName = ev.Player.Nickname.ToLower();
        string skey = CNBanList.Keywords.FirstOrDefault(key => nickName.Contains(key));

        if (skey != null)
        {
            Util.AddBanLog($"{ev.Player.UserId} | {ev.Player.Nickname} | 包含关键词: {skey}");
            Timing.CallDelayed(2f, () =>
            {
                ev.Player.Ban($"您的Steam昵称中包含了极度敏感的词汇，出于安全考虑，您无法加入此服务器，\n" + $"请修改您的昵称并重启游戏后尝试加入，如有疑问请联系服务器管理员", 120);
                Logger.Info($"玩家{ev.Player.Nickname}加入游戏被拦截，关键词：{skey}");
            });
        }
    }
    public override void OnPlayerPreAuthenticating(PlayerPreAuthenticatingEventArgs ev)
    {
        var hit = Util.IsInBlacklist(ev.UserId, ev.IpAddress);
        if (hit.Item1 == true)
        {
            Util.AddBanLog($"{ev.UserId} | {ev.IpAddress} | 拦截" + (hit.Item2 != null ? $" | 原因：{hit.Item2}" : ""));
            ev.RejectCustom(
                $"[CN SL-AC] 你已被国服封禁系统检测并永久封禁  用户ID: [{ev.UserId}] IP地址: [{ev.IpAddress}] {(hit.Item2 != null ? $"原因: {hit.Item2}" : "")} \n" +
                $"您在游戏内外使用了包括但不限于外挂，BUG等非法手段，遭到举报并核实后封禁，并永久无法加入任何参与国服联盟封禁的服务器。\n" +
                $"具体详情请访问 ac.cnscpsl.cn   如有疑问请截图联系服务器管理员\n");
        }
    }

}