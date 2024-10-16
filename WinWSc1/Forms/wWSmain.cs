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
            C_GetxPdtData();
            C_GetxSalData();
            C_GetxCstData();
        }


        private cmlResSale W_CheckSalData()
        {
            cmlResSale mSale = new cmlResSale();
            try
            {


                if (string.IsNullOrEmpty(otbSalCod.Text))
                    MessageBox.Show("ระบุรหัสการขาย");
                else
                    mSale.rtSalCod = otbSalCod.Text;
                if (string.IsNullOrEmpty(otbSalPdtCod.Text))
                    MessageBox.Show("ระบุรหัสิสนค้า");
                else
                    mSale.rtSalPdtCod = otbSalPdtCod.Text;
                if (string.IsNullOrEmpty(otbSalCstCod.Text))
                    MessageBox.Show("ระบุรหัสลูกค้า");
                else
                    mSale.rtSalCstCod = otbSalCstCod.Text;
                if (string.IsNullOrEmpty(otbSalPri.Text))
                    MessageBox.Show("ระบุราคา");
                else
                    mSale.rcSalPri = decimal.Parse(otbSalPri.Text);
                if (string.IsNullOrEmpty(otbSalQty.Text))
                    MessageBox.Show("ระบุจำนวน");
                else
                    mSale.rnSalQty = int.Parse(otbSalQty.Text);
                if (string.IsNullOrEmpty(otbSalAmt.Text))
                    MessageBox.Show("ราคารวม");
                else
                    mSale.rcSalAmt = decimal.Parse(otbSalAmt.Text);
                if (string.IsNullOrEmpty(otbSalDate.Value.ToString()))
                    MessageBox.Show("ระบุวันที่ขาย");
                else
                    mSale.rdSalDate = DateTime.Parse(otbSalDate.Value.ToString());

                mSale.rdSalSMPT = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
            }
            return mSale;
        }

        private void C_GetxPdtData()
        {
            odgPdt.Row.ToString();

            List<cmlReqPdt> oaPdt = new cPstService().C_GEToProduct();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgPdt.DataSource = oaPdt;
        }


        private void C_GetxSalData()
        {

            List<cmlResSale> oaSale = new cSaleService().C_GETxSale();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();
            string[] W_ColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ" };

            odgSal.DataSource = oaSale;
            //odgSal.Rows.Count = odgSal.Rows.Fixed;
            //odgSal.Cols["rnSalID"].AllowEditing = false;
            //odgSal.Cols["rtSalCod"].AllowEditing = false;
            //odgSal.Cols["rtSalPdtCod"].AllowEditing = false;
            //odgSal.Cols["rnSalQty"].AllowEditing = false;
            //odgSal.Cols["rcSalPri"].AllowEditing = false;
            //odgSal.Cols["rcSalAmt"].AllowEditing = false;
            //odgSal.Cols["rtSalCstCod"].AllowEditing = false;
            //odgSal.Cols["rdSalDate"].AllowEditing = false;
            //odgSal.Cols["rdSalSMPT"].AllowEditing = false;

            foreach (cmlResSale oSal in oaSale)
            {
                odgSal.Rows.Add();
                int nIndex = odgSal.Rows.Count - odgSal.Rows.Fixed;
                CellStyle oCellStyle;
                oCellStyle = odgSal.Styles.Add("Receive");
                oCellStyle.DataType = typeof(Boolean);
                odgSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                odgSal.SetData(nIndex, "rtSalCod", oSal.rtSalCod);

            }



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

        private void C_GetxCstData()
        {
            odgSal.Row.ToString();

            List<cmlResCst> W_oaCst = new cCstService().C_GEToCustomer();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgCst.DataSource = W_oaCst;
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmlResSale mSale = new cmlResSale();
                mSale = W_CheckSalData();

                bool res = new cSaleService().C_POSToSaveSale(mSale);
                C_GetxPdtData();
                C_GetxSalData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
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
        }

        

        private void c1Button2_Click(object sender, EventArgs e)
        {
            cmlResSale mSale = new cmlResSale();
            mSale = W_CheckSalData();

            bool W_res = new cSaleService().C_POSToUpdateSale(mSale);
            C_GetxPdtData();
            C_GetxSalData();
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

        //ogdCst


    }
}
