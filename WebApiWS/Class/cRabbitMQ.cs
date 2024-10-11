using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSTD.Class
{
    public class cRabbitMQ
    {

        /// <summary>
        /// Send Message to Server RabbitMQ
        /// </summary>
        /// <param name="ptMsg">message</param>
        /// <param name="ptQueue">Queue Name</param>
        /// <param name="pbDurable">อยู่ที่ Queue ที่จะส่งไป Set Durable หรือไม่ </param>
        /// <returns></returns>
        public bool C_PRCbSendData2Srv(string ptMsg, string ptQueue, bool pbDurable = false)
        {
            try
            {
                ConnectionFactory oFactory = new ConnectionFactory();
                oFactory.HostName = cVB.oVB_MQSettings.tHostName;
                oFactory.UserName = cVB.oVB_MQSettings.tUserName;
                oFactory.Password = cVB.oVB_MQSettings.tPassword;
                oFactory.VirtualHost = cVB.oVB_MQSettings.tVirtualHost;
                using (IConnection oConn = oFactory.CreateConnection())
                {
                    using (IModel oChannel = oConn.CreateModel())
                    {
                        oChannel.QueueDeclare(ptQueue, durable: pbDurable, false, false, null);
                        var oBody = Encoding.UTF8.GetBytes(ptMsg);
                        oChannel.BasicPublish("", ptQueue, false, null, oBody);
                    }
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
