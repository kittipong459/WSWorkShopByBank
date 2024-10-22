using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using ServiceModels;
using System;
using System.Collections.Generic;
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
        public List<cmlResSalDet> C_GETaGetSaleDet(string ptSechSalCode)
        {
            List<cmlResSalDet> aoResSalDets;
            try
            {
                aoResSalDets = new List<cmlResSalDet>();
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetSaleDetail/{ptSechSalCode}", Method.Delete);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                cmlResList<cmlResSalDet> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSalDet>>(oResponse.Content);

                if (aoResList != null)
                {
                    if (aoResList.raItems.Count > 0)
                    {
                        aoResSalDets = aoResList.raItems;
                    }
                    else
                    {

                    }
                }
                else
                {

                }

                return aoResSalDets;
            }
            catch (Exception oEx)
            {
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                aoResSalDets = null;
            }
            return aoResSalDets;
        }

    }
}
