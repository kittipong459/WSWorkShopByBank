using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Service
{
    public class cCstService
    {

        string tC_Access;
        string tC_UrlApi;
        public cCstService()
        {
            try
            {
                // Get configuration values
                /*tAccess = "123456789";
                tUrlApi = "http://localhost:14589";*/
                tC_Access = ConfigurationManager.AppSettings["tAccess"];
                tC_UrlApi = ConfigurationManager.AppSettings["tUrlApi"];
            }
            catch (Exception oEx)
            {
                throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally { }

        }

        public List<cmlResCst> C_GETaoCustomer()
        {
            List<cmlResCst> aoResCst = new List<cmlResCst>();
            try
            {
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetCustomer", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                cmlResList<cmlResCst> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResCst>>(oResponse.Content);
                //return aoResList.raItems;
                aoResCst = aoResList.raItems;
                return aoResCst;
            }
            catch (Exception oEx)
            {
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                aoResCst = null;
            }
            return aoResCst;
        }

    }
}
