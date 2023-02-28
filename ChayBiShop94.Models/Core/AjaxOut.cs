using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Models
{
    [Serializable]
    public class AjaxOut
    {
        public string InfoMessage = "";

        public string HtmlContent = "";

        public string RefKeyId = "";

        public object RetObject;

        public object RetObject1;

        public object RetObject2;

        public object RetObject3;

        public object RetObject4;

        public object RetObject5;

        public object RetObjectExtraParam1;

        public object RetObjectExtraParam2;

        public object RetObjectExtraParam3;

        public object RetObjectExtraParam4;

        public object RetObjectExtraParam5;

        public string RetUrl = "";

        public string RetUrlTarget = "_self";

        public string RetExtraParam1 = "";

        public string RetExtraParam2 = "";

        public string RetExtraParam3 = "";

        public string RetExtraParam4 = "";

        public string RetExtraParam5 = "";

        public string RetExtraParam6 = "";

        public string SaveFile = "";

        public bool Error = false;

        public bool RetBoolean = false;

        public int RetNumber = 0;

        public int RetNumber1 = 0;

        public int RetNumber2 = 0;

        public int RetNumber3 = 0;

        public int RetNumber4 = 0;

        public decimal RetNumberDecimal = 0m;

        public decimal RetNumberDecimal1 = 0m;

        public decimal RetNumberDecimal2 = 0m;

        public decimal RetNumberDecimal3 = 0m;

        public decimal RetNumberDecimal4 = 0m;

        public decimal RetDecimal = 0m;

        public bool IsReturnUrlLink = false;

        public string XmlData = "";

        public string XmlDataSchema = "";

        public byte[] RetBytes = new byte[0];

        public byte[] MediaBytes = new byte[0];

        public string FocusControl = "";

        public string XmlDataResult = "";

        public string XmlDataResultSchema = "";

        public string JsonData = "";

        public bool ShowDialogMessage = false;

        public string ProcessServiceId = "";

        public string AssetCode = "";

        public string AssetLevelId = "";

        public string FollowUpSubject = "";

        public string FollowUpDescription = "";

        public string OwnerId = "";

        public string FollowUpStatus = "";

        public string QuickHelp = "";

        public int VisibleQuickHelp = 1;

       // public PagingInfo PaggingInfo = new PagingInfo();
    }
}
