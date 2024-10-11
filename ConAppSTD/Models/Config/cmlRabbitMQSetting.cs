﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSTD.Models.Config
{
    public class cmlRabbitMQSetting
    {
        /// <summary>
        /// Host name.
        /// </summary>
        public string tMQHostName { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        public string tMQUserName { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string tMQPassword { get; set; }

        /// <summary>
        /// Virtual host.
        /// </summary>
        public string tMQVirtualHost { get; set; }

        /// <summary>
        /// List queue name. ex. SALEPOS,CONSOLIDATE,FCBCH2HQ
        /// </summary>
        public string tMQListQueue { get; set; }

        /// <summary>
        /// Port (รองรับ SSL)
        /// </summary>
        public int nPort { get; set; }

        public int nPrefetch { get; set; }
    }
}
