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
using static WindowsFormsApp1.Service.cPstService;

namespace WindowsFormsApp1
{
    public partial class wWSmain : Form
    {
        public wWSmain()
        {
            InitializeComponent();
            C_GetPdtData();
            C_GetSalData();
            C_GetCstData();
        }


        private void C_GetPdtData()
        {
            odgPdt.Row.ToString();

            List<cmlResPdt> data = new cPstService().C_GEToProduct();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgPdt.DataSource = data;
        }


        private void C_GetSalData()
        {
            odgSal.Row.ToString();

            List<cmlSale> data = new cSaleService().C_GETSale();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgSal.DataSource = data;
        }

        private void C_GetCstData()
        {
            odgSal.Row.ToString();

            List<cmlCst> data = new cCstService().C_GEToCustomer();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgCst.DataSource = data;
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmlSale mSale = new cmlSale();
                mSale = W_CheckSalData();

                bool res = new cSaleService().C_POSToSaveSale(mSale);
                C_GetPdtData();
                C_GetSalData();
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
            W_SetAmt();

        }

        private void otbSalQty_TextChanged(object sender, EventArgs e)
        {
            W_SetAmt();

        }


        private void W_SetAmt()
        {
            try
            {
                if (!string.IsNullOrEmpty(otbSalPri.Text) && !string.IsNullOrEmpty(otbSalQty.Text))
                {
                    decimal cPri = decimal.Parse(otbSalPri.Text);
                    decimal nQty = decimal.Parse(otbSalQty.Text);
                    otbSalAmt.Text = (cPri * nQty).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
            }
        }

        private cmlSale W_CheckSalData()
        {
            cmlSale mSale = new cmlSale();
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

        private void c1Button2_Click(object sender, EventArgs e)
        {
            cmlSale mSale = new cmlSale();
            mSale = W_CheckSalData();

            bool res = new cSaleService().C_POSToUpdateSale(mSale);
            C_GetPdtData();
            C_GetSalData();
        }

        //ogdCst


    }
}
