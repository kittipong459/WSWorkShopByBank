using BuildingBlocks.Models.Config;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Class
{
    public class cConfig
    {
        public bool C_CFGbLoadConfig(out string ptMsgErr)
        {
            NameValueCollection oRabbitMQCfg, oDBSetting;

            try
            {
                // load configuration from App.cofig
                oRabbitMQCfg = (NameValueCollection)ConfigurationManager.GetSection("rabbitMQSettings");
                oDBSetting = (NameValueCollection)ConfigurationManager.GetSection("DBSetting");
               
                if (oRabbitMQCfg == null)
                {
                    ptMsgErr = "No config Rabbit MQ !!!";
                    return false;
                }

                if (oDBSetting == null)
                {
                    ptMsgErr = "No config datbase !!!";
                    return false;
                }

                // rabbit MQ setting
                cVB.oVB_MQSetting = new cmlRabbitMQSetting();
                cVB.oVB_MQSetting.tMQHostName = oRabbitMQCfg["HostName"].Trim();
                cVB.oVB_MQSetting.tMQUserName = oRabbitMQCfg["UserName"].Trim();
                cVB.oVB_MQSetting.tMQPassword = oRabbitMQCfg["Password"].Trim();
                cVB.oVB_MQSetting.tMQVirtualHost = oRabbitMQCfg["VirtualHost"].Trim();
                cVB.oVB_MQSetting.tMQListQueue = oRabbitMQCfg["ListQueue"].Trim();

                if (string.IsNullOrEmpty(oRabbitMQCfg.Get("Port")) == false)
                {
                    cVB.oVB_MQSetting.nPort = Convert.ToInt32(oRabbitMQCfg.Get("Port"));
                }
                else
                {
                    cVB.oVB_MQSetting.nPort = 5672;
                }

                if (string.IsNullOrEmpty(oRabbitMQCfg.Get("Prefetch")) == false)
                {
                    cVB.oVB_MQSetting.nPrefetch = Convert.ToInt32(oRabbitMQCfg.Get("Prefetch"));
                }
                else
                {
                    cVB.oVB_MQSetting.nPrefetch = 0;
                }

                // Database setting.
                cVB.oC_DBSetting = new cmlDBSetting();
                cVB.oC_DBSetting.tAuthenMode = oDBSetting["AuthenMode"].Trim();
                cVB.oC_DBSetting.nCommandTimeOut = Convert.ToInt32(oDBSetting["CommandTimeOut"].Trim());
                cVB.oC_DBSetting.tServer = oDBSetting["Server"].Trim();
                cVB.oC_DBSetting.tUser = oDBSetting["User"].Trim();
                cVB.oC_DBSetting.tPassword = oDBSetting["Password"].Trim();
                cVB.oC_DBSetting.tDatabase = oDBSetting["Database"].Trim();

                if (cVB.oC_DBSetting != null)
                {
                    cVB.nVB_CmdTime = (int)cVB.oC_DBSetting.nCommandTimeOut;
                    cVB.tVB_ConnStr = new cDatabase().C_GETtConnectString(cVB.oC_DBSetting.tServer, cVB.oC_DBSetting.tUser, cVB.oC_DBSetting.tPassword, cVB.oC_DBSetting.tDatabase, (int)cVB.nVB_CmdTime, cVB.oC_DBSetting.tAuthenMode);
                }
                
                ptMsgErr = "";
                return true;
            }
            catch (Exception oExn)
            {
                ptMsgErr = oExn.Message;
            }

            finally
            {
                oRabbitMQCfg = null;
                

            }

            return false;
        }

    }
}
