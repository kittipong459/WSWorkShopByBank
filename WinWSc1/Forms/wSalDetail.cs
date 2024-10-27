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
           
        }


        private void W_SETxDesign()  // W_SETxSetDesign
        {
            try
            {

                W_SETxColSalDel(ogdSalDet);

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
                        poGD.Cols["rnSalID"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtSalCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtSalPdtCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtPdtName"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtPdtDes"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtPdtTyp"].Width = nWidth * 6 / 100;
                        poGD.Cols["rnSalQty"].Width = nWidth * 6 / 100;
                        poGD.Cols["rcSalPri"].Width = nWidth * 6 / 100;
                        poGD.Cols["rcSalAmt"].Width = nWidth * 6 / 100;
                        poGD.Cols["rdSalDate"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtSalCstCod"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtCstName"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtCstAdr"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtCstPho"].Width = nWidth * 6 / 100;
                        poGD.Cols["rtCstEml"].Width = nWidth * 6 / 100;
                        poGD.Cols["rdSalSMPT"].Width = nWidth * 6 / 100;

                        //กำหนด Caption Title หัว Column
                        poGD.Cols["rnSalID"].Caption = "ลำดับ";
                        poGD.Cols["rtSalCod"].Caption = "รหัสการขาย";
                        poGD.Cols["rtSalPdtCod"].Caption = "รหัสสินค้า";
                        poGD.Cols["rtPdtName"].Caption = "ชื่อสินค้า";
                        poGD.Cols["rtPdtDes"].Caption = "รายละเอียด";
                        poGD.Cols["rtPdtTyp"].Caption = "ประเภท";
                        poGD.Cols["rnSalQty"].Caption = "จำนวน";
                        poGD.Cols["rcSalPri"].Caption = "ราคา";
                        poGD.Cols["rcSalAmt"].Caption = "ราคารวม";
                        poGD.Cols["rdSalDate"].Caption = "วันที่ขาย";
                        poGD.Cols["rtSalCstCod"].Caption = "รหัสลูกค้า";
                        poGD.Cols["rtCstName"].Caption = "ชื่อลูกค้า";
                        poGD.Cols["rtCstAdr"].Caption = "ที่อยู่";
                        poGD.Cols["rtCstPho"].Caption = "เบอร์โทร";
                        poGD.Cols["rtCstEml"].Caption = "อีเมล";
                        poGD.Cols["rdSalSMPT"].Caption = "วันที่สร้าง";

                        //กำหนดตำแหน่งข้อความ Title หัว Column
                        poGD.Cols["rnSalID"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalPdtCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtPdtName"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtPdtDes"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtPdtTyp"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rnSalQty"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rcSalPri"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rcSalAmt"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalDate"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCstCod"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtCstName"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtCstAdr"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtCstPho"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtCstEml"].TextAlignFixed = TextAlignEnum.CenterCenter;
                        poGD.Cols["rdSalSMPT"].TextAlignFixed = TextAlignEnum.CenterCenter;

                        //กำหนดตำแหน่งข้อความในส่วนของข้อมูล
                        poGD.Cols["rnSalID"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtSalPdtCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtPdtName"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtPdtDes"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtPdtTyp"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rnSalQty"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rcSalPri"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rcSalAmt"].TextAlign = TextAlignEnum.RightCenter;
                        poGD.Cols["rdSalDate"].TextAlign = TextAlignEnum.CenterCenter;
                        poGD.Cols["rtSalCstCod"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtCstName"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtCstAdr"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtCstPho"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rtCstEml"].TextAlign = TextAlignEnum.LeftCenter;
                        poGD.Cols["rdSalSMPT"].TextAlign = TextAlignEnum.CenterCenter;


                        //กำหนด Column แสดงจำนวนเต็ม
                        poGD.Cols["rnSalQty"].Format = "###,###,##0";
                        //กำหนด Column แสดงจำนวนเต็มแบบมีทศนิยม
                        poGD.Cols["rcSalPri"].Format = "###,###,##0." + new string('0', 2);
                        poGD.Cols["rcSalAmt"].Format = "###,###,##0." + new string('0', 2);

                        // merge
                        poGD.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                        for (int nRow = 0; nRow < poGD.Cols.Count - 1; nRow++)
                        {
                            ogdSalDet.Cols[nRow].AllowMerging = true;
                        }

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
                    foreach (cmlResSalDet oSalDel in aoResSalDets)
                    {
                        ogdSalDet.Rows.Add();
                        int nIndex = ogdSalDet.Rows.Count - ogdSalDet.Rows.Fixed;
                        CellStyle oCellStyle;
                        oCellStyle = ogdSalDet.Styles.Add("Receive");
                        oCellStyle.BackColor = Color.Yellow;
                        oCellStyle.ForeColor = Color.Blue;

                        ogdSalDet.BackColor = Color.PaleGreen;
                        if (nIndex % 2 == 0)
                        {
                            ogdSalDet.SetCellStyle(nIndex, 1, oCellStyle);
                        }


                        ogdSalDet.SetData(nIndex, "rnSalID",       oSalDel.rnSalID);
                        ogdSalDet.SetData(nIndex, "rtSalCod",      oSalDel.rtSalCod);
                        ogdSalDet.SetData(nIndex, "rtSalPdtCod",   oSalDel.rtSalPdtCod);
                        ogdSalDet.SetData(nIndex, "rtPdtName",     oSalDel.rtPdtName);
                        ogdSalDet.SetData(nIndex, "rtPdtDes",      oSalDel.rtPdtDes);
                        ogdSalDet.SetData(nIndex, "rtPdtTyp",      oSalDel.rtPdtTyp);
                        ogdSalDet.SetData(nIndex, "rnSalQty",      oSalDel.rnSalQty);
                        ogdSalDet.SetData(nIndex, "rcSalPri",      oSalDel.rcSalPri);
                        ogdSalDet.SetData(nIndex, "rcSalAmt",      oSalDel.rcSalAmt);
                        ogdSalDet.SetData(nIndex, "rdSalDate",     oSalDel.rdSalDate);
                        ogdSalDet.SetData(nIndex, "rtSalCstCod",   oSalDel.rtSalCstCod);
                        ogdSalDet.SetData(nIndex, "rtCstName",     oSalDel.rtCstName);
                        ogdSalDet.SetData(nIndex, "rtCstAdr",      oSalDel.rtCstAdr);
                        ogdSalDet.SetData(nIndex, "rtCstPho",      oSalDel.rtCstPho);
                        ogdSalDet.SetData(nIndex, "rtCstEml",      oSalDel.rtCstEml);
                        ogdSalDet.SetData(nIndex, "rdSalSMPT",    oSalDel.rdSalSMPT);

                    }


                    //}

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
    }
}
