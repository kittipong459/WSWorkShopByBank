using C1.Win.C1FlexGrid;
using ServiceModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using wModels.Class;
using wModels.Response;
using static C1.Util.Win.Win32;

namespace WindowsFormsApp1
{
    public partial class Wform2 : Form
    {
        string tW_ClasName = "wSalDetail";
        public Wform2()
        {
            InitializeComponent();
            W_SETxDesign();
            W_SETxText();
            W_GETxGetSalDetail();
            W_GETxGetSalDetSummy();
        }


        private void W_SETxDesign()  // W_SETxSetDesign
        {
            try
            {

                W_SETxColSalDel(ogdSalDet);
                W_SETxColSalDel(ogdSumSal);

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

        private void W_SETxColSalDel(C1FlexGrid poGD)  // W_SETxSetColSal
        {
            int nWidth = 0;
            string tNameGrid = poGD.Name;
            try
            {
                switch (poGD.Name)
                {
                    case "ogdSalDet":
                        nWidth = poGD.Width;
                        poGD.ExtendLastCol = true; //ให้ Column สุดท้ายขยายตามความกว้างที่เหลือจนเต็ม Grid
                        #region Set Col ogdSal
                        //กำหนดความกว้างของ Column (Set เป็น % รองรับขนาดหน้าจอที่แตกต่างกัน)
                        poGD.Cols["otbColSalID"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalPdtCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColPdtName"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColPdtDes"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColPdtTyp"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalQty"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalPri"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalAmt"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalDate"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalCstCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColCstName"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColCstAdr"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColCstPho"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColCstEml"].Width = nWidth * 6 / 100;
                        poGD.Cols["otbColSalSMPT"].Width = nWidth * 6 / 100;

                        //กำหนด Caption Title หัว Column
                        poGD.Cols["otbColSalID"].Caption = "ลำดับ";
                        poGD.Cols["otbColSalCod"].Caption = "รหัสการขาย";
                        poGD.Cols["otbColSalPdtCod"].Caption = "รหัสสินค้า";
                        poGD.Cols["otbColPdtName"].Caption = "ชื่อสินค้า";
                        poGD.Cols["otbColPdtDes"].Caption = "รายละเอียด";
                        poGD.Cols["otbColPdtTyp"].Caption = "ประเภท";
                        poGD.Cols["otbColSalQty"].Caption = "จำนวน";
                        poGD.Cols["otbColSalPri"].Caption = "ราคา";
                        poGD.Cols["otbColSalAmt"].Caption = "ราคารวม";
                        poGD.Cols["otbColSalDate"].Caption = "วันที่ขาย";
                        poGD.Cols["otbColSalCstCod"].Caption = "รหัสลูกค้า";
                        poGD.Cols["otbColCstName"].Caption = "ชื่อลูกค้า";
                        poGD.Cols["otbColCstAdr"].Caption = "ที่อยู่";
                        poGD.Cols["otbColCstPho"].Caption = "เบอร์โทร";
                        poGD.Cols["otbColCstEml"].Caption = "อีเมล";
                        poGD.Cols["otbColSalSMPT"].Caption = "วันที่สร้าง";

                        //กำหนดตำแหน่งข้อความ Title หัว Column
                        poGD.Cols["otbColSalID"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalPdtCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPdtName"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPdtDes"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPdtTyp"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalQty"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalPri"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalAmt"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalDate"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCstCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColCstName"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColCstAdr"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColCstPho"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColCstEml"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalSMPT"].TextAlignFixed = TextAlignEnum.CenterCenter;

                        //กำหนดตำแหน่งข้อความในส่วนของข้อมูล
                        poGD.Cols["otbColSalID"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalPdtCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColPdtName"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColPdtDes"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColPdtTyp"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalQty"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalPri"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalAmt"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColSalDate"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColSalCstCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColCstName"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColCstAdr"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColCstPho"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColCstEml"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColSalSMPT"].TextAlign = TextAlignEnum.CenterCenter;


                        //กำหนด Column แสดงจำนวนเต็ม
                        poGD.Cols["otbColSalQty"].Format = "###,###,##0";
                        //กำหนด Column แสดงจำนวนเต็มแบบมีทศนิยม
                        poGD.Cols["otbColSalPri"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["otbColSalAmt"].Format = "###,###,##0." + new string('0', 2);

                        // merge
                        poGD.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                        for (int nRow = 0; nRow < poGD.Cols.Count - 1; nRow++)
                        {
                            ogdSalDet.Cols[nRow].AllowMerging = true;
                        }

                        #endregion ebd Set Col ogdSal

                        break;

                    case "ogdSumSal":

                        nWidth = poGD.Width;
                        poGD.ExtendLastCol = true; //ให้ Column สุดท้ายขยายตามความกว้างที่เหลือจนเต็ม Grid
                        #region Set Col ogdSumSal
                        //กำหนดความกว้างของ Column (Set เป็น % รองรับขนาดหน้าจอที่แตกต่างกัน)
                        poGD.Cols["otbColSalCod"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColQtyMax"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColQtyMin"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColQtySum"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColPriMax"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColPriMin"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColPriceSum"].Width = nWidth * 12 / 100;
                        poGD.Cols["otbColAmtSum"].Width = nWidth * 12 / 100;


                        //กำหนด Caption Title หัว Column
                        poGD.Cols["otbColSalCod"].Caption = "รหัสขาย";
                        poGD.Cols["otbColQtyMax"].Caption = "จำนวนมากสุด";
                        poGD.Cols["otbColQtyMin"].Caption = "จำนวนน้อยสุด";
                        poGD.Cols["otbColQtySum"].Caption = "จำนวนรวม";
                        poGD.Cols["otbColPriMax"].Caption = "ราคามากสุด";
                        poGD.Cols["otbColPriMin"].Caption = "ราคาต่ำสุด";
                        poGD.Cols["otbColPriceSum"].Caption = "ราคารวม";
                        poGD.Cols["otbColAmtSum"].Caption = "ยอดขายรวม";
                        poGD.Cols["otbColPdts"].Caption = "จำนวนประเภทสินค้า";

                        //กำหนดตำแหน่งข้อความ Title หัว Column
                        poGD.Cols["otbColSalCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColQtyMax"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColQtyMin"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColQtySum"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPriMax"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPriMin"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPriceSum"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColAmtSum"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["otbColPdts"].TextAlignFixed = TextAlignEnum.CenterCenter;


                        //กำหนดตำแหน่งข้อความในส่วนของข้อมูล
                        poGD.Cols["otbColSalCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["otbColQtyMax"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColQtyMin"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColQtySum"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColPriMax"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColPriMin"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColPriceSum"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColAmtSum"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["otbColPdts"].TextAlign = TextAlignEnum.RightCenter;

                        //กำหนด Column แสดงจำนวนเต็ม
                        poGD.Cols["otbColQtyMax"].Format = "###,###,##0";
                        poGD.Cols["otbColQtyMin"].Format = "###,###,##0";
                        poGD.Cols["otbColQtySum"].Format = "###,###,##0";
                        poGD.Cols["otbColPdts"].Format = "###,###,##0";
                        //กำหนด Column แสดงจำนวนเต็มแบบมีทศนิยม
                        poGD.Cols["otbColPriMax"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["otbColPriMin"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["otbColPriceSum"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["otbColAmtSum"].Format = "###,###,##0." + new string('0', 2);

                        #endregion end Set Col ogdSumSal
                        break;

                    default:
                        // ไม่ต้องทำอะไร
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
        private void W_GETxGetSalDetail()
        {
            try
            {
                ogdSalDet.DataSource = null;
                List<cmlResSalDet> aoResSalDets = new List<cmlResSalDet>();
                aoResSalDets = new cSaldetService().C_GETaGetSaleDet(otdSchSal.Text);
                //ogdSalDet.DataSource = aoResSalDets;

                ogdSalDet.DataSource = null;

                ogdSalDet.Rows.Count = ogdSalDet.Rows.Fixed;
                if (ogdSalDet != null && aoResSalDets.Count > 0)
                {
                    foreach (cmlResSalDet oSalDet in aoResSalDets)
                    {
                        ogdSalDet.Rows.Add();
                        //int nIndex = ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed;
                        CellStyle oCellStyle;
                        oCellStyle = ogdSalDet.Styles.Add("Receive");
                        oCellStyle.BackColor = Color.Yellow;
                        oCellStyle.ForeColor = Color.Blue;

                        ogdSalDet.BackColor = Color.PaleGreen;
                        if (ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed % 2 == 0)
                        {
                            ogdSalDet.SetCellStyle(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, 1, oCellStyle);
                        }
                        else
                        {
                            // not anything
                        }


                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalID", oSalDet.rnSalID);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalCod", oSalDet.rtSalCod);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalPdtCod", oSalDet.rtSalPdtCod);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColPdtName", oSalDet.rtPdtName);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColPdtDes", oSalDet.rtPdtDes);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColPdtTyp", oSalDet.rtPdtTyp);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalQty", oSalDet.rnSalQty);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalPri", oSalDet.rcSalPri);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalAmt", oSalDet.rcSalAmt);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalDate", oSalDet.rdSalDate);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalCstCod", oSalDet.rtSalCstCod);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColCstName", oSalDet.rtCstName);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColCstAdr", oSalDet.rtCstAdr);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColCstPho", oSalDet.rtCstPho);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColCstEml", oSalDet.rtCstEml);
                        ogdSalDet.SetData(ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed, "otbColSalSMPT", oSalDet.rdSalSMPT);

                    }

                    //}

                }
                else
                {
                    // not anyting
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

        private void ocmSetImg_Click_1(object sender, EventArgs e)
        {
            // ไม่ได้ใช้แล้ว
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select an Image";
                Image oImg;
                // Show the dialog and check if the user selected a file
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path
                    string sFilePath = ofd.FileName;

                    // Check if file exists
                    if (File.Exists(sFilePath))
                    {
                        oImg = Image.FromFile(ofd.FileName);
                        // uploadedImage.Save("E:\\ada\\expros\\testImgs\\"+DateTime.Now.ToString("yyyymmddmm")+"tre489464534" +".png");

                        //uploadedImage = Image.FromFile("E:\\ada\\testpros\\testImgs\\2024241724tre489464534.png");
                        //c1PictureBox1.Image = oImg;
                        //c1PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        //pictureBox1.Image = new Bitmap(sFilePath);
                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("File not found!");
                    }
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

        private void ocmSsh_Click(object sender, EventArgs e)
        {
            try
            {
                W_GETxGetSalDetail();
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

        private void ogdSalDet_Click(object sender, EventArgs e)
        {
            try
            {
                int nIdx = ogdSalDet.Row;
                otdSchSal.Text = ogdSalDet.GetData(nIdx, ogdSalDet.ColSel).ToString();


            }
            catch (Exception oEx)
            {

                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
            }
            finally
            {

            }
        }

        private void ocmCls_Click(object sender, EventArgs e)
        {
            otdSchSal.Text = "";
            W_GETxGetSalDetail();
        }

        private void otdSchSal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    W_GETxGetSalDetail();
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

        private void W_GETxGetSalDetSummy()
        {
            List<cmlResSalDetSummy> aoResSalSumys;
            try
            {
                ogdSumSal.DataSource = null;
                aoResSalSumys = new List<cmlResSalDetSummy>();
                aoResSalSumys = new cSaldetService().C_GETaGetSalDetSummy();
                //ogdSalDet.DataSource = aoResSalDets;


                ogdSumSal.Rows.Count = ogdSumSal.Rows.Fixed;
                if (ogdSumSal != null && aoResSalSumys.Count > 0)
                {
                    foreach (cmlResSalDetSummy oSalSumy in aoResSalSumys)
                    {
                        ogdSumSal.Rows.Add();
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed,"otbColSalCod", oSalSumy.rtSalCod);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed,"otbColQtyMax", oSalSumy.rnQtyMax);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed,"otbColQtyMin", oSalSumy.rnQtyMin);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed,"otbColQtySum", oSalSumy.rnQtySum);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed,"otbColPriMax", oSalSumy.rcPriMax);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed, "otbColPriMin", oSalSumy.rcPriMin);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed, "otbColPriceSum", oSalSumy.rcPriceSum);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed, "otbColAmtSum", oSalSumy.rcAmtSum);
                        ogdSumSal.SetData(ogdSumSal.Rows.Count - ogdSumSal.Rows.Fixed, "otbColPdts", oSalSumy.rnPdts);
                    }


                }
                else
                {
                    // not anyting
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

    } 
}
