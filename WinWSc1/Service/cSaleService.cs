using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using wModels;

namespace WindowsFormsApp1.Service
{
    public class cSaleService
    {

        string tAccess;
        string tUrlApi;
        public cSaleService()
        {
            // Get configuration values
            /*tAccess = "123456789";
            tUrlApi = "http://localhost:14589";*/
            tAccess = ConfigurationManager.AppSettings["tAccess"];
            tUrlApi = ConfigurationManager.AppSettings["tUrlApi"];
        }

        public List<cmlSale> C_GETxSale(string tSearchPdtCode = "")
        {
            try
            {
                RestClientOptions oPtions = new RestClientOptions(tUrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetSale", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tAccess);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlSale>>(oResponse.Content);
                return aoResList.raItems;
            }
            catch (Exception e)
            {
                return new List<cmlSale>();
            }
        }


        public bool C_POSToSaveSale(cmlSale SalData)
        {
            try
            {
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(SalData);
                RestClientOptions oPtions = new RestClientOptions(tUrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/AddSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tAccess);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var oRes = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlSale>>(oResponse.Content);
                if (oRes.rtCode == "001")
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool C_POSToUpdateSale(cmlSale SalData)
        {
            try
            {
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(SalData);
                RestClientOptions oPtions = new RestClientOptions(tUrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/UpdateSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tAccess);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var oRes = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlSale>>(oResponse.Content);
                if (oRes.rtCode == "001")
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
