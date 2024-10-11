﻿using C1.Win.C1FlexGrid;
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
            C_GetPdtData();
            C_GetSalData();
            C_GetCstData();
        }


        private void C_GetPdtData()
        {
            odgPdt.Row.ToString();

            List<cmlResPdt> oaPdt = new cPstService().C_GEToProduct();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgPdt.DataSource = oaPdt;
        }


        private void C_GetSalData()
        {

            List<cmlSale> oaSale = new cSaleService().C_GETSale();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();
            string[] ColsName = { "ลำดับ", "รหัสการขาย", "รหัสสินค้า", "จำนวน", "ราคา", "ราคารวม", "รหัสลูกค้า", "วันที่ขาย", "วันที่สร้างรายการ" };

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

            foreach (cmlSale oSal in oaSale)
            {
                odgSal.Rows.Add();
                int nIndex = odgSal.Rows.Count - odgSal.Rows.Fixed;
                CellStyle oCellStyle;
                oCellStyle = odgSal.Styles.Add("Receive");
                oCellStyle.DataType = typeof(Boolean);
                odgSal.SetData(nIndex, "rnSalID", oSal.rnSalID);
                odgSal.SetData(nIndex, "rtSalCod", oSal.rtSalCod);

            }



            odgSal.Cols[1].Caption = ColsName[0];
            odgSal.Cols[2].Caption = ColsName[1];
            odgSal.Cols[3].Caption = ColsName[2];
            odgSal.Cols[4].Caption = ColsName[3];
            odgSal.Cols[5].Caption = ColsName[4];
            odgSal.Cols[6].Caption = ColsName[5];
            odgSal.Cols[7].Caption = ColsName[6];
            odgSal.Cols[8].Caption = ColsName[7];
            odgSal.Cols[9].Caption = ColsName[8];



            odgSal.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Free;
            odgSal.Cols[2].AllowMerging = true;
            odgSal.Cols[3].AllowMerging = true;
            odgSal.Cols[7].AllowMerging = true;
        }

        private void C_GetCstData()
        {
            odgSal.Row.ToString();

            List<cmlCst> oaCst = new cCstService().C_GEToCustomer();

            //cPstService cPdtService = new cPstService();
            //cPdtService.C_GETaoProduct();

            odgCst.DataSource = oaCst;
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

        private void otbSalDate_ValueChanged(object sender, EventArgs e)
        {

        }

        //ogdCst


    }
}
