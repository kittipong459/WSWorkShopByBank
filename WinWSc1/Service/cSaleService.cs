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
using System.Xml.Linq;
using wModels;
using wModels.Class;

namespace WindowsFormsApp1.Service
{
    public class cSaleService
    {

        string tC_Access;
        string tC_UrlApi;
        string tC_ClasName = "cSaleService";
        RestClientOptions oC_Ptions;
        RestClient oC_Client;
        RestRequest oC_Rrequest;
        RestResponse oC_Response;
        public cSaleService()
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
                // throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally
            {
                // not anything
            }
        }

        public List<cmlResSale> C_GETaGetSale()  // C_GETaGetSale
        {
            List<cmlResSale> aoResSal = new List<cmlResSale>();  // ต้องประกาศ ไม่งั้นติด error Use of unassigned local variable
            cmlResList<cmlResSale> aoResList;

            try
            {
                //aoResSal = new List<cmlResSale>();
                aoResList = new cmlResList<cmlResSale>();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/GetSale", Method.Get);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oC_Response.Content);
                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                    aoResSal = aoResList.raItems;
                }
                else
                {
                    // not anything
                }

                return aoResSal;
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                //aoResSal = null;
                // not anything
            }
            return aoResSal;
        }


        public bool C_POSbPosSaveSale(cmlReqSale poSalData) // C_POSbPosSaveSale
        {
            bool bReqAddsal = false;
            cmlResList<cmlResSale> aoAddSal;
            string tMsgJson;
            try
            {
                aoAddSal = new cmlResList<cmlResSale>();
                tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSalData);
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/AddSale", Method.Post);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Rrequest.AddHeader("Content-Type", "application/json");
                oC_Rrequest.AddStringBody(tMsgJson, DataFormat.Json);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                aoAddSal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oC_Response.Content);
                if (aoAddSal != null && aoAddSal.rtCode == "001")
                {
                    bReqAddsal = true;
                }
                else
                {
                    bReqAddsal = false;
                }

                return bReqAddsal;
            }
            catch (Exception oEx)
            {
                bReqAddsal = false;
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                // aoAddSal = null;
                // not anything
            }
            return bReqAddsal;
        }

        public bool C_POSbPosUpdateSale(cmlReqSale poSalData)  // C_POSbPosUpdateSale
        {
            bool bReqUpSal = false;
            cmlResList<cmlResSale> aoUpsal;
            string tMsgJson;

            try
            {
                aoUpsal = new cmlResList<cmlResSale>();
                tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSalData);
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/UpdateSale", Method.Post);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Rrequest.AddHeader("Content-Type", "application/json");
                oC_Rrequest.AddStringBody(tMsgJson, DataFormat.Json);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                aoUpsal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oC_Response.Content);

                if (aoUpsal != null && aoUpsal.rtCode == "001")
                {
                    bReqUpSal = true;
                }
                else
                {
                    bReqUpSal = false;
                }


                return bReqUpSal;
            }
            catch (Exception oEx)
            {
                bReqUpSal = false;
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                // throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                // aoUpsal = null;
                // not anything
            }
            return bReqUpSal;
        }

        public bool C_POSbPosDelSale(string ptSalId)  // C_POSbPosDelSale
        {
            cmlResBase oRes;
            try
            {
                oRes = new cmlResBase();
                oC_Ptions = new RestClientOptions(tC_UrlApi);
                oC_Client = new RestClient(oC_Ptions);
                oC_Rrequest = new RestRequest($"/api/WSCRUD/DelSale/{ptSalId}", Method.Delete);
                oC_Rrequest.AddHeader("X-Api-Key", tC_Access);
                oC_Response = oC_Client.Execute(oC_Rrequest);
                Console.WriteLine(oC_Response.Content);
                oRes = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResBase>(oC_Response.Content);
                if (oRes != null && oRes.rtCode == "001")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tC_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
                return false;
            }
            finally
            {
                // not anything
            }
        }

    }
}
