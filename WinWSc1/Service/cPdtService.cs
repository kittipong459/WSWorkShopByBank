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
        RestClientOptions oC_Ptions;
        RestClient oC_Client;
        RestRequest oC_Rrequest;
        RestResponse oC_Response;
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
            finally {
            // not anything
            }
        }

        public List<cmlResPdt> C_GETaGetProduct()
        {
            List<cmlResPdt> aoResPdt = new List<cmlResPdt>();    // ต้องประกาศ ไม่งั้นติด error Use of unassigned local variable
            cmlResList<cmlResPdt> aoResList;

            try
            {
                //aoResPdt = new List<cmlResPdt>();
                aoResList = new cmlResList<cmlResPdt>();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/GetProduct", Method.Get);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);

                aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResPdt>>(oC_Response.Content);
                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                    aoResPdt = aoResList.raItems;
                }
                else
                {
                    // not anything
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
                // not anything
            }
            return aoResPdt;
        }




    }
}
