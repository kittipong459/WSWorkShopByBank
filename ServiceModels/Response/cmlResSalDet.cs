using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wModels.Response
{
    public class cmlResSalDet
    {
        public string rtSalCod { get; set; }
        public string rtSalPdtCod { get; set; }
        public string rtPdtName { get; set; }
        public string rtPdtDes { get; set; }
        public string rtPdtTyp { get; set; }
        public Nullable<int> rnSalQty { get; set; }
        public Nullable<decimal> rcSalPri { get; set; }
        public Nullable<decimal> rcSalAmt { get; set; }
        public Nullable<DateTime> rdSalDate { get; set; }
        public string rtSalCstCod { get; set; }
        public string rtCstName { get; set; }
        public string rtCstAdr { get; set; }
        public string rtCstPho { get; set; }
        public string rtCstEml { get; set; }
        public Nullable<DateTime> rdSalSMPT { get; set; }
    }
}
