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
            Util.AddBanLog($"{ev.Player.UserId} | {ev.Player.Nickname} | �����ؼ���: {skey}");
            Timing.CallDelayed(2f, () =>
            {
                ev.Player.Ban($"����Steam�ǳ��а����˼������еĴʻ㣬���ڰ�ȫ���ǣ����޷�����˷�������\n" + $"���޸������ǳƲ�������Ϸ���Լ��룬������������ϵ����������Ա", 120);
                Logger.Info($"���{ev.Player.Nickname}������Ϸ�����أ��ؼ��ʣ�{skey}");
            });
        }
    }
    public override void OnPlayerPreAuthenticating(PlayerPreAuthenticatingEventArgs ev)
    {
        var hit = Util.IsInBlacklist(ev.UserId, ev.IpAddress);
        if (hit.Item1 == true)
        {
            Util.AddBanLog($"{ev.UserId} | {ev.IpAddress} | ����" + (hit.Item2 != null ? $" | ԭ��{hit.Item2}" : ""));
            ev.RejectCustom(
                $"[CN SL-AC] ���ѱ��������ϵͳ��Ⲣ���÷��  �û�ID: [{ev.UserId}] IP��ַ: [{ev.IpAddress}] {(hit.Item2 != null ? $"ԭ��: {hit.Item2}" : "")} \n" +
                $"������Ϸ����ʹ���˰�������������ң�BUG�ȷǷ��ֶΣ��⵽�ٱ�����ʵ�������������޷������κβ���������˷���ķ�������\n" +
                $"������������� ac.cnscpsl.cn   �����������ͼ��ϵ����������Ա\n");
        }
    }

}