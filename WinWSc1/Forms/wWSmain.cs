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
                W_SETxDesign();
                W_SETxText();
                W_GETxPdtData();
                //W_GETxGetPdtData();
                W_GETxSalData();
                // W_GETxGetSalData();
                W_GETxCstData();
                //W_GETxGetCstData();
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


        private void W_SETxDesign()  // W_SETxSetDesign
        {
            try
            {



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

        private void W_SETxText()  // W_SETxSetText
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


        private cmlReqSale W_CHKoCheckSalData()
        {
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

        private void W_SETxColSal(C1FlexGrid poGD)  // W_SETxSetColSal
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
                        poGD.Cols["otbColSalID"].Width = nWidth * 10 / 100;
                        poGD.Cols["otbColSalCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColSalPdtCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColSalQty"].Width = nWidth * 10 / 100;
                        poGD.Cols["otbColSalPri"].Width = nWidth * 10 / 100;
                        poGD.Cols["otbColSalAmt"].Width = nWidth * 10 / 100;
                        poGD.Cols["otbColSalCstCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColSalDate"].Width = nWidth * 10 / 100;
                        poGD.Cols["otbColSalSMPT"].Width = nWidth * 10 / 100;

                        //กำหนด Caption Title หัว Column
                        poGD.Cols["otbColSalID"].Caption = "ลำดับ";
                        poGD.Cols["otbColSalCod"].Caption = "รหัสการขาย";
                        poGD.Cols["otbColSalPdtCod"].Caption = "รหัสสินค้า";
                        poGD.Cols["otbColSalQty"].Caption = "จำนวน";
                        poGD.Cols["otbColSalPri"].Caption = "ราคา";
                        poGD.Cols["otbColSalAmt"].Caption = "ราคารวม";
                        poGD.Cols["otbColSalCstCod"].Caption = "รหัสลูกค้า";
                        poGD.Cols["otbColSalDate"].Caption = "วันที่ขาย";
                        poGD.Cols["otbColSalSMPT"].Caption = "วันที่สร้างรายการ";
                        poGD.Cols["ocmColSalDel"].Caption = "ลบข้อมูล";

                        //กำหนดตำแหน่งข้อความ Title หัว Column
                        poGD.Cols["otbColSalID"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalPdtCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalQty"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalPri"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalAmt"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCstCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalDate"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalSMPT"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["ocmColSalDel"].TextAlignFixed = TextAlignEnum.CenterCenter;

                        //กำหนดตำแหน่งข้อความในส่วนของข้อมูล
                        poGD.Cols["otbColSalID"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalPdtCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalQty"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalPri"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalAmt"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalCstCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalDate"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalSMPT"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["ocmColSalDel"].TextAlign = TextAlignEnum.CenterCenter;
                        // otbColSalID 

                        //กำหนด Type Column ปุ่มเป็น Image
                        poGD.Cols["ocmColSalDel"].DataType = typeof(Image);  // มีผลต่อการกำหนดตำแหน่ง R C L

                        //กำหนด Column แสดงจำนวนเต็ม
                        poGD.Cols["otbColSalQty"].Format = "###,###,##0";
                        //กำหนด Column แสดงจำนวนเต็มแบบมีทศนิยม
                        poGD.Cols["otbColSalPri"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["otbColSalAmt"].Format = "###,###,##0." + new string('0', 2);

                        // merge
                        poGD.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                        for (int nRow = 0; nRow < poGD.Cols.Count - 1; nRow++)
                        {
                            ogdSal.Cols[nRow].AllowMerging = true;
                        }

                        #endregion ebd Set Col ogdSal

                        break;


                    default:
                        // ไม่ทำอะไร
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

        private void W_GETxSalData()  // W_GETxGetSalData
        {
            List<cmlResSale> aoSale;
            try
            {
                aoSale = new cSaleService().C_GETaSale();
                //ogdSal.Clear();
                //  ogdSal.DataSource = null;

                ogdSal.Rows.Count = ogdSal.Rows.Fixed;
                if (aoSale != null && aoSale.Count > 0)
                {
                    foreach (cmlResSale oSal in aoSale)
                    {
                        ogdSal.Rows.Add();
                        //int nIndex = ogdSal.Rows.Count - ogdSal.Rows.Fixed;
                        CellStyle oCellStyle;
                        oCellStyle = ogdSal.Styles.Add("Receive");
                        oCellStyle.BackColor = Color.Yellow;
                        oCellStyle.ForeColor = Color.Blue;

                        ogdSal.BackColor = Color.PaleGreen;
                        if (ogdSal.Rows.Count - ogdSal.Rows.Fixed % 2 == 0)
                        {
                            ogdSal.SetCellStyle(ogdSal.Rows.Count - ogdSal.Rows.Fixed, 1, oCellStyle);
                        }

                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalID"].Index, oSal.rnSalID);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalCod"].Index, oSal.rtSalCod);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalPdtCod"].Index, string.IsNullOrEmpty(oSal.rtSalPdtCod) ? "" : oSal.rtSalPdtCod);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalQty"].Index, oSal.rnSalQty);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalPri"].Index, oSal.rcSalPri);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalAmt"].Index, oSal.rcSalAmt);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalCstCod"].Index, oSal.rtSalCstCod);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalDate"].Index, oSal.rdSalDate);
                        ogdSal.SetData(ogdSal.Rows.Count - ogdSal.Rows.Fixed, ogdSal.Cols["otbColSalSMPT"].Index, oSal.rdSalSMPT);
                        //ogdSal.SetData(nIndex, "rdSalDel", "ลบ");
                        /*Image oImg = new Bitmap("D:\\Bank\\workshop\\showtogit\\AddWSbyBank\\WinWSc1\\Images\\bin.png");
                        // Image = object = o
                        Bitmap oImgresized = new Bitmap(oImg, new Size(15, 15));
                        ogdSal.SetCellImage(nIndex, "rdSalDel", oImgresized);*/


                        ogdSal.SetCellImage(ogdSal.Rows.Count - ogdSal.Rows.Fixed, "ocmColSalDel", global::WindowsFormsApp1.Properties.Resources.bin_resized_32x32);
                        //Image oImg = new Bitmap(global::WindowsFormsApp1.Properties.Resources.bin);
                        //Bitmap oImgResized = new Bitmap(oImg, new Size(32, 32));
                        //ogdSal.SetCellImage(ogdSal.Rows.Count - ogdSal.Rows.Fixed, "ocmColSalDel", oImgResized);

                    }


                    //string[] tColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ", "ลบข้อมูล" };
                    //for (int nRow = 0; nRow < tColsName.Length; nRow++)
                    //{
                    //    ogdSal.Cols[(nRow + 1)].Caption = tColsName[nRow];
                    //}


                    //ogdSal.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                    //for (int nRow = 0; nRow < tColsName.Length; nRow++)
                    //{
                    //    ogdSal.Cols[nRow].AllowMerging = true;
                    //}

                }
                else
                {
                    // ไม่ต้องทำอะไร
                }

                //ogdSal.Refresh();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {
                aoSale = null;
            }

        }


        private void W_GETxPdtData() // W_GETxGetPdtData
        {
            try
            {
                List<cmlResPdt> aoPdt = new cPdtService().C_GETaGetProduct(); // return object

                ogdPdt.DataSource = null;

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

        private void W_GETxCstData() // W_GETxGetCstData
        {
            try
            {


                List<cmlResCst> oaCst = new cCstService().C_GETaGetCustomer();
                // tW_name  == global from
                // tC_name == gloabal class
                ogdCst.DataSource = null;

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
                cmlReqSale oSale = new cmlReqSale();
                oSale = W_CHKoCheckSalData();
                if (oSale != null)
                {
                    bool res = new cSaleService().C_POSbSaveSale(oSale);
                }

                W_RESxResload();
                W_CLNxTxt();
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
                W_SETxAmt();
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
                W_SETxAmt();
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


        private void W_SETxAmt()
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

                mSale = W_CHKoCheckSalData();
                bool W_res = new cSaleService().C_POSbUpdateSale(mSale);
                //bRes
                W_RESxResload();
                W_CLNxTxt();
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
            try
            {
                if (ogdSal.ColSel == ogdSal.Cols["ocmColSalDel"].Index)
                {
                    int nSalID = int.Parse(ogdSal.GetData(ogdSal.Row, ogdSal.Cols["otbColSalID"].Index).ToString());
                    bool bRes = new cSaleService().C_POSbDelSale(nSalID.ToString());
                    W_RESxResload();

                }
                else
                {
                    int nIdx = ogdSal.Row;
                    olaId.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalID"].Index).ToString();
                    otbSalCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalCod"].Index).ToString();
                    otbSalPdtCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalPdtCod"].Index).ToString();
                    otbSalQty.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalQty"].Index).ToString();
                    otbSalPri.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalPri"].Index).ToString();
                    otbSalAmt.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalAmt"].Index).ToString();
                    otbSalCstCod.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalCstCod"].Index).ToString();
                    otbSalDate.Text = ogdSal.GetData(nIdx, ogdSal.Cols["otbColSalDate"].Index).ToString();
                    W_RESxResload();
                }

            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                W_CLNxTxt();
            }
            finally
            {

            }

        }

        private void ocmSalDet_Click(object sender, EventArgs e)
        {
            Wform2 oSalDetail;
            try
            {
                oSalDetail = new Wform2();
                oSalDetail.Show();
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {
                oSalDetail = null;
            }
        }

        private void W_CLNxTxt()
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
                W_CLNxTxt();
                W_RESxResload();
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
                W_CLNxTxt();
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
                W_CLNxTxt();
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);

            }
            finally
            {

            }
        }

        private void W_RESxResload()
        {
            try
            {
                W_GETxPdtData();
                W_GETxSalData();
                W_GETxCstData();
            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);

            }
            finally
            {

            }

        }

        private void wWSmain_Shown(object sender, EventArgs e)
        {
            try
            {

                W_SETxColSal(ogdSal);
            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);

            }
            finally
            {

            }
        }
    }
}
