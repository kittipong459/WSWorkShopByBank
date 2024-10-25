using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wModels.Class;
using wModels.Response;

namespace WindowsFormsApp1.Service
{
    public class cSaldetService
    {
        string tC_Access;
        string tC_UrlApi;

        public cSaldetService()
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


        public List<cmlResSalDet> C_GETaGetSaleDet(string ptSechSalCode)
        {
            List<cmlResSalDet> aoResSalDets;
            try
            {

                aoResSalDets = new List<cmlResSalDet>();
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetSaleDetail/N'{ptSechSalCode}'", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                cmlResList<cmlResSalDet> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSalDet>>(oResponse.Content);

                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                    aoResSalDets = aoResList.raItems;
                }
                else
                {
                    // ไม่ทำอะไร
                }

                return aoResSalDets;
            }
            catch (Exception oEx)
            {
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
               // aoResSalDets = null;
            }
            return aoResSalDets;
        }

    }
}
