using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConAppSTD.Class
{
    class cMQReceiver
    {
        private List<IConnection> aoC_MQConn;  //เก็บ Connection
        private List<IModel> aoC_MQChannel; //เก็บ Channel ไว้ตรวจสอบ

        public cMQReceiver()
        {
            try
            {
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        /// <summary>
        /// Process receive message RabbitMQ.
        /// </summary>
        public void C_MQRxProcess()
        {
            ConnectionFactory oFactory;
            ThreadStart oStart;
            Thread oTherad;
            IConnection oConn;
            IModel oChannel;
            //cMS oMsg;
            List<string> atQueue;
            string tMsgErr;

            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                if (new cConfig().C_CFGbLoadConfig(out tMsgErr))
                {
                    Console.WriteLine("========================================================================");
                    Console.WriteLine("Host name:       {0}", cVB.oVB_MQSetting.tMQHostName);
                    Console.WriteLine("User name:       {0}", cVB.oVB_MQSetting.tMQUserName);
                    Console.WriteLine("Virtual host:    {0}", cVB.oVB_MQSetting.tMQVirtualHost);
                    Console.WriteLine("========================================================================");

                    oFactory = new ConnectionFactory();
                    oFactory.HostName = cVB.oVB_MQSetting.tMQHostName;
                    oFactory.UserName = cVB.oVB_MQSetting.tMQUserName;
                    oFactory.Password = cVB.oVB_MQSetting.tMQPassword;
                    oFactory.VirtualHost = cVB.oVB_MQSetting.tMQVirtualHost;

                    if (cVB.oVB_MQSetting.nPort == 5671)
                    {
                        oFactory.Ssl = new SslOption();
                        oFactory.Ssl.Enabled = true;
                        oFactory.Ssl.AcceptablePolicyErrors = System.Net.Security.SslPolicyErrors.RemoteCertificateNameMismatch | System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors;
                        oFactory.Ssl.Version = System.Security.Authentication.SslProtocols.Tls12;
                    }

                    atQueue = cVB.oVB_MQSetting.tMQListQueue.Split(',').ToList();

                    aoC_MQConn = new List<IConnection>();
                    aoC_MQChannel = new List<IModel>();

                    foreach (string tQueue in atQueue)
                    {
                        if (string.Equals(tQueue, ""))
                        {
                            continue;
                        }

                        oConn = oFactory.CreateConnection();
                        oChannel = oConn.CreateModel();

                        oStart = () => C_PRCxMessage(oChannel, tQueue);
                        oTherad = new Thread(oStart);
                        oTherad.Name = tQueue;
                        oTherad.IsBackground = true;
                        oTherad.Start();

                        aoC_MQConn.Add(oConn);  //เก็บ Connection
                        aoC_MQChannel.Add(oChannel);  //เก็บ Channel
                    }

                    bool bIsOpen = true;
                    while (bIsOpen)
                    {
                        foreach (IConnection oConnection in aoC_MQConn)
                        {
                            if (oConnection.IsOpen == false)
                            {
                                bIsOpen = false;
                                break;
                            }
                        }

                        foreach (IModel oChn in aoC_MQChannel)
                        {
                            if (oChn.IsOpen == false)
                            {
                                bIsOpen = false;
                                break;
                            }
                        }

                        Task.Delay(10000).Wait();
                    }

                    foreach (IModel oChn in aoC_MQChannel)
                    {
                        oChn.Close();
                    }

                    foreach (IConnection oConnection in aoC_MQConn)
                    {
                        oConnection.Close();
                    }
                }
                else
                {
                    Console.WriteLine(tMsgErr);
                    Task.Delay(10000).Wait();
                }
            }
            catch (Exception oExn)
            {
                Console.WriteLine(oExn.Message.ToString());
                Task.Delay(10000).Wait();
            }
            finally
            {
                oFactory = null;
                oStart = null;
                oTherad = null;
                oConn = null;
                oChannel = null;
                atQueue = null;
            }
        }

        /// <summary>
        /// Process receive message RabbitMQ by queue name.
        /// </summary>
        /// <param name="poChannel">Channel.</param>
        /// <param name="ptQueue">Queue name.</param>
        private void C_PRCxMessage(IModel poChannel, string ptQueue)
        {
            EventingBasicConsumer oConsumer;
            string tMessage = "";
            string tQueueID = "";
            string tMsgErr = "";
            byte[] aoBody;
            bool bStaConsume;
            bool bPrc = true;
            try
            {
                // วนรอกรณีที่ message broker ยังไม่มี queue name ตาม config.
                bStaConsume = false;

                while (bStaConsume == false)
                {
                    try
                    {
                        switch (ptQueue)
                        {
                            case "QueueName1":
                            case "QueueName2":
                                //Declare Exchange
                                string tExchangeName = "ExchangeName1";
                                poChannel.ExchangeDeclare(exchange: tExchangeName, type: "fanout");

                                //Declare Queue
                                poChannel.QueueDeclare(queue: ptQueue, durable: true, exclusive: false, autoDelete: false, arguments: null);

                                //Binding Queue to Exchange
                                poChannel.QueueBind(ptQueue, tExchangeName, "", null);

                                break;

                            default:
                                //Declare Queue
                                poChannel.QueueDeclare(queue: ptQueue, durable: true, exclusive: false, autoDelete: false, arguments: null);
                                break;
                        }


                        oConsumer = new EventingBasicConsumer(poChannel);
                        oConsumer.Received += (oModel, oEevntArgs) =>
                        {
                            aoBody = oEevntArgs.Body;
                            tMessage = Encoding.UTF8.GetString(aoBody); //Receive Message
                            tQueueID = oEevntArgs.ConsumerTag.ToString().Substring(9) + oEevntArgs.DeliveryTag.ToString(); //ID queue

                            switch (ptQueue)
                            {
                                case "AddPdt":
                                    try
                                    {
                                        Console.WriteLine("Receive Queue Nmae: " + ptQueue + " start.");
                                        //Process 
                                        cmlReqPdt oPdtData = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlReqPdt>(tMessage);

                                        cExample oExample = new cExample();
                                        string tMsgErr = "";
                                        bPrc = cExample.C_ADPbAddPdtTransaction(oPdtData);

                                        if (bPrc)
                                        {
                                            //delete this message queue
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                            string ptMsgErr = "";
                                            //Publish
                                            try
                                            {
                                                string tMsgJson = tMessage;
                                                poChannel.QueueDeclare("PD_SAVE", true, false, false, null);
                                                var oBody = Encoding.UTF8.GetBytes(tMsgJson);
                                                poChannel.BasicPublish("", "PD_SAVE", false, null, oBody);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                        }
                                    }
                                    catch (Exception oEx)
                                    {

                                    }
                                    Console.WriteLine("Receive Queue Nmae: " + ptQueue + " end.");
                                    Thread.Sleep(500);
                                    break;
                                case "UpdatePdt":
                                    try
                                    {
                                        Console.WriteLine("Receive Queue Nmae: " + ptQueue + " start.");
                                        //Process 
                                        cmlReqPdt oPdtData = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlReqPdt>(tMessage);

                                        cExample oExample = new cExample();
                                        string tMsgErr = "";
                                        bPrc = cExample.C_UPPbUpdPdtTransaction(oPdtData);

                                        if (bPrc)
                                        {
                                            //delete this message queue
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                            string ptMsgErr = "";
                                            //Publish
                                            try
                                            {
                                                string tMsgJson = tMessage;
                                                poChannel.QueueDeclare("PD_SAVE", true, false, false, null);
                                                var oBody = Encoding.UTF8.GetBytes(tMsgJson);
                                                poChannel.BasicPublish("", "PD_SAVE", false, null, oBody);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                        }
                                    }
                                    catch (Exception oEx)
                                    {

                                    }
                                    Console.WriteLine("Receive Queue Nmae: " + ptQueue + " end.");
                                    Thread.Sleep(500);
                                    break;
                                case "AddSale":
                                    try
                                    {
                                        Console.WriteLine("Receive Queue Nmae: " + ptQueue + " start.");
                                        //Process 
                                        cmlReqSale oSalData = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlReqSale>(tMessage);

                                        cExample oExample = new cExample();
                                        string tMsgErr = "";
                                        bPrc = cExample.C_ADSbAddSaleTransaction(oSalData);

                                        if (bPrc)
                                        {
                                            //delete this message queue
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                            string ptMsgErr = "";
                                            //Publish
                                            try
                                            {
                                                string tMsgJson = tMessage;
                                                poChannel.QueueDeclare("PD_SAVE", true, false, false, null);
                                                var oBody = Encoding.UTF8.GetBytes(tMsgJson);
                                                poChannel.BasicPublish("", "PD_SAVE", false, null, oBody);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                        }
                                    }
                                    catch (Exception oEx)
                                    {

                                    }
                                    Console.WriteLine("Receive Queue Nmae: " + ptQueue + " end.");
                                    Thread.Sleep(500);
                                    break;
                                case "UpdateSale":
                                    try
                                    {
                                        Console.WriteLine("Receive Queue Nmae: " + ptQueue + " start.");
                                        //Process 
                                        cmlReqSale oSalData = Newtonsoft.Json.JsonConvert.DeserializeObject<cmlReqSale>(tMessage);

                                        cExample oExample = new cExample();
                                        string tMsgErr = "";
                                        bPrc = cExample.C_UPSbUpdateSaleTransaction(oSalData);

                                        if (bPrc)
                                        {
                                            //delete this message queue
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                            string ptMsgErr = "";
                                            //Publish
                                            try
                                            {
                                                string tMsgJson = tMessage;
                                                poChannel.QueueDeclare("PD_SAVE", true, false, false, null);
                                                var oBody = Encoding.UTF8.GetBytes(tMsgJson);
                                                poChannel.BasicPublish("", "PD_SAVE", false, null, oBody);
                                            }
                                            catch (Exception ex)
                                            {
                                                Console.WriteLine(ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                        }
                                    }
                                    catch (Exception oEx)
                                    {

                                    }
                                    Console.WriteLine("Receive Queue Nmae: " + ptQueue + " end.");
                                    Thread.Sleep(500);
                                    break;
                                case "DelSale":
                                    try
                                    {
                                        Console.WriteLine("Receive Queue Nmae: " + ptQueue + " start.");
                                        //Process 
                                        int tPdtCode = int.Parse(tMessage);

                                        cExample oExample = new cExample();
                                        string tMsgErr = "";
                                        bPrc = cExample.C_PRCxDelPdtTransaction(tPdtCode);

                                        if (bPrc)
                                        {
                                            //delete this message queue
                                            poChannel.BasicAck(oEevntArgs.DeliveryTag, false);
                                        }
                                        else
                                        {

                                        }
                                    }
                                    catch (Exception oEx)
                                    {

                                    }
                                    Console.WriteLine("Receive Queue Nmae: " + ptQueue + " end.");
                                    Thread.Sleep(500);
                                    break;

                                default:
                                    break;
                            };
                        };

                        poChannel.BasicConsume(queue: ptQueue, autoAck: false, consumer: oConsumer);

                        bStaConsume = true;
                        Thread.Sleep(500);


                    }
                    catch (RabbitMQ.Client.Exceptions.RabbitMQClientException oRMQExn)
                    {
                        switch (oRMQExn.HResult)
                        {
                            case -2146233088: // Queue name not found.
                                System.Threading.Thread.Sleep(20000); // 1000 milliseconds = 1 second.
                                break;
                        }
                    }
                    catch (Exception oEx)
                    {
                        tMessage = oEx.Message.ToString();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + ptQueue + " : Exception");
                Console.ReadLine();
            }
        }
    }
}
