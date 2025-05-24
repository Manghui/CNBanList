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
        if (hit != null)
        {
            Util.AddBanLog($"{ev.UserId} | {ev.IpAddress} | 拦截 | " + (hit.type != 0 ? "IP Ban" : "UserId Ban" ) + (hit.reason != null ? $"  | 原因：{hit.reason}" : ""));
            ev.RejectCustom(
                $"[CN SL-AC] 你已被国服封禁系统检测并永久封禁  \n"+
                $"用户ID: [{ev.UserId}] IP地址: [{ev.IpAddress}] {(hit.reason != null ? $"代码: {hit.reason}" : "")} \n" +
                $"您可能在游戏内外使用了包括但不限于外挂，恶意BUG等非法手段，\n"+
                $"遭到举报并核实后封禁，永久无法加入任何国服联盟封禁的服务器。\n" +
                $"存在误判或有疑问？请访问 ac.cnscpsl.cn 查看常见解决方案");
        }
    }

}