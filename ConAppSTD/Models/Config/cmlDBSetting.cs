using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSTD.Models.Config
{
    public class cmlDBSetting
    {
        /// <summary>
        /// Server.
        /// </summary>
        public string tServer { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        public string tUser { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string tPassword { get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        public string tDatabase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string tAuthenMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nCommandTimeOut { get; set; }

    }
}
