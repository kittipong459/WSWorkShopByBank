using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSTD.Class
{
    public static class cMS
    {
        //Code
        public static readonly string tMS_RespCode001 = "001";
        public static readonly string tMS_RespCode700 = "700";
        public static readonly string tMS_RespCode701 = "701";
        public static readonly string tMS_RespCode800 = "800";
        public static readonly string tMS_RespCode900 = "900";
        public static readonly string tMS_RespCode904 = "904";
        public static readonly string tMS_RespCode907 = "907";

        //Description
        public static readonly string tMS_RespDesc001 = "success.";
        public static readonly string tMS_RespDesc700 = "all parameter is null.";
        public static readonly string tMS_RespDesc701 = "validate parameter model false.|";
        public static readonly string tMS_RespDesc800 = "data not found.";
        public static readonly string tMS_RespDesc900 = "service process false.";
        public static readonly string tMS_RespDesc904 = "key not allowed to use method.";
        public static readonly string tMS_RespDesc907 = "cannot connect server MQ";
    }
}
