using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using wModels;
using static C1.Util.Win.Win32;
using static WindowsFormsApp1.Service.cPstService;

namespace WindowsFormsApp1
{
    public partial class wWSmain : Form
    {
        public wWSmain()
        {
            InitializeComponent();
            W_GetxPdtData();
            W_GetxSalData();
            W_GetxCstData();
        }


        private cmlReqSale W_oCheckSalData()
        {
            cmlReqSale mSale = new cmlReqSale();
            try
            {
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
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {
                mSale = null;
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
            }
            catch (Exception oEx)
            {
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

                odgSal.Cols.Count = 10;
                odgSal.Cols[1].Name = "rnSalID";
                odgSal.Cols[2].Name = "rtSalCod";
                odgSal.Cols[3].Name = "rtSalPdtCod";
                odgSal.Cols[4].Name = "rnSalQty";
                odgSal.Cols[5].Name = "rcSalPri";
                odgSal.Cols[6].Name = "rcSalAmt";
                odgSal.Cols[7].Name = "rtSalCstCod";
                odgSal.Cols[8].Name = "rdSalDate";
                odgSal.Cols[9].Name = "rdSalSMPT";
                int nIndex = 1;
                foreach (cmlResSale oSal in oaSale)
                {
                    odgSal.Rows.Add();
                   
                    CellStyle oCellStyle;
                    oCellStyle = odgSal.Styles.Add("Receive");
                    oCellStyle.DataType = typeof(Boolean);
                    odgSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                    odgSal.SetData(nIndex, "rtSalCod", oSal.rtSalCod);
                    odgSal.SetData(nIndex, "rtSalPdtCod", oSal.rtSalPdtCod);
                    odgSal.SetData(nIndex, "rnSalQty", oSal.rnSalQty);
                    odgSal.SetData(nIndex, "rcSalPri", oSal.rcSalPri);
                    odgSal.SetData(nIndex, "rcSalAmt", oSal.rcSalAmt);
                    odgSal.SetData(nIndex, "rtSalCstCod", oSal.rtSalCstCod);
                    odgSal.SetData(nIndex, "rdSalDate", oSal.rdSalDate);
                    odgSal.SetData(nIndex, "rdSalSMPT", oSal.rdSalSMPT);
                    nIndex++;
                }


                string[] W_ColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ" };
                odgSal.Cols[1].Caption = W_ColsName[0];
                odgSal.Cols[2].Caption = W_ColsName[1];
                odgSal.Cols[3].Caption = W_ColsName[2];
                odgSal.Cols[4].Caption = W_ColsName[3];
                odgSal.Cols[5].Caption = W_ColsName[4];
                odgSal.Cols[6].Caption = W_ColsName[5];
                odgSal.Cols[7].Caption = W_ColsName[6];
                odgSal.Cols[8].Caption = W_ColsName[7];
                odgSal.Cols[9].Caption = W_ColsName[8];

                odgSal.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
                odgSal.Cols[2].AllowMerging = true;
                odgSal.Cols[3].AllowMerging = true;
                odgSal.Cols[7].AllowMerging = true;
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
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
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }

        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmlReqSale mSale = new cmlReqSale();
                mSale = W_oCheckSalData();

                bool res = new cSaleService().C_POSTbSaveSale(mSale);
                W_GetxPdtData();
                W_GetxSalData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
            }
            finally
            {

            }

        }

        private void c1TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void wWSmain_Load(object sender, EventArgs e)
        {

        }

        private void c1Button4_Click(object sender, EventArgs e)
        {

        }

        private void c1TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void otbSalAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void otbSalPri_TextChanged(object sender, EventArgs e)
        {
            W_SetxAmt();

        }

        private void otbSalQty_TextChanged(object sender, EventArgs e)
        {
            W_SetxAmt();

        }


        private void W_SetxAmt()
        {
            try
            {
                if (!string.IsNullOrEmpty(otbSalPri.Text) && !string.IsNullOrEmpty(otbSalQty.Text))
                {
                    decimal W_cPri = decimal.Parse(otbSalPri.Text);
                    decimal W_nQty = decimal.Parse(otbSalQty.Text);
                    otbSalAmt.Text = (W_cPri * W_nQty).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
            }
            finally
            {

            }
        }



        private void c1Button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally { }
            cmlReqSale mSale = new cmlReqSale();
            mSale = W_oCheckSalData();

            bool W_res = new cSaleService().C_POSTbUpdateSale(mSale);
            W_GetxPdtData();
            W_GetxSalData();
        }

        private void otbSalDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void c1Button6_Click(object sender, EventArgs e)
        {

        }

        private void c1Button5_Click(object sender, EventArgs e)
        {
            wSalDetail wSalDetail = new wSalDetail();
            wSalDetail.Show();
        }

        private void odgSal_Click(object sender, EventArgs e)
        {
            try
            {
                //if (e.Col == odgSal.Cols["ockColSel"].Index)
                //{
                //    if (Convert.ToBoolean(odgSal.GetData(e.Row, e.Col)) == true)
                //    {
                //        string tPdtCode = odgSal.GetData(e.Row, odgSal.Cols["tColPdtCode"].Index).ToString();
                //        MessageBox.Show($"{tPdtCode}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}
            }
            catch (Exception oEx)
            {

            }
            finally
            {

            }
        }

        //ogdCst


    }
}
