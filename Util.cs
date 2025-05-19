using LabApi.Features.Wrappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CNBanList
{
    public class CNBanInfo
    {
        public int type;
        public string? value;
        public string? reason = null;
    }

    public static class Util
    {
        public static List<string> ConvertKeywords(string str) => str.ToLower().Replace("\r", "").Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Where(p => !p.StartsWith("#")).ToList();

        public static bool IpMatch(string? pattern, string ipAddress) => Regex.IsMatch(ipAddress, "^" + Regex.Escape(pattern).Replace("\\*", ".*") + "$");

        public static List<string> ReadLocalKeywords()
        {

            var filePath = FileManager.GetAppFolder(true, false, "") + "CNbans_keywords.txt";

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, Static.Keywords);

            return ConvertKeywords(Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(filePath))));
        }

        public static void AddBanLog(string content)
        {
            var Folder = FileManager.GetAppFolder(true, false, "");
            if (!Directory.Exists(Folder))
                return;
            try
            {
                File.AppendAllText(Folder + "cnban_logs.txt", $"{Server.Port} - {DateTime.Now.ToString("u")} - {content}\r\n");
            }
            catch { }
        }

        public static CNBanInfo? IsInBlacklist(string? userId, string? ip)
        {
            var item = CNBanList.BanList.FirstOrDefault(p =>
                (userId != null && p.type == 0 && p.value == userId) ||
                (ip != null && p.type == 1 && IpMatch(p.value, ip))
            );
            if (item == null) return null;
            return item;
        }
    }
}
