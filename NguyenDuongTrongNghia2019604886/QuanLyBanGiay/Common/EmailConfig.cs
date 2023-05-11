using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAn_LapTrinhWeb.Common
{
    public class EmailConfig
    {
        /*
           Để dùng gmail gửi email rs cho người khác bạn cần phải vô đây "https://www.google.com/settings/security/lesssecureapps" Cho phép ứng dụng kém an toàn: Bật
         */
        public const string emailID = "im.trongnghia10@gmail.com";
        public const string emailPassword = "oklmijvdvgbjwtgi";
        public const string emailHost = "smtp.gmail.com"; //nếu dùng gmail thì đổi thành  "Host = "smtp.gmail.com"
        //public const string emailHost = "smtp.mail.yahoo.com";
        public const string emailName = "TNSHOP";//Tên email hiển thị khi gửi
    }
    
}