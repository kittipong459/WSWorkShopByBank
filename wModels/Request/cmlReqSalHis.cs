using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wModels
{
    public class cmlReqSalHis
    {
        public string ptSalCod { get; set; }
        public string ptSalPdtCod { get; set; }
        public Nullable<int> pnSalQty { get; set; }
        public Nullable<decimal> pcSalPri { get; set; }
        public Nullable<decimal> pcSalAmt { get; set; }
        public string ptSalCstCod { get; set; }
        public Nullable<DateTime> pdSalDate { get; set; }
        public Nullable<DateTime> pdSalSMPT { get; set; }
    }
}
