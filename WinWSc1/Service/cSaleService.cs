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

        public List<cmlResSale> C_GETaoSale()
        {
            List<cmlResSale> aoResSal = new List<cmlResSale>();

            try
            {
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/GetSale", Method.Get);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                cmlResList<cmlResSale> aoResList = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlResSale>>(oResponse.Content);
                aoResSal = aoResList.raItems;
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


        // public bool C_POSbSaveSale(cmlReqSale oSalData)
        public bool C_POSTbSaveSale(cmlReqSale oSalData)
        {
            bool bReqAddsal = false;
            cmlResList<cmlReqSale> aoAddSal = new cmlResList<cmlReqSale>();
            try
            {
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(oSalData);
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/AddSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                //Console.WriteLine(oResponse.Content);
                aoAddSal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlReqSale>>(oResponse.Content);
                if (aoAddSal != null)
                {
                    if (aoAddSal.rtCode == "001")
                    {
                        bReqAddsal = true;
                    }
                    else
                    {
                        bReqAddsal = false;
                    }
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

        public bool C_POSTbUpdateSale(cmlReqSale oSalData)
        {
            bool bReqUpSal = false;
            cmlResList<cmlReqSale> aoUpsal = new cmlResList<cmlReqSale>();
            try
            {
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(oSalData);
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/UpdateSale", Method.Post);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                oRrequest.AddHeader("Content-Type", "application/json");
                oRrequest.AddStringBody(tMsgJson, DataFormat.Json);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                aoUpsal = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResList<cmlReqSale>>(oResponse.Content);
                if (aoUpsal.rtCode == "001")
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

        public bool C_POSTbDelSale(string tSalId)
        {
            try
            {
                RestClientOptions oPtions = new RestClientOptions(tC_UrlApi);
                RestClient oClient = new RestClient(oPtions);
                RestRequest oRrequest = new RestRequest($"/api/WSCRUD/DelSale/{tSalId}", Method.Delete);
                oRrequest.AddHeader("X-Api-Key", tC_Access);
                RestResponse oResponse = oClient.Execute(oRrequest);
                Console.WriteLine(oResponse.Content);
                var oRes = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlResBase>(oResponse.Content);
                if (oRes.rtCode == "001")
                {
                    return true;
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
