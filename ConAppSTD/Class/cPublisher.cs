using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSTD.Class
{
    class cPublisher
    {
        public void C_PRCxMQPublish(string ptQueueName, string ptMessage, out string ptErrMsg, bool pbDurable = false)
        {
            ConnectionFactory oFactory;
            string tQueueName = ptQueueName;
            try
            {
                oFactory = new ConnectionFactory();
                oFactory.HostName = cVB.oVB_MQSetting.tMQHostName;
                oFactory.UserName = cVB.oVB_MQSetting.tMQUserName;
                oFactory.Password = cVB.oVB_MQSetting.tMQPassword;
                oFactory.VirtualHost = cVB.oVB_MQSetting.tMQVirtualHost;
                
                if (cVB.oVB_MQSetting.nPort == 5671)
                {
                    //SSL
                    oFactory.Ssl = new SslOption();
                    oFactory.Ssl.Enabled = true;
                    oFactory.Ssl.AcceptablePolicyErrors = System.Net.Security.SslPolicyErrors.RemoteCertificateNameMismatch | System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
                    oFactory.Ssl.Version = System.Security.Authentication.SslProtocols.Tls12;
                }

                using (var oConn = oFactory.CreateConnection())
                {
                    using (var oChannel = oConn.CreateModel())
                    {
                        var oBody = Encoding.UTF8.GetBytes(ptMessage);
                        oChannel.QueueDeclare(tQueueName, true, false, false, null);
                        oChannel.BasicPublish("", tQueueName, false, null, oBody);
                        ptErrMsg = "";
                    }
                }
            }
            catch (Exception oEx)
            {
                ptErrMsg = oEx.Message.ToString();
            }
            finally
            {
                oFactory = null;
            }
        }

        /// <summary>
        /// Publish Message to Exchange
        /// </summary>
        /// <param name="ptExchange">Exchange Name</param>
        /// <param name="ptRoute">Routing</param>
        /// <param name="ptExchangeMode">direct,fanout,topic,headers</param>
        /// <param name="ptMessage">Message to send out</param>
        /// <param name="ptErrMsg">Error Message</param>
        public void C_PRCxMQPublishExchange(string ptExchange, string ptRoute, string ptExchangeMode, string ptMessage, out string ptErrMsg)
        {
            ConnectionFactory oFactory;
            string tExchangeName = ptExchange;
            string tRoute = ptRoute;
            string tExchangeMode = ptExchangeMode;
            try
            {
                oFactory = new ConnectionFactory();
                oFactory.HostName = cVB.oVB_MQSetting.tMQHostName;
                oFactory.UserName = cVB.oVB_MQSetting.tMQUserName;
                oFactory.Password = cVB.oVB_MQSetting.tMQPassword;
                oFactory.VirtualHost = cVB.oVB_MQSetting.tMQVirtualHost;

                if (cVB.oVB_MQSetting.nPort == 5671)
                {
                    //SSL
                    oFactory.Ssl = new SslOption();
                    oFactory.Ssl.Enabled = true;
                    oFactory.Ssl.AcceptablePolicyErrors = System.Net.Security.SslPolicyErrors.RemoteCertificateNameMismatch | System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
                    oFactory.Ssl.Version = System.Security.Authentication.SslProtocols.Tls12;
                }

                using (var oConn = oFactory.CreateConnection())
                {
                    using (var oChannel = oConn.CreateModel())
                    {
                        var oBody = Encoding.UTF8.GetBytes(ptMessage);
                        oChannel.ExchangeDeclare(tExchangeName, tExchangeMode, false, false, null);
                        oChannel.BasicPublish(tExchangeName, ptRoute, false, null, oBody);
                        ptErrMsg = "";
                    }
                }
            }
            catch (Exception oEx)
            {
                ptErrMsg = oEx.Message.ToString();
            }
            finally
            {
                oFactory = null;
            }
        }

    }
}
