using C1.Win.C1FlexGrid;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using wModels.Class;
using static C1.Util.Win.Win32;
using static WindowsFormsApp1.Service.cPstService;

namespace WindowsFormsApp1
{
    public partial class wWSmain : Form
    {
        string tW_ClasName = "wWSmain";
        int nW_Number = 0;  // global parameter 
        int[] aW_Number = { 1, 6 };  // array

        List<cmlReqSale> aoW_Res = new List<cmlReqSale>();  // array object global

        public wWSmain()
        {
            try
            {
                InitializeComponent();
                W_SETxDesign();
                W_SETxText();
                W_GetxPdtData();
                W_GetxSalData();
                W_GetxCstData();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, "{methodName} constucter:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }


        private void W_SETxDesign()
        {
        }

        private void W_SETxText()
        {
            try
            {
                olaId.Text = string.Empty;
                olaCod.Text = "รหัสขาย";
                olaPdtCod.Text = "รหัสสินค้า";
                olaQty.Text = "จำนวน";
                olaPri.Text = "ราคา";
                olaPriAmt.Text = "ราคารวม";
                olaCstCod.Text = "รหัสลูกค้า";
                olaSalDate.Text = "วันที่ขาย";
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private cmlReqSale W_oCheckSalData()
        {
            cmlReqSale mSale = new cmlReqSale();
            try
            {
                if (!string.IsNullOrEmpty(olaId.Text))
                    mSale.pnSalID = int.Parse(olaId.Text);
                else
                {
                    // ไม่ทำอะไร
                }
                if (string.IsNullOrEmpty(otbSalCod.Text))
                    MessageBox.Show("ระบุรหัสการขาย");
                else
                    mSale.ptSalCod = otbSalCod.Text;
                if (string.IsNullOrEmpty(otbSalPdtCod.Text))
                    MessageBox.Show("ระบุรหัสิสนค้า");
                else
                    mSale.ptSalPdtCod = otbSalPdtCod.Text;
                if (string.IsNullOrEmpty(otbSalCstCod.Text))
                    MessageBox.Show("ระบุรหัสลูกค้า");
                else
                    mSale.ptSalCstCod = otbSalCstCod.Text;
                if (string.IsNullOrEmpty(otbSalPri.Text))
                    MessageBox.Show("ระบุราคา");
                else
                    mSale.pcSalPri = decimal.Parse(otbSalPri.Text);
                if (string.IsNullOrEmpty(otbSalQty.Text))
                    MessageBox.Show("ระบุจำนวน");
                else
                    mSale.pnSalQty = int.Parse(otbSalQty.Text);
                if (string.IsNullOrEmpty(otbSalAmt.Text))
                    MessageBox.Show("ราคารวม");
                else
                    mSale.pcSalAmt = decimal.Parse(otbSalAmt.Text);
                if (string.IsNullOrEmpty(otbSalDate.Value.ToString()))
                    MessageBox.Show("ระบุวันที่ขาย");
                else
                    mSale.pdSalDate = DateTime.Parse(otbSalDate.Value.ToString());

                mSale.pdSalSMPT = DateTime.Now;

            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
            return mSale;
        }

        private void W_GetxPdtData()
        {
            try
            {
                odgPdt.Row.ToString();

                List<cmlResPdt> oaPdt = new cPstService().C_GETaoProduct();

                //cPstService cPdtService = new cPstService();
                //cPdtService.C_GETaoProduct();

                odgPdt.DataSource = oaPdt;

                string[] tColsName = { "ลำดับ", "รหัสสินค้า", "ชื่อสินค้า", "รายละเอียด", "จำนวน", "ราคา",  "ประเภท", "วันที่สร้างรายการ", "สถานะ" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    odgPdt.Cols[(nRow + 1)].Caption = tColsName[nRow];
                }


                odgPdt.Refresh();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }

        }


        private void W_GetxSalData()
        {
            try
            {
                List<cmlResSale> oaSale = new cSaleService().C_GETaoSale();
                //odgSal.DataSource = oaSale;

                //odgSal.Rows.Count = odgSal.Rows.Fixed;

                odgSal.Cols.Count = 11;
                odgSal.Cols[1].Name = "rnSalID";
                odgSal.Cols[2].Name = "rtSalCod";
                odgSal.Cols[3].Name = "rtSalPdtCod";
                odgSal.Cols[4].Name = "rnSalQty";
                odgSal.Cols[5].Name = "rcSalPri";
                odgSal.Cols[6].Name = "rcSalAmt";
                odgSal.Cols[7].Name = "rtSalCstCod";
                odgSal.Cols[8].Name = "rdSalDate";
                odgSal.Cols[9].Name = "rdSalSMPT";
                odgSal.Cols[10].Name = "rdSalDel";
                odgSal.Cols["rdSalDel"].DataType = typeof(Image);
                odgSal.Cols["rdSalDel"].ImageAlign = ImageAlignEnum.CenterCenter;
                //odgSal.Cols["rdSalDel"].Width = 200;
                int nIndex = 1;
                foreach (cmlResSale oSal in oaSale)
                {
                    odgSal.Rows.Add();

                    CellStyle oCellStyle;
                    oCellStyle = odgSal.Styles.Add("Receive");
                    oCellStyle.BackColor = Color.Yellow;
                    oCellStyle.ForeColor = Color.Blue;

                    odgSal.BackColor = Color.PaleGreen;
                    // odgSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                    //odgSal.SetCellStyle(nIndex, odgSal.Cols["rnSalID"].Index, oCellStyle);
                    //odgSal.SetCellStyle(nIndex, odgSal.Cols[1].Index, oCellStyle);
                    //odgSal.SetCellStyle(nIndex, odgSal.Cols[3].Index, oCellStyle);
                    //odgSal.SetCellStyle(nIndex, odgSal.Cols[5].Index, oCellStyle);
                    if (nIndex % 2 == 0)
                    {
                        odgSal.SetCellStyle(nIndex, 1, oCellStyle);
                    }

                    odgSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                    odgSal.SetData(nIndex, "rtSalCod", oSal.rtSalCod);
                    odgSal.SetData(nIndex, "rtSalPdtCod", oSal.rtSalPdtCod);
                    odgSal.SetData(nIndex, "rnSalQty", oSal.rnSalQty);
                    odgSal.SetData(nIndex, "rcSalPri", oSal.rcSalPri);
                    odgSal.SetData(nIndex, "rcSalAmt", oSal.rcSalAmt);

                    odgSal.SetData(nIndex, "rtSalCstCod", oSal.rtSalCstCod);
                    odgSal.SetData(nIndex, "rdSalDate", oSal.rdSalDate);
                    odgSal.SetData(nIndex, "rdSalSMPT", oSal.rdSalSMPT);
                    odgSal.SetData(nIndex, "rdSalDel", "ลบ");
                    /* Image img = new Bitmap("D:\\Bank\\workshop\\showtogit\\AddWSbyBank\\WinWSc1\\Images\\bin.png");
                     Bitmap resizedImage = new Bitmap(img, new Size(15, 15));
                     odgSal.SetCellImage(nIndex, "rdSalDel", resizedImage);*/


                    // pic
                    nIndex++;
                }


                string[] tColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ", "ลบข้อมูล" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    odgSal.Cols[(nRow + 1)].Caption = tColsName[nRow];
                }


                odgSal.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    odgSal.Cols[nRow].AllowMerging = true;
                }


                odgSal.Refresh();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }

        }

        private void W_GetxCstData()
        {
            try
            {
                odgSal.Row.ToString();

                List<cmlResCst> W_oaCst = new cCstService().C_GETaoCustomer();

                //cPstService cPdtService = new cPstService();
                //cPdtService.C_GETaoProduct();

                odgCst.DataSource = W_oaCst;
                string[] tColsName = { "ลำดับ", "รหัสลูกค้า", "ชื่อลูกค้า", "Email", "เบอร์โทร", "ที่อยู่", "วันที่สร้างรายการ" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    odgCst.Cols[(nRow + 1)].Caption = tColsName[nRow];
                }
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }

        }

        private void ocmAddSal_Click(object sender, EventArgs e)
        {
            try
            {
                cmlReqSale mSale = new cmlReqSale();
                mSale = W_oCheckSalData();

                bool res = new cSaleService().C_POSTbSaveSale(mSale);
                W_GetxPdtData();
                W_GetxSalData();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }

        }

        private void otbSalPri_TextChanged(object sender, EventArgs e)
        {
            try
            {
                W_SetxAmt();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void otbSalQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                W_SetxAmt();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }


        private void W_SetxAmt()
        {
            try
            {
                if (!string.IsNullOrEmpty(otbSalPri.Text) && !string.IsNullOrEmpty(otbSalQty.Text))
                {
                    decimal cPri = decimal.Parse(otbSalPri.Text);
                    int nQty = int.Parse(otbSalQty.Text);
                    otbSalAmt.Text = (cPri * nQty).ToString();
                }

            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }


        private void ocmEdtSal_Click(object sender, EventArgs e)
        {
            try
            {
                cmlReqSale mSale = new cmlReqSale();
                mSale = W_oCheckSalData();
                bool W_res = new cSaleService().C_POSTbUpdateSale(mSale);
                W_GetxPdtData();
                W_GetxSalData();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally { }



        }




        private void odgSal_Click(object sender, EventArgs e)
        {
            /*int nCol = odgSal.Col;
            int nRow = odgSal.Row;
            int Index = Convert.ToInt32(odgSal.GetData(odgSal.RowSel, odgSal.Cols["rnSalID"].Index));*/

            try
            {
                if (odgSal.Col == 10)
                {
                    int pnSalID = int.Parse(odgSal.GetData(odgSal.Row, odgSal.Cols["rnSalID"].Index).ToString());
                    var res = new cSaleService().C_POSTbDelSale(pnSalID.ToString());
                }
                else
                {
                    int nIdx = odgSal.Row;
                    olaId.Text = odgSal.GetData(nIdx, odgSal.Cols["rnSalID"].Index).ToString();
                    otbSalCod.Text = odgSal.GetData(nIdx, odgSal.Cols["rtSalCod"].Index).ToString();
                    otbSalPdtCod.Text = odgSal.GetData(nIdx, odgSal.Cols["rtSalPdtCod"].Index).ToString();
                    otbSalQty.Text = odgSal.GetData(nIdx, odgSal.Cols["rnSalQty"].Index).ToString();
                    otbSalPri.Text = odgSal.GetData(nIdx, odgSal.Cols["rcSalPri"].Index).ToString();
                    otbSalAmt.Text = odgSal.GetData(nIdx, odgSal.Cols["rcSalAmt"].Index).ToString();
                    otbSalCstCod.Text = odgSal.GetData(nIdx, odgSal.Cols["rtSalCstCod"].Index).ToString();
                    otbSalDate.Text = odgSal.GetData(nIdx, odgSal.Cols["rdSalDate"].Index).ToString();
                }

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }

        }

        private void ocmSalDet_Click(object sender, EventArgs e)
        {
            try
            {
                Wform2 wSalDetail = new Wform2();
                wSalDetail.Show();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void C_CLNxTxt()
        {
            try
            {
                otbSalCod.Text = "";
                otbSalPdtCod.Text = "";
                otbSalQty.Text = "";
                otbSalPri.Text = "";
                otbSalAmt.Text = "";
                otbSalCstCod.Text = "";
                otbSalDate.Value = DateTime.Now;
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void comClrSal_Click(object sender, EventArgs e)
        {
            try
            {
                C_CLNxTxt();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void odgPdt_Click(object sender, EventArgs e)
        {
            try
            {
                int nIdx = odgPdt.Row;
                otbSalPdtCod.Text = odgPdt.GetData(nIdx, odgPdt.Cols["rtPdtCod"].Index).ToString();
                otbSalQty.Text = odgPdt.GetData(nIdx, odgPdt.Cols["rnPdtQty"].Index).ToString();
                otbSalPri.Text = odgPdt.GetData(nIdx, odgPdt.Cols["rcPdtPri"].Index).ToString();

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }

        }

        private void odgCst_Click(object sender, EventArgs e)
        {
            try
            {
                int nIdx = odgCst.Row;
                otbSalCstCod.Text = odgCst.GetData(nIdx, odgCst.Cols["rtCstCod"].Index).ToString();

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }
        }
    }
}
