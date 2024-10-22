using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wModels.Response
{
    public class cmlSalSary
    {
        public string rtSalCod { get; set; }
        public Nullable<int> rnQtyMax { get; set; }
        public Nullable<int> rnQtyMin { get; set; }
        public Nullable<int> rnQtySum { get; set; }
        public Nullable<decimal> rcPriMax { get; set; }
        public Nullable<decimal> rcPriMin { get; set; }
        public Nullable<decimal> rcPriceSum { get; set; }
        public Nullable<decimal> rcAmtSum { get; set; }
        public Nullable<int> rnPdts { get; set; }
    }
}
