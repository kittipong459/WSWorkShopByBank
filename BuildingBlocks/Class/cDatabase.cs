using BuildingBlocks.Class;
using BuildingBlocks.Models.Config;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BuildingBlocks.Class
{
    public class cDatabase
    {
        //MS SQL Server
        public string C_GETtConnectString(string ptSrvName, string ptUsr, string ptPwd, string ptDBName, int pnTimeOut, string ptAuthenMode = "2")
        {
            StringBuilder oConnStr;

            try
            {
                oConnStr = new StringBuilder();
                if (string.Equals(ptAuthenMode, "1"))
                {
                    // authen windows mode.
                    oConnStr.Append("Data Source = " + ptSrvName);
                    oConnStr.Append(";Initial Catalog = " + ptDBName);
                    oConnStr.Append(";Integrated Security = SSPI;");
                    oConnStr.Append(";Connection Timeout = " + pnTimeOut);
                }
                else
                {
                    // authen SQL mode.
                    oConnStr.Append("Data Source = " + ptSrvName);
                    oConnStr.Append(";Initial Catalog = " + ptDBName);
                    oConnStr.Append(";User ID = " + ptUsr);
                    oConnStr.Append(";Password = " + ptPwd);
                    oConnStr.Append(";Connection Timeout = " + pnTimeOut);
                }

                return oConnStr.ToString();
            }
            catch (Exception oEx)
            {

                return "";
            }
            finally
            {
                oConnStr = null;
            }
        }
        public SqlConnection C_CONoDatabase(cmlDBSetting poConfig)
        {
            SqlConnection oConn = null;
            string tConnString;

            try
            {
                // Windows Authen
                if (string.Equals(poConfig.tAuthenMode, "0"))
                {
                    tConnString = @"Server = " + poConfig.tServer + ";";

                    if (!string.IsNullOrEmpty(poConfig.tDatabase))
                        tConnString += "Database = " + poConfig.tDatabase + ";";

                    tConnString += "Integrated Security = True;";
                }
                // SQL Authen 
                else
                {
                    tConnString = @"Data Source = " + poConfig.tServer + ";";

                    if (!string.IsNullOrEmpty(poConfig.tDatabase))
                        tConnString += "Initial Catalog = " + poConfig.tDatabase + ";";

                    tConnString += "Persist Security Info = True;";
                    tConnString += "User ID = " + poConfig.tUser + ";";
                    tConnString += "Password = " + poConfig.tPassword + ";";
                }

                tConnString += "MultipleActiveResultSets=true;";
                cVB.tVB_ConnStr = tConnString;
                oConn = new SqlConnection(tConnString);
                oConn.Open();
            }
            catch (Exception oEx) 
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
            }

            return oConn;
        }


        //Microsoft Access
        public OleDbConnection C_CONoDatabaseOleDb(cmlDBSetting poConfig)
        {
            OleDbConnection oConn = null;
            string tConnString;

            try
            {
                // Windows Authen
                if (string.Equals(poConfig.tAuthenMode, "0"))
                {
                    tConnString = @"Provider= SQLOLEDB;Server = " + poConfig.tServer + ";";

                    if (!string.IsNullOrEmpty(poConfig.tDatabase))
                        tConnString += "Database = " + poConfig.tDatabase + ";";

                    tConnString += "Integrated Security = True;";
                }
                // SQL Authen 
                else
                {
                    tConnString = @"Provider= SQLOLEDB;Data Source = " + poConfig.tServer + ";";

                    if (!string.IsNullOrEmpty(poConfig.tDatabase))
                        tConnString += "Initial Catalog = " + poConfig.tDatabase + ";";

                    tConnString += "Persist Security Info = True;";
                    tConnString += "User ID = " + poConfig.tUser + ";";
                    tConnString += "Password = " + poConfig.tPassword + ";";
                }

                tConnString += "MultipleActiveResultSets=true;";
                // Zen 63-06-17 Update การเก็บ Connection เพื่อเอาไปใช้กรณีที่ต้องการแค่ Connection String
                cVB.tVB_ConnStr = tConnString;
                oConn = new OleDbConnection(tConnString);
                oConn.Open();
            }
            catch (Exception oEx) {
                Console.WriteLine(oEx.Message);
            }

            return oConn;
        }
        /// <summary>
        /// get data query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ptSql"></param>
        /// <returns></returns>
        public List<T> C_GETaDataQuery<T>(string ptSql, int nCmdTime = 60)
        {
            string tMsgErr;
            if (!new cConfig().C_CFGbLoadConfig(out tMsgErr))
            {
                return new List<T>();
            }
            List<T> aoItem = new List<T>();
            SqlConnection oConn = null;
            try
            {
                if (cVB.oC_DBSetting == null) return new List<T>();
                oConn = C_CONoDatabase(cVB.oC_DBSetting);
                //aoItem = oConn.Query<T>(ptSql, commandTimeout: 60).ToList();
                aoItem = oConn.Query<T>(ptSql, commandTimeout: nCmdTime).ToList();               
            }
            catch (Exception oEx)
            {
               Console.WriteLine($"{oEx.Message}");
            }
            finally
            {
                if (oConn != null)
                {
                    oConn.Close();
                    oConn.Dispose();
                }
            }

            return aoItem;
        }

        public T C_GEToDataQuery<T>(string ptSql)
        {
            T oItem = default(T);
            SqlConnection oConn = null;
            string tMsgErr;
            if (!new cConfig().C_CFGbLoadConfig(out tMsgErr))
            {
                return oItem;
            }
            try
            {
                oConn = C_CONoDatabase(cVB.oC_DBSetting);
                oItem = oConn.Query<T>(ptSql, commandTimeout: 60).FirstOrDefault();
            }
            catch (Exception oEx) {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                if (oConn != null)
                {
                    oConn.Close();
                    oConn.Dispose();
                }
            }
            return oItem;
        }
    }
}
