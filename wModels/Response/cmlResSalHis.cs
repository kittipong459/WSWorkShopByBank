using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wModels
{
    public class cmlResSalHis
    {
        public string rtSalCod { get; set; }
        public string rtSalPdtCod { get; set; }
        public Nullable<int> rnSalQty { get; set; }
        public Nullable<decimal> rcSalPri { get; set; }
        public Nullable<decimal> rcSalAmt { get; set; }
        public string rtSalCstCod { get; set; }
        public Nullable<DateTime> rdSalDate { get; set; }
        public Nullable<DateTime> rdSalSMPT { get; set; }
    }
}
