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
using wModels.Response;

namespace WindowsFormsApp1.Service
{
    public class cSaldetService
    {
        string tC_Access;
        string tC_UrlApi;
        string tC_ClasName = "cSaldetService";
        RestClientOptions oC_Ptions;
        RestClient oC_Client;
        RestRequest oC_Rrequest;
        RestResponse oC_Response;

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
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally
            {
                // not anything
            }

        }


        public List<cmlResSalDet> C_GETaGetSaleDet(string ptSechSalCode)
        {
            List<cmlResSalDet> aoResSalDets = new List<cmlResSalDet>();
           

            try
            {
                ptSechSalCode = string.IsNullOrEmpty(ptSechSalCode) ? "N" : ptSechSalCode;
                //aoResSalDets = new List<cmlResSalDet>();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/GetSaleDetail/{ptSechSalCode}", Method.Get);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                Console.WriteLine(oC_Response.Content);
                cmlResList<cmlResSalDet> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSalDet>>(oC_Response.Content);

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
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                // aoResSalDets = null;
                // not anything
            }
            return aoResSalDets;
        }

        public List<cmlResSalDetSummy> C_GETaGetSalDetSummy()
        {
            List<cmlResSalDetSummy> aoResSalDets = new List<cmlResSalDetSummy>();
       
            try
            {

                //aoResSalDets = new List<cmlResSalDet>();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                 oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/SalDetSummy", Method.Get);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                Console.WriteLine(oC_Response.Content);
                cmlResList<cmlResSalDetSummy> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSalDetSummy>>(oC_Response.Content);

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
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                // aoResSalDets = null;
                // not anything
            }
            return aoResSalDets;
        }


    }
}
