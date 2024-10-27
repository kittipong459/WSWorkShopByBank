using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wModels.Class;

namespace WindowsFormsApp1.Service
{
    public class cPdtService
    {
        string tC_Access;
        string tC_UrlApi;
        string tW_ClasName = "cPdtService";
        public cPdtService()
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
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally { }
        }

        public List<cmlResPdt> C_GETaGetProduct()
        {
            List<cmlResPdt> aoResPdt = new List<cmlResPdt>();
            try
            {
                //aoResPdt = new List<cmlResPdt>();
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetProduct", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);

                cmlResList<cmlResPdt> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResPdt>>(oResponse.Content);
                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                        aoResPdt = aoResList.raItems;
                }
                else
                {

                }
                // check null model
                return aoResPdt;
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                //aoResPdt = null;
            }
            return aoResPdt;
        }




    }
}
