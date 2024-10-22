using BuildingBlocks.Class;
using BuildingBlocks.Models.WebService.Response.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System;
using WebApiSTD.Class;
using ServiceModels;
using wModels.Response;

namespace WebApiWS.Controllers
{
    [Route("api/WSCRUD")]
    [ApiController]
    public class cWSCRUDController : ControllerBase
    {

        [HttpGet]
        [Route("GetProduct")]
        public cmlResList<cmlResPdt> C_GETaGetPdt()
        {
            cmlResList<cmlResPdt> aoResult;
            string tErrAPI;
            try
            {
                aoResult = new cmlResList<cmlResPdt>();
                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    aoResult.rtCode = cMS.tMS_RespCode904;
                    aoResult.rtDesc = cMS.tMS_RespDesc904;
                    return aoResult;
                }
                else
                {
                    //TODO::
                }
                //process..
                cDatabase oDatabase = new cDatabase();
                StringBuilder oSql;
                oSql = new StringBuilder();
                string tSql = "";
                tSql = @"  SELECT FNPdtID as rnPdtID,FTPdtCod as rtPdtCod,FTPdtName as rtPdtName,
FTPdtDes as rtPdtDes,FCPdtPri as rcPdtPri,FNPdtQty as rnPdtQty,FDPdtSMPT as rdPdtSMPT ,FTPdtStat as rtPdtStat
FROM TWsMPdt With(nolock) where FTPdtStat = 'Y'";
                oSql.AppendLine(tSql);
                List<cmlResPdt> aoResultPdt = oDatabase.C_GETaDataQuery<cmlResPdt>(oSql.ToString());
                aoResult.raItems = aoResultPdt;
                aoResult.rtCode = cMS.tMS_RespCode001;
                aoResult.rtDesc = cMS.tMS_RespDesc001;
                return aoResult;
            }
            catch (Exception oEx)
            {
                aoResult = new cmlResList<cmlResPdt>();
                aoResult.rtCode = cMS.tMS_RespCode900;
                aoResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;

            }
            finally
            {
                aoResult = null;
            }
            return aoResult;
        }


