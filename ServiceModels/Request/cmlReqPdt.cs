using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModels
{
    public class cmlReqPdt
    {
        public Nullable<int> pnPdtID { get; set; }
        public string ptPdtCod { get; set; }
        public string ptPdtName { get; set; }
        public string ptPdtDes { get; set; }
        public Nullable<decimal> pcPdtPri { get; set; }
        public Nullable<int> pnPdtQty { get; set; }
        public Nullable<int> pnPdtTyp { get; set; }
        public Nullable<DateTime> pdPdtSMPT { get; set; }

    }

    

}
