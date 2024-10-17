using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModels
{
    public class cmlReqSet
    {
        public Nullable<int> pnstID { get; set; }
        public string ptWstCode { get; set; }
        public string ptWstName { get; set; }
        public Nullable<int> pnWstType { get; set; }

    }
}
