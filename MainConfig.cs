using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNBanList
{
    public class DefaultValue
    {
        public static string Keywords = $"卖挂\r\n外挂\r\n#如需添加个人自定义的违禁词库，请参考以上格式换行添加，之后重启服务器";
    }
    public class MainConfig
    {
        public bool EnableBlockSensitiveNicknameAccess { get; set; } = true;
        public bool EnableCloudKeywords { get; set; } = true;
    }
}
