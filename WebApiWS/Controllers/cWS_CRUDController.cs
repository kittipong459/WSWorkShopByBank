using BuildingBlocks.Class;
using BuildingBlocks.Models.WebService.Response.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System;
using WebApiSTD.Class;
using wModels;

namespace WebApiWS.Controllers
{
    [Route("api/WSCRUD")]
    [ApiController]
    public class cWS_CRUDController : ControllerBase
    {

        [HttpGet]
        [Route("GetProduct")]
        public cmlResList<cmlResPdt> C_GET_oGetPdt()
        {
            cmlResList<cmlResPdt> oResult;
            string tErrAPI;
            try
            {
                oResult = new cmlResList<cmlResPdt>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
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
                toSql = @"  SELECT FNPdtID as rnPdtID,FTPdtCod as rtPdtCod,FTPdtName as rtPdtName,
FTPdtDes as rtPdtDes,FCPdtPri as rcPdtPri,FNPdtQty as rnPdtQty,FDPdtSMPT as rdPdtSMPT 
FROM TWsMPdt ";
                oSql.AppendLine(toSql);
                List<cmlResPdt> oResultPdt = oDatabase.C_GETaDataQuery<cmlResPdt>(oSql.ToString());
                oResult.raItems = oResultPdt;
                oResult.rtCode = cMS.tMS_RespCode001;
                oResult.rtDesc = cMS.tMS_RespDesc001;
                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResList<cmlResPdt>();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
                return oResult;
            }
            finally
            {

            }
        }


        [HttpPost]
        [Route("AddProduct")]
        public cmlResBase C_POST_oAddPdt([FromBody] cmlReqPdt paoDataProduct)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();

                //Check Model
                if (paoDataProduct == null)
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
                oRabbitMQ = new cRabbitMQ();

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(paoDataProduct);
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
                return oResult;
            }
            finally
            {
                paoDataProduct = null;
                oRabbitMQ = null;
            }
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public cmlResBase C_POST_oUpPdt([FromBody] cmlReqPdt paoDataProduct)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();

                //Check Model
                if (paoDataProduct == null)
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
                oRabbitMQ = new cRabbitMQ();

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(paoDataProduct);
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
                return oResult;
            }
            finally
            {
                paoDataProduct = null;
                oRabbitMQ = null;
            }
        }


        [HttpGet]
        [Route("GetSale")]
        public cmlResList<cmlResSale> C_GET_oGetSale()
        {
            cmlResList<cmlResSale> oResult;
            string tErrAPI;
            try
            {
                oResult = new cmlResList<cmlResSale>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
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
  FROM TWsTSal ";
                oSql.AppendLine(toSql);
                List<cmlResSale> oResultPdt = oDatabase.C_GETaDataQuery<cmlResSale>(oSql.ToString());
                oResult.raItems = oResultPdt;
                oResult.rtCode = cMS.tMS_RespCode001;
                oResult.rtDesc = cMS.tMS_RespDesc001;
                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResList<cmlResSale>();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
                return oResult;
            }
            finally
            {

            }
        }

        [HttpGet]
        [Route("GetCustomer")]
        public cmlResList<cmlResCst> C_GET_oGetCst()
        {
            cmlResList<cmlResCst> oResult;
            string tErrAPI;
            try
            {
                oResult = new cmlResList<cmlResCst>();

                //Check API Key
                if (!new cSP().C_CHKbKeyApiConfig(HttpContext, out tErrAPI))
                {
                    oResult.rtCode = cMS.tMS_RespCode904;
                    oResult.rtDesc = cMS.tMS_RespDesc904;
                    return oResult;
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
  FROM AdaWSbyBank.dbo.TWsMCst ";
                oSql.AppendLine(toSql);
                List<cmlResCst> oResultPdt = oDatabase.C_GETaDataQuery<cmlResCst>(oSql.ToString());
                oResult.raItems = oResultPdt;
                oResult.rtCode = cMS.tMS_RespCode001;
                oResult.rtDesc = cMS.tMS_RespDesc001;
                return oResult;
            }
            catch (Exception oEx)
            {
                oResult = new cmlResList<cmlResCst>();
                oResult.rtCode = cMS.tMS_RespCode900;
                oResult.rtDesc = cMS.tMS_RespDesc900 + " : " + oEx.Message;
                return oResult;
            }
            finally
            {

            }
        }



        ////////////////
        ///


        [HttpPost]
        [Route("AddSale")]
        public cmlResBase C_POST_oAddSale([FromBody] cmlReqSale paoSale)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();

                //Check Model
                if (paoSale == null)
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
                oRabbitMQ = new cRabbitMQ();

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(paoSale);
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
                return oResult;
            }
            finally
            {
                paoSale = null;
                oRabbitMQ = null;
            }
        }


        [HttpPost]
        [Route("UpdateSale")]
        public cmlResBase C_POST_oUpdateSale([FromBody] cmlReqSale paoSale)
        {
            cmlResBase oResult;
            cRabbitMQ oRabbitMQ;
            string tErrAPI;

            try
            {
                oResult = new cmlResBase();

                //Check Model
                if (paoSale == null)
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
                oRabbitMQ = new cRabbitMQ();

                //Convert to string json
                string tMsgJson = Newtonsoft.Json.JsonConvert.SerializeObject(paoSale);
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
                return oResult;
            }
            finally
            {
                paoSale = null;
                oRabbitMQ = null;
            }
        }







        ///////////


    }
}
