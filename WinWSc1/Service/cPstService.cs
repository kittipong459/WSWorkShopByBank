using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wModels;

namespace WindowsFormsApp1.Service
{
    public class cPstService
    {
        string C_tAccess;
        string C_tUrlApi;
        public cPstService()
        {
            // Get configuration values
            /*tAccess = "123456789";
            tUrlApi = "http://localhost:14589";*/
            C_tAccess = ConfigurationManager.AppSettings["tAccess"];
            C_tUrlApi = ConfigurationManager.AppSettings["tUrlApi"];
        }

        public List<cmlResPdt> C_GEToProduct(string tSearchPdtCode = "")
        {
            try
            {
                RestClientOptions oPtions = new RestClientOptions(C_tUrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetProduct", Method.Get);
                oRrequest.AddHeader("X-Api-Key", C_tAccess);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResPdt>>(oResponse.Content);
                return aoResList.raItems;
            }
            catch (Exception e)
            {
                return new List<cmlResPdt>();
            }
        }


       /* public class cmlResPdt
        {
            public Nullable<int> rnPdtID { get; set; }
            public string rtPdtCod { get; set; }
            public string rtPdtName { get; set; }
            public string rtPdtDes { get; set; }
            public Nullable<decimal> rcPdtPri { get; set; }
            public Nullable<int> rnPdtQty { get; set; }
            public Nullable<DateTime> rdPdtSMPT { get; set; }

        }

        public class cmlResList<T> : cmlResBase
        {
            /// <summary>
            /// Array Obj Item Return.
            /// </summary>
            public List<T> raItems { get; set; }
        }


        public class cmlResBase
        {
            /// <summary>
            /// System process status.
            /// </summary>
            public string rtCode { get; set; }

            /// <summary>
            /// System process description.
            /// </summary>
            public string rtDesc { get; set; }
        }*/

    }
}
