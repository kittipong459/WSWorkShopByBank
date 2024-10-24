using BuildingBlocks.Models.WebService.Response.Base;
using RestSharp;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using wModels;
using wModels.Class;

namespace WindowsFormsApp1.Service
{
    public class cSaleService
    {

        string tC_Access;
        string tC_UrlApi;
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
                throw new Exception(oEx.Message + " " + oEx.StackTrace);
            }
            finally { }
        }

        public List<cmlResSale> C_GETaSale()  // C_GETaGetSale
        {
            List<cmlResSale> aoResSal;

            try
            {
                aoResSal = new List<cmlResSale>();
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetSale", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                cmlResList<cmlResSale> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oResponse.Content);
                if (aoResList != null && aoResList.raItems.Count > 0)
                {
                    aoResSal = aoResList.raItems;
                }
                else
                {

                }

                return aoResSal;
            }
            catch (Exception oEx)
            {
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                aoResSal = null;
            }
            return aoResSal;
        }


        public bool C_POSbSaveSale(cmlReqSale poSalData) // C_POSbPosSaveSale
        {
            bool bReqAddsal = false;
            cmlResList<cmlResSale> aoAddSal;
            try
            {
                aoAddSal = new cmlResList<cmlResSale>();
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSalData);
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/AddSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                aoAddSal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oResponse.Content);
                if (aoAddSal != null && aoAddSal.raItems.Count > 0 && aoAddSal.rtCode == "001")
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
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                aoAddSal = null;
            }
            return bReqAddsal;
        }

        public bool C_POSbUpdateSale(cmlReqSale poSalData)  // C_POSbPosUpdateSale
        {
            bool bReqUpSal = false;
            cmlResList<cmlResSale> aoUpsal;
            try
            {
                aoUpsal = new cmlResList<cmlResSale>();
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSalData);
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/UpdateSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                aoUpsal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oResponse.Content);

                if (aoUpsal != null && aoUpsal.raItems.Count > 0 && aoUpsal.rtCode == "001" )
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
                throw new Exception(oEx.Message + " : " + oEx.StackTrace);
            }
            finally
            {
                aoUpsal = null;
            }
            return bReqUpSal;
        }

        public bool C_POSbDelSale(string ptSalId)  // C_POSbPosDelSale
        {
            cmlResBase oRes;
            try
            {
                oRes = new cmlResBase();
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/DelSale/{ptSalId}", Method.Delete);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                oRes = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResBase>(oResponse.Content);
                if (oRes != null && oRes.rtCode == "001")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                return false;
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog("cSaleService", "C_POSTbDelSale:" + oEx.Message);
                return false;
            }
            finally
            {

            }
        }

    }
}
