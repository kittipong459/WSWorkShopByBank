using System;
using System.Text;
using BuildingBlocks.Class;
using ServiceModels;

namespace ConAppSTD.Class
{
    public class cExample
    {
        public static bool C_ADDbAddPdtTransaction(cmlReqPdt poPdt)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine("    INSERT INTO TWsMPdt (FTPdtCod,FTPdtName, FTPdtDes, FCPdtPri, FNPdtQty, FDPdtSMPT,FNPdtTyp)");
                oSql.AppendLine($"    VALUES (N'{poPdt.ptPdtCod}', N'{poPdt.ptPdtName}',  N'{poPdt.ptPdtDes}',{poPdt.pcPdtPri}, {poPdt.pnPdtQty}, GETDATE(), {poPdt.pnPdtTyp});");

                oSql.AppendLine("    COMMIT TRAN");
                oSql.AppendLine("    SELECT 1");
                oSql.AppendLine("END TRY");
                oSql.AppendLine("BEGIN CATCH");
                oSql.AppendLine("    ROLLBACK TRAN");
                oSql.AppendLine("    SELECT 0");
                oSql.AppendLine("END CATCH");
                if (oDB.C_GEToDataQuery<int>(oSql.ToString()) == 0)
                {
                    Console.WriteLine($"Transaction Error Add Product !!!");
                    return false;
                }
                return true;
            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                oDB = null;
                oSql = null;
            }
            return false;
        }

        public static bool C_UPDbUpdPdtTransaction(cmlReqPdt poPdt)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine($"    UPDATE TWsMPdt WITH (ROWLOCK) SET FTPdtName = N'{poPdt.ptPdtName}', FTPdtDes = N'{poPdt.ptPdtDes}', FCPdtPri = {poPdt.pcPdtPri}, FNPdtQty = {poPdt.pnPdtQty}, FDPdtSMPT = GETDATE(), FNPdtTyp = {poPdt.pnPdtTyp}");
                oSql.AppendLine($"    WHERE FTPdtCod = N'{poPdt.ptPdtCod}';");

                oSql.AppendLine("    COMMIT TRAN");
                oSql.AppendLine("    SELECT 1");
                oSql.AppendLine("END TRY");
                oSql.AppendLine("BEGIN CATCH");
                oSql.AppendLine("    ROLLBACK TRAN");
                oSql.AppendLine("    SELECT 0");
                oSql.AppendLine("END CATCH");

                string ssd = oSql.ToString();

                if (oDB.C_GEToDataQuery<int>(oSql.ToString()) == 0)
                {
                    Console.WriteLine($"Transaction Error Update Product !!!");
                    return false;
                }
                return true;
            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                oDB = null;
                oSql = null;
            }
            return false;
        }

        public static bool C_ADDbAddSaleTransaction(cmlReqSale poSal)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine("    INSERT INTO TWsTSal (FTSalCod,FTSalPdtCod,FNSalQty,FCSalPri,FCSalAmt,FTSalCstCod,FDSalDate,FDSalSMPT)");
                oSql.AppendLine($"    VALUES (N'{poSal.ptSalCod}', N'{poSal.ptSalPdtCod}', {poSal.pnSalQty},{poSal.pcSalPri}, {poSal.pcSalAmt}, N'{poSal.ptSalCstCod}',N'{poSal.pdSalDate}', GETDATE());");

                oSql.AppendLine("    COMMIT TRAN");
                oSql.AppendLine("    SELECT 1");
                oSql.AppendLine("END TRY");
                oSql.AppendLine("BEGIN CATCH");
                oSql.AppendLine("    ROLLBACK TRAN");
                oSql.AppendLine("    SELECT 0");
                oSql.AppendLine("END CATCH");
                string rsql = oSql.ToString();
                if (oDB.C_GEToDataQuery<int>(oSql.ToString()) == 0)
                {
                    Console.WriteLine($"Transaction Error Add Sale !!!");
                    return false;
                }
                return true;
            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                oDB = null;
                oSql = null;
            }
            return false;
        }

        public static bool C_UPDbUpdSaleTransaction(cmlReqSale poSal)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine($"    Update TWsTSal WITH (ROWLOCK) set FTSalCod = N'{poSal.ptSalCod}', FTSalPdtCod = N'{poSal.ptSalPdtCod}',FNSalQty = {poSal.pnSalQty},FCSalPri = {poSal.pcSalPri},FCSalAmt = {poSal.pcSalAmt},FTSalCstCod = N'{poSal.ptSalCstCod}',FDSalDate = N'{poSal.pdSalDate}'");
                oSql.AppendLine($"    where  FNSalID = {poSal.pnSalID}");

                oSql.AppendLine("    COMMIT TRAN");
                oSql.AppendLine("    SELECT 1");
                oSql.AppendLine("END TRY");
                oSql.AppendLine("BEGIN CATCH");
                oSql.AppendLine("    ROLLBACK TRAN");
                oSql.AppendLine("    SELECT 0");
                oSql.AppendLine("END CATCH");
                string rsql = oSql.ToString();
                if (oDB.C_GEToDataQuery<int>(oSql.ToString()) == 0)
                {
                    Console.WriteLine($"Transaction Error Add Sale !!!");
                    return false;
                }
                return true;
            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                oDB = null;
                oSql = null;
            }
            return false;
        }


        public static bool C_DELbDelPdtTransaction(int pnPdtCode)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine($"    DELETE FROM TWsTSal");
                oSql.AppendLine($"    WHERE FNSalID = {pnPdtCode}");

                oSql.AppendLine("    COMMIT TRAN");
                oSql.AppendLine("    SELECT 1");
                oSql.AppendLine("END TRY");
                oSql.AppendLine("BEGIN CATCH");
                oSql.AppendLine("    ROLLBACK TRAN");
                oSql.AppendLine("    SELECT 0");
                oSql.AppendLine("END CATCH");
                if (oDB.C_GEToDataQuery<int>(oSql.ToString()) == 0)
                {
                    Console.WriteLine($"Transaction Error Delete !!!");
                    return false;
                }
                return true;
            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.Message);
            }
            finally
            {
                oDB = null;
                oSql = null;
            }
            return false;
        }


    }
}
