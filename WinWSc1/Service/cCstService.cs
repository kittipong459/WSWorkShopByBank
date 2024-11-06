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
    public class cCstService
    {

        string tC_Access;
        string tC_UrlApi;
        string tC_ClasName = "cCstService";
        RestClientOptions oC_Ptions;
        RestClient oC_Client;
        RestRequest oC_Rrequest;
        RestResponse oC_Response;
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
                //// // // throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally
            {
                // not anything
            }

        }

        public List<cmlResCst> C_GETaGetCustomer()
        {
            List<cmlResCst> aoResCst = new List<cmlResCst>();
            
            try
            {
                //aoResCst = new List<cmlResCst>();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/GetCustomer", Method.Get);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);

                cmlResList<cmlResCst> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResCst>>(oC_Response.Content);
                //return aoResList.raItems;
                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                    aoResCst = aoResList.raItems;

                }
                else
                {
                    // not anything
                }

                return aoResCst;
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                //aoResCst = null;
                // not anything
            }
            return aoResCst;
        }

    }
}
