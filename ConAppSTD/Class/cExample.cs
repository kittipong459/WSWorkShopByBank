using System;
using System.Text;
using BuildingBlocks.Class;
using wModels;

namespace ConAppSTD.Class
{
    public class cExample
    {
        public static bool C_PRCxAddPdtTransaction(cmlResPdt poPdt)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine("    INSERT INTO TWsMPdt (FTPdtCod,FTPdtName, FTPdtDes, FCPdtPri, FNPdtQty, FDPdtSMPT,FNPdtTyp)");
                oSql.AppendLine($"    VALUES (N'{poPdt.rtPdtCod}', N'{poPdt.rtPdtName}',  N'{poPdt.rtPdtDes}',{poPdt.rcPdtPri}, {poPdt.rnPdtQty}, GETDATE(), {poPdt.rnPdtTyp});");

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

        public static bool C_PRCxUpdPdtTransaction(cmlResPdt poPdt)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine($"    UPDATE TWsMPdt SET FTPdtName = N'{poPdt.rtPdtName}', FTPdtDes = N'{poPdt.rtPdtDes}', FCPdtPri = {poPdt.rcPdtPri}, FNPdtQty = {poPdt.rnPdtQty}, FDPdtSMPT = GETDATE(), FNPdtTyp = {poPdt.rnPdtTyp}");
                oSql.AppendLine($"    WHERE FTPdtCod = N'{poPdt.rtPdtCod}';");

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

        public static bool C_PRCxAddSaleTransaction(cmlSale paoSal)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine("    INSERT INTO TWsTSal (FTSalCod,FTSalPdtCod,FNSalQty,FCSalPri,FCSalAmt,FTSalCstCod,FDSalDate,FDSalSMPT)");
                oSql.AppendLine($"    VALUES (N'{paoSal.rtSalCod}', N'{paoSal.rtSalPdtCod}', {paoSal.rnSalQty},{paoSal.rcSalPri}, {paoSal.rcSalAmt}, N'{paoSal.rtSalCstCod}',N'{paoSal.rdSalDate}', GETDATE());");

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

        public static bool C_PRCxUpdateSaleTransaction(cmlSale paoSal)
        {
            cDatabase oDB = new cDatabase();
            StringBuilder oSql = new StringBuilder();
            try
            {
                oSql.AppendLine("BEGIN TRY");
                oSql.AppendLine("    BEGIN TRAN");

                oSql.AppendLine($"    Update TWsTSal set FTSalPdtCod = N'{paoSal.rtSalPdtCod}',FNSalQty = {paoSal.rnSalQty},FCSalPri = {paoSal.rcSalPri},FCSalAmt = {paoSal.rcSalAmt},FTSalCstCod = N'{paoSal.rtSalCstCod}',FDSalDate = N'{paoSal.rdSalDate}'");
                oSql.AppendLine($"    where FTSalCod = N'{paoSal.rtSalCod}'");

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


    }
}
