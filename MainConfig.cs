﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNBanList
{
    public class MainConfig
    {
        public bool EnableBlockSensitiveNicknameAccess { get; set; } = true;
        public string Keywords_Strings { get; set; } = "5oum5Z2m5YWL6L2mLOa6nOWbmyzmtYHooYDooZ3nqoEs5rWB6KGA5LqL5Lu2LOWFrTTkuovku7Ys5YWt5Zub5pq05YqoLOWFreWbm+iiq+adgCzlha3lm5vooqvlsaDmnYAs5YWt5Zub6KKr5bGg5q66LOWFreWbm+WPguS4juiAhSzlha3lm5vmg6jmoYgs5YWt5Zub5pu+5rWB6KGALOWFreWbm+Wkp+WxoOadgCzlha3lm5vmoaPmoYgs5YWt5Zub55qE5Yqo5LmxLOWFreWbm+eahOaequWjsCzlha3lm5vnmoTmp43ogbIs5YWt5Zub55qE5YWI54OILOWFreWbm+WKqOS5sSzlha3lm5vpo47ms6Is5YWt5Zub6aOO5LqRLOWFreWbm+aEn+iogCzlha3lm5vmiJLkuKUs5YWt5Zub5byA5p6q5LukLOWFreWbm+a1geS6oee+juWbvSzlha3lm5vmtYHkuqHogIUs5YWt5Zub5rCR6L+QLOWFreWbm+aVj+aEnyzlha3lm5vnlLfkuovku7Ys5YWt5Zub6K+E5Lu3LOWFreWbm+a4heWcuizlha3lm5vml6XorrAs5YWt5Zub5LqL5Lu2LOWFreWbm+WkqeWuiemXqCzlha3lm5vlpKnlronpl6jkuovku7Ys5YWt5Zub5aSp572RLOWFreWbm+mTgeaxiSzlha3lm5vlsaDln44s5YWt5Zub5bGg5aSrLOWFreWbm+WxoOadgCzlha3lm5vlsaDmrros5YWt5Zub5a2m5r2uLOaOp+WItuWkqeWuiemXqCzlha3lm5vlrabov5As5YWt5Zub6KGA5qGILOWFreWbm+mBh+mavuiAhSzlha3lm5vov5Dliqgs5YWt5Zub55yf55u4LOWFreWbm+mVh+WOiyzlha3lm5vplYfljovkuLvniq8s5YWt5Zub5pS/5rK7LOWFreWbm+S5i+mtgizlha3lm5vkuK3lhbHmmrTooYws5YWt5Zub5aOu5aOrLOWFreiChuWtpuWtkCzlha3lkIXlm5ss5YWt5pyI55qE5Z2m5YWLLOWFreaciOWbm+aXpeeahOWxoOadgCzlm5vkuozlha3npL7orros5YWt5Zub5a2m55Sf6L+Q5YqoLOWkqeWuiU1lbuWxoOWkqyzlpKnlronpl6jmmrTliqgs5aSp5a6J6Zeo5pq05LmxLOWkqeWuiemXqOWkp+WxoOadgCzlpKnlronpl6jliqjkubEs5aSp5a6J6Zeo5rWB5LqhLOWkqeWuiemXqOWFreWbmyzlpKnlronpl6jmr43kurIs5aSp5a6J6Zeo6JmQ5p2ALOWkqeWuiemXqOW5s+WPjSzlpKnlronpl6jkuovku7Ys5aSp5a6J6Zeo5LqL5Lu25piv5Lit5YWx55qE6Zi06LCLLOWkqeWuiemXqOWxoOadgCzlpKnlronpl6jlrabmva4s5aSp5a6J6Zeo6KGA6IWl5bGg5p2ALOWkqeWuiemXqOS4gOS5neWFq+S5nSzlpKnlronpl6jplYfljoss5aSp5a6J6ZaA5aSn5bGg5q66LOWkqeWuiemWgOS6i+S7tizmjJHlha3lm5vor53popgs5LqU5pyI5LiJ5Y2B5LqU5pel5LqL5Lu2LOWkqUFu6Zeo5LqL5Lu2LOWHhuWkh+aIkuS4pSzlvJXlj5Hlha3lm5vkuovku7Ys5LiA5Lmd5YWr5Lmd5bm05YWt5pyI5Zub5pelLOS4gOS5neWFq+S5neWKqOS5sSzkuIDkuZ3lhavkuZ3mmrTliqgs6KGA5rSX5aSp5a6J6Zeo5bm/5Zy6LOi/mOadjuaXuumYs+WFrOmBkyzpgoTmnY7ml7rpmb3lhazpgZMs5p2O6bmP5Zue5b+G5b2VLOadjum5j+WFreWbm+aXpeiusCzliJjmmZPms6LooqvmipMs5rCR6L+Q5Lq65aOr546L5Li5LOi1tee0q+mYs+WbnuW/huW9lSzlrabnlJ/pooboopbnjovkuLks5oK85b+15YWt5ZubLOa+ueW/mOS6huWFreWbmyzlj43mgJ3lha3lm5ss6aOe6KGA5YWt5pyILOiusOW/teWFreWbmyznuqrlv7Xlha3lm5ss57qq5b+15YWt5Zub5LqL5Lu2LOe6quW/temZhuWbmyzntIDlv7Xlha3lm5ss5o+t5YWt5ZubMjflubQs6Kej56aB5YWtNCzop6PnpoHlha3lm5ss5p+z5Lid56Wt5aWgLOWFreWbmzI35ZGo5bm0LOWFreWbm+S4jeacvSzlha3lm5vnuqrlv7Xml6Us5YWt5Zub5bmz5Y+NLOWFreWbm+WRqOW5tCzlha3lm5vng5vlhYnpm4bkvJos5YWt5Zub54Ob5YWJ5pma5LyaLOWFreWbm+eHreWFiembhuacgyzlha3lm5vov73mgJ3kvJos5aOw5o+05YWr5Lmd5a2m5r2uLOe7tOWbreWFreWbm+mbhuS8mizml6Dog73lubPlha3lm5ss5q+L5b+Y5YWt5ZubLOWLv+W/mOWFreWbmyzokKXmlZE4Oeawkei/kCzmmK3pm6rlha3lm5vlhqTmoYgs5YWt5Zub5Lqh54G1LOWFreWbm+S6oemdiCzlha3mnIjku73npoHpo58s5aSp5a6J6Zeo5omr5bCELOWkqeWuiemXqOaXtuaKpSzlpKnlronpl6jnpLrlqIEs5aSp5a6J6Zeo56S65aiB5ri46KGMLOWkqeWuiemXqOWPjOS6sizlpKnlronpl6jlnablhYss5aSp5a6J6Zeo5bGg5aSrLOWkqeWuiemXqOiHqueEmizlpKnlronploDlu6PloLQs5aSp5a6J6ZaA5buj5aC06ayn5LqLLOWkqeWuiemWgOW7o+WgtOeXm+WTrSzlpKnlronploDliY3plovlj6Poqqos5aSp5a6J6Zeo5oqX6K6uLOS4reWFseihgOa0lyzkuK3lhbHlvIDmnqrplYfljoss5Lit5YWx5pq05pS/LOmVh+WOi+Wtpui/kCzplYfljovlrabnlJ8s6ZWH5Y6L5aSp5a6J6ZeoLOi2mee0q+mZveeahOeZvOiogCzotbXmlK/mjIHlrabmva4s5L2U6aCY5aSp5a6J6ZaALOWNoOmgmOWkqeWuiemWgCzljaDpooblpKnlronpl6gs6JGs6Lqr5Z2m5YWL5bGl5bimLOa4uOihjOWcqOWkqeWuiemXqCzmuLjooYznpLrlqIEs5ri46KGM5Yqo5Lmx5pS/5rK7LOiQpeaVkei1tee0q+mYsyzlo7nkuZ3lhavkuZ3lubQs5LiA5Lmd5YWr5Lmd5aSp5a6J6ZeoLOi1tee0q+mYs+eahOenmOWvhiznu7Tlm63lj4LliqDmmZrkvJos57u05Zut5pma5LyaLOe7tOWbrea4uOihjCznu7Tlm63ng5vlhYks57at5ZyS54et5YWJ6ZuG5pyDLOS5oOWkp+WkpyzkuaDljIXlrZAs5YiB5aSn5aSnLC3og6HplKYt5rabLSwwOOWuqueroCwwOOaGsueroCww5YWr5a6q5pS/LDDlhavlrqrnq6AsMOaNjOWuquaUvyww5o2M5a6q56ugLDE45q2y5rer5LqCLDE5ODlSZWNhbGxvZk1lbW9yeSwxOTg5XywxOTg55bm0LDIwMDXlubQx5pyIMTfml6UsMjDlubTliY3mjKHlnablhYssNDDlsoHmiY3ov5vmnLrlhbMsNOaciDI05Y+3MTksNTAwMOaxieS6uiw0dGlhbndhbmcsNjEw5Yqe5YWs5a6kLDYxM+S9m+WxseS4gOWPt+aWh+S7tiw2MTPlhbTlubPkuIDlj7fmlofku7YsNjEz5paw5Lmh5LiA5Y+35paH5Lu2LDYxM+eGiuWys+S4gOWPt+aWh+S7tiw2M+S9m+WxseS4gOWPt+aWh+S7tnzkvZssNjPlhbTlubPkuIDlj7fmlofku7Z85YW0LDYz5paw5Lmh5LiA5Y+35paH5Lu2fOaWsCw2M+eGiuWys+S4gOWPt+aWh+S7tnznhoosNjR0aWFud2FuZyw2NOS6i+S7tiw2NOWtpua9riw2NOWtuOa9riw25ZGo5YiKLDblm5vkuovku7YsNuaciDTml6UsNy416JeP54usLDcxNeaatOihjCw3MzHpg6jpmJ8sNzXkuovku7YsNzXmmrTooYwsNzXnuqrlv7UsODAyM+mDqOmYnyw4OeS6i+S7tiw4OeWtpua9riw4OeWtpui/kCw4OeWtuOa9riw4OeWtuOmBiyw4OeW5tCblha3lm5ssODnmsJHov5AsOTg5UmVjYWxsb2ZNZW1vcnksOTg55bm0JjbmnIg05pelLEHlnovogonmr5LntKAs5rCU5p6q6ZSA5ZSuLEpaTeakjeeJqeS6uixL57KJLOWkluaMgue+pCzmiJHmmK/lpJbmjIIsU03oiJTnqbQs54K45by55Yi25L2c5pa55rOVLFhpamlucGluLGh16ZSmdGFvLHNpZ25hdHVyZeaAu+eQhixzaWduYXR1cmXmuKks5LiA5Lit5LiA5Y+wLOWbnuawkeWQg+eMquiCiSzkuaDov5HlubMs5p2O5YWL5by6LOWRqOawuOW6tyzlkajmganmnaUs5rOV6L2u5YqfLOiXj+eLrCzlj7Dni6ws5Lic56qBLOS5oOS4u+W4rSzkuIDlhZrkuJPliLYs5LiA5YWa5LiT5pS/LOS4gOWFmuaJp+aUvyzkuIDlhZrni6zoo4Es5LiA5Yab5Lik562WLOS4gOWbveS4pOWItizlkIPkurrogoks5LiA6L655LiA5Zu9LOS4pOWbveiuuiznv5Lov5HlubMs546L5bKQ5bGxLOW8oOmrmOS4vSzkuIDpu6jlsIjliLYs5LiB5a2Q6ZyWLOS4g+S6lOS6i+S7tizkuIPkupTmmrTooYws5LiD5LqU5pyf6Ze0LOS4g+S6lOe6quW/tSzkuIPmnIjkuIPml6Us5LiJS+m7qCzkuInkuKrku6PlqYos5LiJ5Liq5Luj6KGoLOS4ieS4quWRhuWpiizkuInlgIvku6Pooags5LiJ5Y676LuK5L6W5bel5YqbLOS4ieWOu+i9puS7kSzkuInlubTlm7Dpmr7ml7bmnJ8s5LiK5rW35a2k5YS/6ZmiLOS4iua1t+WtpOWFkumZoizkuI3lkIzmlL/op4Es5LiT5Yi25pS/5p2DLOS4nOS6mueXheWkqyzkuKTkuKrkuK3lm70s5Lik5bK45YWz57O7LOS4pOWyuOaImOS6iSzkuK3lhbHkuIDlhZos5Lit5YWx5LiA6buoLOS4reWFseS4k+WItizkuK3lhbHkuK3lpK4s5Lit5YWx5LyqLOS4reWFseWBvSzkuK3lhbHlhpvpmJ8s5Lit5YWx5Y2B5LiDLOS4reWFseWNgeWFqyzkuK3lhbHljYHkuZ0s5Lit5YWx5Z6u5Y+wLOS4reWFseWeruiHuizkuK3lhbHlsI/kuJEs5Lit5YWx5biu5Ye2LOS4reWFseW5q+WFhyzkuK3lhbHlvZPlsYAs5Lit5YWx5oG26Zy4LOS4reWFseaUv+WdmyzkuK3lhbHmlL/msrss5Lit5YWx5pq05pS/LOS4reWFseadgyzkuK3lhbHmtbflpJYs5Lit5YWx54us5p6tLOS4reWFseeLrOijgSzkuK3lhbHnjajoo4Es5Lit5YWx57KJ6aO+LOS4reWFsee1seayuyzkuK3lhbHnu5/msrss5Lit5YWx6KGA6IWlLOS4reWFseitpuWvnyzkuK3lhbHotbDni5cs5Lit5YWx6LuN6ZqKLOS4reWFsei/q+WusyzkuK3lhbHpgqrlhZos5Lit5YWx6YKq5oG2LOS4reWFsemCqum7qCzkuK3lhbHpoJjlsI7kuros5Lit5YWx6auY5bGCLOS4reWFsemrmOWxpCzkuK3ljY7kurrmsJHlhbHlkozlm70s5Lit5Y2O5Lq65rCRLOS4reWNjuWkp+S8lyzkuK3ljY7luJ3lm70s5Lit5Y2O5rCR5Zu9LOS4reWbvXpmLOS4reWbveOBruODgeODmeODg+ODiCzkuK3lm73lha3lm5ss5Lit5Zu95YWx5Lqn5YWaLOS4reWbveWkquWtkCzkuK3lm73nurPnsrks5Lit5Zu96aKG5a+85Lq6LOS4reWbvemrmOWxgizkuK3lnIvlhbHnlKLpu6gs5Lit5ZyL5YWx6buoLOS4reWkrnpmLOS4reWkruWGm+WnlCzkuK3lpK7mlL/msrss5Lit5aSu6aKG5a+8LOS4reWuo+mDqCzkuK3nuqrlp5Qs5Lit6I+v5Lq65rCRLOS5jC3psoEt5pyoLem9kCzkuYzpsoHmnKjpvZAs5Lmd5LiA5YWrLOS5oF/ov5HlubMs5LmgamlucGluZyzkuaBqcCzkuaDkuLvluK0s5Lmg5Lmm6K6wLOS5oOS7suWLiyzkuaDlpKrlrZAs5Lmg5bmz5bmzLOS5oOW7uuW5syzkuaDmmI7ms70s5Lmg5p2O5Y2B5YWr5aSnLOS5oOemgeivhCzkuaDov5HlubMs5Lmg6L+R5b2x5bidLOS5oOi/m+W5syzkuaDov5zlubMs5Lmg6YeR55O2LOS5oOm7hOiijSzkuozkuozlhavkuovku7Ys5LqM5Y2B5bm05YmN5oyh5Z2m5YWLLOS6lOavm+S7rCzkupTmr5vlhZos5Lqh5YWaLOS6oeWFsSzkuqflhZrlhbEs5Lq65aSn5Luj6KGoLOS6uuawkeWkp+S8mizku4rml6XlsbHopb8s5L6b6ZOy5YWaLOS+m+mTsuijhizkvpvpk7LosKAs5YCt5Zu9LOWDteazveawkSzlg7Xos4os5YO16LS85rCRLOWEguiRl+WNteaLiyzlhILokZflsqHlt5Is5YWJ5aSN5rCR5Zu9LOWFmuS4reWkrizlhZrkuLvluK0s5YWa5Li75bitLOWFmuS6p+WFsSzlhZrlhoXliIboo4Is5YWa5pS/5LiA5oqK5omLLOWFmuagoeWuieaPkuS6suS/oSzlhZrnmoTllonoiIws5YWa56ugLOWFqOWbveS4pOS8mizlhajlm73kurrlpKcs5YWo5ZyL5Lq65aSnLOWFqOWci+WFqeacgyzlhajlrrbkuI3lvpflpb3mrbss5YWo5a625q275YWJLOWFqOWutuatu+e7nSzlhanlgIvkuK3lnIss5YWp5bK45LiJ5ZywLOWFqeWyuOmXnOS/gizlhanmnIMs5YWp5pyD5aCx6YGTLOWFqeacg+aWsOiBnizlhavkuZ3kuovku7Ys5YWr5Lmd5a2m5r2uLOWFq+S5neWtpui/kCzlhavkuZ3lrbjmva4s5YWr5Lmd5a246YGLLOWFq+S5neW5tCzlhavkuZ3lubQs5YWr5Lmd5rCR6L+QLOWFq+S5neawkemBiyzlhavkuZ3po47ms6Is5YWr6Zu25LqM5LiJ6YOo6ZifLOWFrSDlm5ss5YWtLeWbmyzlha0u5ZubLOWFrTTkuovku7Ys5YWtP+Wbmyzlha3jgILlm5ss5YWt5ZubJue6quW/tSzlha3lm5vkuovku7Ys5YWt5Zub5a2m5r2uLOWFreWbm+WtpueUnyzlha3lm5vlrbjmva4s5YWt5Zub5a2455SfLOWFreWbm+WxoOWkqyzlha3lm5vlvZXpn7Ms5YWt5Zub5oyhLOWFreWbm+aXpeiusCzlha3lm5vmsJHkuLss5YWt5Zub55m955qu5LmmLOWFreWbm+eZveearuabuCzlha3lm5vnnJ/nm7gs5YWt5Zub6KiY6YyE54mHLOWFreWbm+iusOW9leeJhyzlha3lm5vov5Dliqgs5YWt5Zub6Zq+5bGeLOWFreWbm+mbo+WxrCzlhbFj5YWaLOWFsXjlhZos5YWx5LiA5Lqn5LiA5YWaLOWFseS6p+S4k+WItizlhbHkuqfkuJPliLZ85YWxLOWFseS6p+WFmuWvuSzlhbHkuqfml6DotZYs5YWx5Lqn5p6B5p2DLOWFseS6p+eOi+acnSzlhbHkuqfpgqrlhZos5YWx5Lqn6YKq54G1LOWFseWMqizlhbHlpbQs5YWx5oOo5YWaLOWFseaDqOahoyzlhbHmg6jog4Ys5YWx5oWY5qqULOWFseaKouWFmizlhbHmpq7lnIgs5YWx5q6L5Li75LmJLOWFseaui+WFmizlhbHmrovmjKEs5YWx5q6L6KOGLOWFseaumOaTiyzlhbHni5cs5YWx55Si6YKq6Z2ILOWFseeUoumCqum7qCzlhbHnlKLpu6gs5YWx55Sj5Li7576pLOWFseeUo+m7qCzlhbHotKrlhZos5YWx6LuNLOWFsemTsuWFmizlhbHpk7Loo4Ys5YWx6buoLOWGm+WbveS4u+S5iSzlhrDmr5Is5rW35rSb5ZugLOWImOWwkeWlhyzliqjkubEs5YyX5Lqs5LqL5Lu2LOWMl+S6rOW4rizljJfkuqzmlL/mnYMs5YyX5Lqs55W25bGALOWMl+S6rOmjjuazoizljYE35aSnLOWNli7lm70s5Y2W5YWa5rGC6I2jLOWNluWbvSzljZblpJbmjIIs5Y6G5Y+y5LiN5Lya5b+Y6K6wLOWOn+WtkOW8ueWItuS9nCzljrvkuK3lpK4s5Y+N5YWaLOWPjeWFsSzlj43liIboo4Is5Y+N5YqoLOWPjeWNjizlj43lj7Pov5Dliqgs5Y+N5Zu95a62LOWPjeaUv+W6nCzlj43oj68s5Y+N6Z2p5ZG9LOWPjem7qCzlj5Horrrlhaws5Y+R6K665YqfLOWPkeiuuuW3pSzlj6/ljaHlm6As5Y+v5oCc55qE57u05ZC+5bCU5Lq6LOWPsGR1LOWPsOWGmyzlj7Dmr5Is5Y+w5rW35Y2x5py6LOWPsOa5vuWFmizlj7Dmub7lm70s5Y+w5rm+5pS/6K66LOWPsOa5vuawkeWbvSzlj7Dmub7ni6ws5Y+w5rm+54us5Y+wLOWPsOa5vueLrOeriyzlj7Dmub7ogZTnm58s5Y+w54usLOWPsOeNqCzlkIzog57kuaYs5ZC45q+SLOWRiuWFqOWbvSzlkYropb/ol48sU0NQ5aSW5oyCLFNM5aSW5oyCLHNjcOWkluaMgixzbOWkluaMgizlpJbmjILnvqQs5oyCcXVuLOaMgue+pCxtYWlndWEs5Y2W5oyCLFNDUFNM5aSW5oyCLHNjcHNs5aSW5oyCLOW4jOeJueWLkiznurPnsrks5rSX54m55LmQLOS7peiJsuWIlw==";
    }
}