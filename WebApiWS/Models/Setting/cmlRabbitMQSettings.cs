using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSTD.Models.Setting
{
    public class cmlRabbitMQSettings
    {
        /// <summary>
        /// Host name.
        /// </summary>
        public string tHostName { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string tUserName { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string tPassword { get; set; }

        /// <summary>
        /// Virtual host.
        /// </summary>
        public string tVirtualHost { get; set; }

        /// <summary>
        /// List queue name. ex. SALEPOS,CONSOLIDATE,FCBCH2HQ
        /// </summary>
        public string tListQueue { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        public Nullable<int> nPort { get; set; }
    }
}
