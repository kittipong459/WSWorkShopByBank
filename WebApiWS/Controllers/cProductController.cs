using BuildingBlocks.Class;
using BuildingBlocks.Models.WebService.Response.Base;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System;
using WebApiSTD.Class;
using ServiceModels;

namespace WebApiWS.Controllers
{
    [Route("api/WSCRUD")]
    [ApiController]
    public class cProductController : ControllerBase
    {

        [HttpGet]
        [Route("GetProduct")]
        public cmlResList<cmlResPdt> GET_GETaoGetPdt()
        {
            cmlResList<cmlResPdt> aoResult = new cmlResList<cmlResPdt>();
            string tErrAPI;
            try
            {
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
                toSql = @"  SELECT FNPdtID as rnPdtID,FTPdtCod as rtPdtCod,FTPdtName as rtPdtName,
FTPdtDes as rtPdtDes,FCPdtPri as rcPdtPri,FNPdtQty as rnPdtQty,FDPdtSMPT as rdPdtSMPT 
FROM TWsMPdt With(nolock)";
                oSql.AppendLine(toSql);
                List<cmlResPdt> oResultPdt = oDatabase.C_GETaDataQuery<cmlResPdt>(oSql.ToString());
                aoResult.raItems = oResultPdt;
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
        public cmlResBase POST_SEToAddPdt([FromBody] cmlReqPdt poDataProduct)
        {
            cmlResBase oResult = new cmlResBase();
            cRabbitMQ oRabbitMQ = new cRabbitMQ();
            string tErrAPI;

            try
            {

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
        public cmlResBase POST_SEToUpPdt([FromBody] cmlReqPdt poDataProduct)
        {
            cmlResBase oResult = new cmlResBase();
            cRabbitMQ oRabbitMQ = new cRabbitMQ();
            string tErrAPI;

            try
            {

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
        public cmlResList<cmlResSale> GET_GETaoGetSale()
        {
            cmlResList<cmlResSale> aoResult = new cmlResList<cmlResSale>();
            string tErrAPI;
            try
            {


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
                List<cmlResSale> oResultPdt = oDatabase.C_GETaDataQuery<cmlResSale>(oSql.ToString());
                aoResult.raItems = oResultPdt;
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
        public cmlResList<cmlResCst> GET_GETaoGetCst()
        {
            cmlResList<cmlResCst> aoResult = new cmlResList<cmlResCst>();
            string tErrAPI;
            try
            {
                

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
                List<cmlResCst> oResultPdt = oDatabase.C_GETaDataQuery<cmlResCst>(oSql.ToString());
                aoResult.raItems = oResultPdt;
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
        public cmlResBase POST_SEToAddSale([FromBody] cmlReqSale paoSale)
        {
            cmlResBase oResult = new cmlResList<cmlResSale>();
            cRabbitMQ oRabbitMQ = new cRabbitMQ();
            string tErrAPI;

            try
            {


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
               
            }
            finally
            {
                paoSale = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }


        [HttpPost]
        [Route("UpdateSale")]
        public cmlResBase POST_SEToUpdateSale([FromBody] cmlReqSale paoSale)
        {
            cmlResBase oResult = new cmlResBase();
            cRabbitMQ oRabbitMQ = new cRabbitMQ();
            string tErrAPI;

            try
            {
               

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
                
            }
            finally
            {
                paoSale = null;
                oRabbitMQ = null;
                oResult = null;
            }
            return oResult;
        }


        [HttpDelete]
        [Route("DelSale/{SalId}")]
        public cmlResBase POST_PRCoDELProduct(string SalId) // PRC == process
        {
            cmlResBase oResult = new cmlResBase();
            cRabbitMQ oRabbitMQ = new cRabbitMQ();
            string tErrAPI;

            try
            {
                

                //Check Model
                if (string.IsNullOrEmpty(SalId))
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
                string tMsgJson = SalId;
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
                SalId = null;
                oRabbitMQ = null;
            }
        }





        ///////////


    }
}
