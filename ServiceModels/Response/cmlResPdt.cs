using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModels
{
    public class cmlResPdt
    {
        public Nullable<int> rnPdtID { get; set; }
        public string rtPdtCod { get; set; }
        public string rtPdtName { get; set; }
        public string rtPdtDes { get; set; }
        public Nullable<int> rnPdtQty { get; set; }
        public Nullable<decimal> rcPdtPri { get; set; }
        public Nullable<int> rnPdtTyp { get; set; }
        public Nullable<DateTime> rdPdtSMPT { get; set; }
        public string rtPdtStat { get; set; }

    }

    

}
