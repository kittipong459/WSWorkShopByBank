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
    public class cCstService
    {

        string tAccess;
        string tUrlApi;
        public cCstService()
        {
            // Get configuration values
            /*tAccess = "123456789";
            tUrlApi = "http://localhost:14589";*/
            tAccess = ConfigurationManager.AppSettings["tAccess"];
            tUrlApi = ConfigurationManager.AppSettings["tUrlApi"];
        }

        public List<cmlResCst> C_GEToCustomer(string tSearchPdtCode = "")
        {
            try
            {
                RestClientOptions oPtions = new RestClientOptions(tUrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetCustomer", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tAccess);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResCst>>(oResponse.Content);
                return aoResList.raItems;
            }
            catch (Exception e)
            {
                return new List<cmlResCst>();
            }
        }

    }
}
