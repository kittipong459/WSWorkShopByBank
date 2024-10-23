using C1.Win.C1FlexGrid;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using wModels.Class;

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
                W_SETxSetDesign();
                W_SETxSetText();
                W_GETxGetPdtData();
                //W_GETxGetPdtData();
                W_GETxGetSalData();
                // W_GETxGetSalData();
                W_GETxGetCstData();
                //W_GETxGetCstData();
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


        private void W_SETxSetDesign()
        {
            try
            {

                W_SETxSetColSal(ogdSal);

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

        private void W_SETxSetText()
        {
            try
            {
                olaId.Text = "";
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

        //private cmlReqSale W_CHKoCheckSalData()
        private cmlReqSale W_oCheckSalData()
        {
            //cmlReqSale oSale = new cmlReqSale();
            cmlReqSale oSale = new cmlReqSale();
            try
            {
                if (!string.IsNullOrEmpty(olaId.Text))
                {
                    oSale.pnSalID = int.Parse(olaId.Text);
                }
                else
                {
                    // ไม่ทำอะไร
                }
                if (string.IsNullOrEmpty(otbSalCod.Text))
                {
                    MessageBox.Show("ระบุรหัสการขาย");
                }
                else
                {
                    oSale.ptSalCod = otbSalCod.Text;
                }

                if (string.IsNullOrEmpty(otbSalPdtCod.Text))
                {
                    MessageBox.Show("ระบุรหัสิสนค้า");
                }

                else
                {
                    oSale.ptSalPdtCod = otbSalPdtCod.Text;
                }

                if (string.IsNullOrEmpty(otbSalCstCod.Text))
                {
                    MessageBox.Show("ระบุรหัสลูกค้า");
                }

                else
                {
                    oSale.ptSalCstCod = otbSalCstCod.Text;
                }

                if (string.IsNullOrEmpty(otbSalPri.Text))
                {
                    MessageBox.Show("ระบุราคา");
                }

                else
                {
                    oSale.pcSalPri = decimal.Parse(otbSalPri.Text);
                }

                if (string.IsNullOrEmpty(otbSalQty.Text))
                {
                    MessageBox.Show("ระบุจำนวน");
                }

                else
                {
                    oSale.pnSalQty = int.Parse(otbSalQty.Text);
                }

                if (string.IsNullOrEmpty(otbSalAmt.Text))
                {
                    MessageBox.Show("ราคารวม");
                }

                else
                {
                    oSale.pcSalAmt = decimal.Parse(otbSalAmt.Text);
                }

                if (string.IsNullOrEmpty(otbSalDate.Value.ToString()))
                {
                    MessageBox.Show("ระบุวันที่ขาย");
                }

                else
                {
                    oSale.pdSalDate = DateTime.Parse(otbSalDate.Value.ToString());
                }

                oSale.pdSalSMPT = DateTime.Now;

            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
            return oSale;
        }

        private void W_SETxSetColSal(C1FlexGrid poGD)
        {
            int nWidth = 0;
            string tNameGrid = poGD.Name;
            try
            {
                switch (poGD.Name)
                {
                    case "ogdSal":
                        nWidth = poGD.Width;
                        poGD.ExtendLastCol = true; //ให้ Column สุดท้ายขยายตามความกว้างที่เหลือจนเต็ม Grid
                        #region Set Col ogdSal
                        //กำหนดความกว้างของ Column (Set เป็น % รองรับขนาดหน้าจอที่แตกต่างกัน)
                        poGD.Cols["rnSalID"].Width = nWidth * 10 / 100;
                        poGD.Cols["rtSalCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["rtSalPdtCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["rnSalQty"].Width = nWidth * 10 / 100;
                        poGD.Cols["rcSalPri"].Width = nWidth * 10 / 100;
                        poGD.Cols["rcSalAmt"].Width = nWidth * 10 / 100;
                        poGD.Cols["rtSalCstCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["rdSalDate"].Width = nWidth * 10 / 100;
                        poGD.Cols["rdSalSMPT"].Width = nWidth * 10 / 100;

                        //กำหนด Caption Title หัว Column
                        poGD.Cols["rnSalID"].Caption = "ลำดับ";
                        poGD.Cols["rtSalCod"].Caption = "รหัสการขาย";
                        poGD.Cols["rtSalPdtCod"].Caption = "รหัสสินค้า";
                        poGD.Cols["rnSalQty"].Caption = "จำนวน";
                        poGD.Cols["rcSalPri"].Caption = "ราคา";
                        poGD.Cols["rcSalAmt"].Caption = "ราคารวม";
                        poGD.Cols["rtSalCstCod"].Caption = "รหัสลูกค้า";
                        poGD.Cols["rdSalDate"].Caption = "วันที่ขาย";
                        poGD.Cols["rdSalSMPT"].Caption = "วันที่สร้างรายการ";
                        poGD.Cols["rdSalDel"].Caption = "ลบข้อมูล";

                        //กำหนดตำแหน่งข้อความ Title หัว Column
                        poGD.Cols["rnSalID"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalPdtCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rnSalQty"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rcSalPri"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rcSalAmt"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCstCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalDate"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalSMPT"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalDel"].TextAlignFixed = TextAlignEnum.CenterCenter;

                        //กำหนดตำแหน่งข้อความในส่วนของข้อมูล
                        poGD.Cols["rnSalID"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtSalPdtCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rnSalQty"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rcSalPri"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rcSalAmt"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rtSalCstCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rdSalDate"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalSMPT"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalDel"].TextAlign = TextAlignEnum.CenterCenter;

                        //กำหนด Type Column ปุ่มเป็น Image
                        poGD.Cols["rdSalDel"].DataType = typeof(Image);  // มีผลต่อการกำหนดตำแหน่ง R C L

                        //กำหนด Column แสดงจำนวนเต็ม
                        poGD.Cols["rnSalQty"].Format = "###,###,##0";
                        //กำหนด Column แสดงจำนวนเต็มแบบมีทศนิยม
                        poGD.Cols["rcSalPri"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["rcSalAmt"].Format = "###,###,##0." + new string('0', 2);

                        #endregion ebd Set Col ogdSal

                        break;


                    default:

                        break;
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

        private void W_GETxGetSalData()
        {
            try
            {
                List<cmlResSale> oaSale = new cSaleService().C_GETaGetSale();

                ogdSal.Rows.Count = ogdSal.Rows.Fixed;
                foreach (cmlResSale oSal in oaSale)
                {
                    ogdSal.Rows.Add();
                    int nIndex = ogdSal.Rows.Count - ogdSal.Rows.Fixed;
                    CellStyle oCellStyle;
                    oCellStyle = ogdSal.Styles.Add("Receive");
                    oCellStyle.BackColor = Color.Yellow;
                    oCellStyle.ForeColor = Color.Blue;

                    ogdSal.BackColor = Color.PaleGreen;
                    if (nIndex % 2 == 0)
                    {
                        ogdSal.SetCellStyle(nIndex, 1, oCellStyle);
                    }

                    ogdSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                    ogdSal.SetData(nIndex, "rtSalCod", oSal.rtSalCod);
                    ogdSal.SetData(nIndex, "rtSalPdtCod", oSal.rtSalPdtCod);
                    ogdSal.SetData(nIndex, "rnSalQty", oSal.rnSalQty);
                    ogdSal.SetData(nIndex, "rcSalPri", oSal.rcSalPri);
                    ogdSal.SetData(nIndex, "rcSalAmt", oSal.rcSalAmt);
                    ogdSal.SetData(nIndex, "rtSalCstCod", oSal.rtSalCstCod);
                    ogdSal.SetData(nIndex, "rdSalDate", oSal.rdSalDate);
                    ogdSal.SetData(nIndex, "rdSalSMPT", oSal.rdSalSMPT);
                    //ogdSal.SetData(nIndex, "rdSalDel", "ลบ");
                    /*Image oImg = new Bitmap("D:\\Bank\\workshop\\showtogit\\AddWSbyBank\\WinWSc1\\Images\\bin.png");
                    // Image = object = o
                    Bitmap oImgresized = new Bitmap(oImg, new Size(15, 15));
                    ogdSal.SetCellImage(nIndex, "rdSalDel", oImgresized);*/


                    //ogdSal.SetCellImage(ogdSal.Rows.Count - ogdSal.Rows.Fixed, "rdSalDel", global::WindowsFormsApp1.Properties.Resources.bin);
                    Image oImg = new Bitmap(global::WindowsFormsApp1.Properties.Resources.bin);
                    Bitmap oImgResized = new Bitmap(oImg, new Size(15, 15));
                    ogdSal.SetCellImage(nIndex, "rdSalDel", oImgResized);


                    // pic
                    nIndex++;
                }


                string[] tColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ", "ลบข้อมูล" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    ogdSal.Cols[(nRow + 1)].Caption = tColsName[nRow];
                }


                ogdSal.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    ogdSal.Cols[nRow].AllowMerging = true;
                }


                ogdSal.Refresh();
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


        private void W_GETxGetPdtData()
        {
            try
            {
                ogdPdt.Row.ToString();

                List<cmlResPdt> aoPdt = new cPdtService().C_GETaGetProduct(); // return object

                //cPstService cPdtService = new cPstService();
                //cPdtService.C_GETaoProduct();

                ogdPdt.DataSource = aoPdt;

                string[] tColsName = { "ลำดับ", "รหัสสินค้า", "ชื่อสินค้า", "รายละเอียด", "จำนวน", "ราคา", "ประเภท", "วันที่สร้างรายการ", "สถานะ" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    ogdPdt.Cols[(nRow + 1)].Caption = tColsName[nRow];
                }


                ogdPdt.Refresh();
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

        private void W_GETxGetCstData()
        {
            try
            {
                ogdSal.Row.ToString();

                List<cmlResCst> oaCst = new cCstService().C_GETaGetCustomer();
                // tW_name  == global from
                // tC_name == gloabal class

                ogdCst.DataSource = oaCst;
                string[] tColsName = { "ลำดับ", "รหัสลูกค้า", "ชื่อลูกค้า", "Email", "เบอร์โทร", "ที่อยู่", "วันที่สร้างรายการ" };
                for (int nRow = 0; nRow < tColsName.Length; nRow++)
                {
                    ogdCst.Cols[(nRow + 1)].Caption = tColsName[nRow];
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
                if (mSale != null)
                {
                    bool res = new cSaleService().C_POSbPosSaveSale(mSale);
                }

                W_GETxGetPdtData();
                W_GETxGetSalData();
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
                // W_SETxSetAmt();
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
                else
                {
                    otbSalAmt.Text = "0";
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
            cmlReqSale mSale;
            try
            {
                mSale = new cmlReqSale();

                mSale = W_oCheckSalData();
                bool W_res = new cSaleService().C_POSbPosUpdateSale(mSale);
                //bRes
                W_GETxGetPdtData();
                W_GETxGetSalData();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {
                mSale = null;
            }



        }




        private void odgSal_Click(object sender, EventArgs e)
        {
            /*int nCol = odgSal.Col;
            int nRow = odgSal.Row;
            int Index = Convert.ToInt32(odgSal.GetData(odgSal.RowSel, odgSal.Cols["rnSalID"].Index));*/

            try
            {
                if (ogdSal.ColSel == ogdSal.Cols["rdSalDel"].Index)
                {
                    int pnSalID = int.Parse(ogdSal.GetData(ogdSal.Row, ogdSal.Cols["rnSalID"].Index).ToString());
                    var res = new cSaleService().C_POSbPosDelSale(pnSalID.ToString());
                }
                else
                {
                    int nIdx = ogdSal.Row;
                    olaId.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rnSalID"].Index).ToString();
                    otbSalCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rtSalCod"].Index).ToString();
                    otbSalPdtCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rtSalPdtCod"].Index).ToString();
                    otbSalQty.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rnSalQty"].Index).ToString();
                    otbSalPri.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rcSalPri"].Index).ToString();
                    otbSalAmt.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rcSalAmt"].Index).ToString();
                    otbSalCstCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rtSalCstCod"].Index).ToString();
                    otbSalDate.Text = ogdSal.GetData(nIdx, ogdSal.Cols["rdSalDate"].Index).ToString();
                }

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }
            finally
            {

            }

        }

        private void ocmSalDet_Click(object sender, EventArgs e)
        {
            Wform2 wSalDetail;
            try
            {
                wSalDetail = new Wform2();
                wSalDetail.Show();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {
                wSalDetail = null;
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
                int nIdx = ogdPdt.Row;
                otbSalPdtCod.Text = ogdPdt.GetData(nIdx, ogdPdt.Cols["rtPdtCod"].Index).ToString();
                otbSalQty.Text = ogdPdt.GetData(nIdx, ogdPdt.Cols["rnPdtQty"].Index).ToString();
                otbSalPri.Text = ogdPdt.GetData(nIdx, ogdPdt.Cols["rcPdtPri"].Index).ToString();

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }
            finally
            {

            }

        }

        private void odgCst_Click(object sender, EventArgs e)
        {
            try
            {
                int nIdx = ogdCst.Row;
                otbSalCstCod.Text = ogdCst.GetData(nIdx, ogdCst.Cols["rtCstCod"].Index).ToString();

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                C_CLNxTxt();
            }
            finally
            {

            }
        }

        private void ocmReprt_Click(object sender, EventArgs e)
        {

        }
    }
}