        [HttpPost]
        [Route("AddProduct")]
        public cmlResBase C_POSoPosAddPdt([FromBody] cmlReqPdt poDataProduct)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();
                oRabbitMQ = new cRabbitMQ();
                //Check Model
                if (poDataProduct == null)
                {
                    oResult.rtCode = cMS.tMS_RespCode700;
                    oResult.rtDesc = cMS.tMS_RespDesc700;
                    return oResult;
                }
                else
                {

                }

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
                }
                else
                {

                }

                //To do..


                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poDataProduct);
                //Publish to rabbitMQ
                if (oRabbitMQ.C_PRCbSendData2Srv(tMsgJson, "AddPdt", true))
                {
                    oResult.rtCode = cMS.tMS_RespCode001;
                    oResult.rtDesc = cMS.tMS_RespDesc001;
                }
                else
                {
                    oResult.rtCode = cMS.tMS_RespCode907;
                    oResult.rtDesc = cMS.tMS_RespDesc907;
                }
                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResBase();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;

            }
            finally
            {
                poDataProduct = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }

        [HttpPost]
        [Route("UpdateProduct")]
        //public cmlResBase C_POST_oUpPdt([FromBody] cmlReqPdt poDataProduct)
        public cmlResBase C_POSoPosUpPdt([FromBody] cmlReqPdt poDataProduct)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();
                oRabbitMQ = new cRabbitMQ();
                //Check Model
                if (poDataProduct == null)
                {
                    oResult.rtCode = cMS.tMS_RespCode700;
                    oResult.rtDesc = cMS.tMS_RespDesc700;
                    return oResult;
                }
                else
                {

                }

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
                }
                else
                {

                }

                //To do..

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poDataProduct);
                //Publish to rabbitMQ
                if (oRabbitMQ.C_PRCbSendData2Srv(tMsgJson, "UpdatePdt", true))
                {
                    oResult.rtCode = cMS.tMS_RespCode001;
                    oResult.rtDesc = cMS.tMS_RespDesc001;
                }
                else
                {
                    oResult.rtCode = cMS.tMS_RespCode907;
                    oResult.rtDesc = cMS.tMS_RespDesc907;
                }

                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResBase();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
            }
            finally
            {
                poDataProduct = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }


        [HttpGet]
        [Route("GetSale")]
        public cmlResList<cmlResSale> C_GETaGetSale()
        {
            cmlResList<cmlResSale> aoResult;
            string tErrAPI;
            try
            {
                aoResult = new cmlResList<cmlResSale>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    aoResult.rtCode = cMS.tMS_RespCode904;
                    aoResult.rtDesc = cMS.tMS_RespDesc904;
                    return aoResult;
                }
                else
                {
                    //TODO::
                }
                //process..
                cDatabase oDatabase = new cDatabase();
                StringBuilder oSql;
                oSql = new StringBuilder();
                string toSql = "";
                toSql = @" SELECT FNSalID as rnSalID
      ,FTSalCod as rtSalCod
      ,FTSalPdtCod as rtSalPdtCod
      ,FNSalQty as rnSalQty
      ,FCSalPri as rcSalPri
      ,FCSalAmt as rcSalAmt
      ,FTSalCstCod as rtSalCstCod
      ,FDSalDate as rdSalDate
      ,FDSalSMPT as rdSalSMPT
  FROM TWsTSal With(nolock)";
                oSql.AppendLine(toSql);
                List<cmlResSale> aoResultSal = oDatabase.C_GETaDataQuery<cmlResSale>(oSql.ToString());
                aoResult.raItems = aoResultSal;
                aoResult.rtCode = cMS.tMS_RespCode001;
                aoResult.rtDesc = cMS.tMS_RespDesc001;
                return aoResult;
            }
            catch (Exception oEx)
            {
                aoResult = new cmlResList<cmlResSale>();
                aoResult.rtCode = cMS.tMS_RespCode900;
                aoResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
            }
            finally
            {
                aoResult = null;
            }
            return aoResult;
        }

        [HttpGet]
        [Route("GetCustomer")]
        public cmlResList<cmlResCst> C_GET_oGetCst()
        {
            cmlResList<cmlResCst> aoResult;
            string tErrAPI;
            try
            {
                aoResult = new cmlResList<cmlResCst>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    aoResult.rtCode = cMS.tMS_RespCode904;
                    aoResult.rtDesc = cMS.tMS_RespDesc904;
                    return aoResult;
                }
                else
                {
                    //TODO::
                }
                //process..
                cDatabase oDatabase = new cDatabase();
                StringBuilder oSql;
                oSql = new StringBuilder();
                string toSql = "";
                toSql = @" SELECT FTCstID as rtCstID
      ,FTCstCod as rtCstCod
      ,FTCstName as rtCstName
      ,FTCstEml as rtCstEml
      ,FTCstPho as rtCstPho
      ,FTCstAdr as rtCstAdr
      ,FDCstSMPT as rdCstSMPT
  FROM AdaWSbyBank.dbo.TWsMCst With(nolock)";
                oSql.AppendLine(toSql);
                List<cmlResCst> aoResultCst = oDatabase.C_GETaDataQuery<cmlResCst>(oSql.ToString());
                aoResult.raItems = aoResultCst;
                aoResult.rtCode = cMS.tMS_RespCode001;
                aoResult.rtDesc = cMS.tMS_RespDesc001;
                return aoResult;
            }
            catch (Exception oEx)
            {
                aoResult = new cmlResList<cmlResCst>();
                aoResult.rtCode = cMS.tMS_RespCode900;
                aoResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
            }
            finally
            {
                aoResult = null;
            }
            return aoResult;
        }



        ////////////////
        ///


        [HttpPost]
        [Route("AddSale")]
        public cmlResBase C_POSoPosAddSale([FromBody] cmlReqSale poSale)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResList<cmlResSale>();
                oRabbitMQ = new cRabbitMQ();

                //Check Model
                if (poSale == null)
                {
                    oResult.rtCode = cMS.tMS_RespCode700;
                    oResult.rtDesc = cMS.tMS_RespDesc700;
                    return oResult;
                }
                else
                {

                }

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
                }
                else
                {

                }

                //To do..


                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSale);
                //Publish to rabbitMQ
                if (oRabbitMQ.C_PRCbSendData2Srv(tMsgJson, "AddSale", true))
                {
                    oResult.rtCode = cMS.tMS_RespCode001;
                    oResult.rtDesc = cMS.tMS_RespDesc001;
                }
                else
                {
                    oResult.rtCode = cMS.tMS_RespCode907;
                    oResult.rtDesc = cMS.tMS_RespDesc907;
                }
                return oResult;

            }
            catch (Exception oEx)
            {
                oResult = new cmlResBase();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
               
            }
            finally
            {
                poSale = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }


        [HttpPost]
        [Route("UpdateSale")]
        public cmlResBase C_POSoPosUpdateSale([FromBody] cmlReqSale poSale)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();
                oRabbitMQ = new cRabbitMQ();

                //Check Model
                if (poSale == null)
                {
                    oResult.rtCode = cMS.tMS_RespCode700;
                    oResult.rtDesc = cMS.tMS_RespDesc700;
                    return oResult;
                }
                else
                {

                }

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
                }
                else
                {

                }

                //To do..
                

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(poSale);
                //Publish to rabbitMQ
                if (oRabbitMQ.C_PRCbSendData2Srv(tMsgJson, "UpdateSale", true))
                {
                    oResult.rtCode = cMS.tMS_RespCode001;
                    oResult.rtDesc = cMS.tMS_RespDesc001;
                }
                else
                {
                    oResult.rtCode = cMS.tMS_RespCode907;
                    oResult.rtDesc = cMS.tMS_RespDesc907;
                }

                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResBase();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
                
            }
            finally
            {
                poSale = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }


        [HttpDelete]
        [Route("DelSale/{SalId}")]
        public cmlResBase C_GEToGetDelProduct(string tSalId) // PRC == process
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();
                oRabbitMQ = new cRabbitMQ();

                //Check Model
                if (string.IsNullOrEmpty(tSalId))
                {
                    oResult.rtCode = cMS.tMS_RespCode700;
                    oResult.rtDesc = cMS.tMS_RespDesc700;
                    return oResult;
                }
                else
                {

                }

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
                }
                else
                {

                }

                //To do..
                
                //Convert to string json
                string tMsgJson = tSalId;
                //Publish to rabbitMQ
                if (oRabbitMQ.C_PRCbSendData2Srv(tMsgJson, "DelSale", true))
                {
                    oResult.rtCode = cMS.tMS_RespCode001;
                    oResult.rtDesc = cMS.tMS_RespDesc001;
                }
                else
                {
                    oResult.rtCode = cMS.tMS_RespCode907;
                    oResult.rtDesc = cMS.tMS_RespDesc907;
                }

                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResBase();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
                return oResult;
            }
            finally
            {
                tSalId = null;
                oRabbitMQ = null;
            }
        }

        [HttpGet]
        [Route("GetSaleDetail/{tSechSalCode}")]
        public cmlResList<cmlResSalDet> C_GETaGetSaleDetail(string tSechSalCode)
        {
            cmlResList<cmlResSalDet> aoResult;
            string tErrAPI;
            try
            {
                aoResult = new cmlResList<cmlResSalDet>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    aoResult.rtCode = cMS.tMS_RespCode904;
                    aoResult.rtDesc = cMS.tMS_RespDesc904;
                    return aoResult;
                }
                else
                {
                    //TODO::
                }
                //process..
                cDatabase oDatabase = new cDatabase();
                StringBuilder oSql;
                oSql = new StringBuilder();
                string toSql = "";
                toSql = $@" select FTSalCod as rtSalCod  , FTSalPdtCod as rtSalPdtCod, 
                        FTPdtName as rtPdtName, FTPdtDes as rtPdtDes, FTPdtTyp as rtPdtTyp,
                        FNSalQty as rnSalQty, FCSalPri as rcSalPri, FCSalAmt as rcSalAmt, FDSalDate as rdSalDate,
                        FTSalCstCod as rtSalCstCod, FTCstName as rtCstName,
                        FTCstAdr as rtCstAdr, FTCstPho as rtCstPho, FTCstEml as rtCstEml, FDSalSMPT as rdSalSMPT
                        from VIE_WsSal where FTSalCod = N'{tSechSalCode}'";
                oSql.AppendLine(toSql);
                List<cmlResSalDet> aoResultPdt = oDatabase.C_GETaDataQuery<cmlResSalDet>(oSql.ToString());
                aoResult.raItems = aoResultPdt;
                aoResult.rtCode = cMS.tMS_RespCode001;
                aoResult.rtDesc = cMS.tMS_RespDesc001;
                return aoResult;
            }
            catch (Exception oEx)
            {
                aoResult = new cmlResList<cmlResSalDet>();
                aoResult.rtCode = cMS.tMS_RespCode900;
                aoResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
            }
            finally
            {
                aoResult = null;
            }
            return aoResult;
        }



        ///////////


    }
}
