using C1.Win.C1FlexGrid;
using System;
namespace WindowsFormsApp1
{
    partial class wWSmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wWSmain));
            this.odgPdt = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odgCst = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.otbSalCod = new C1.Win.C1Input.C1TextBox();
            this.otbSalPdtCod = new C1.Win.C1Input.C1TextBox();
            this.otbSalQty = new C1.Win.C1Input.C1TextBox();
            this.otbSalPri = new C1.Win.C1Input.C1TextBox();
            this.otbSalAmt = new C1.Win.C1Input.C1TextBox();
            this.otbSalCstCod = new C1.Win.C1Input.C1TextBox();
            this.otbSalDate = new C1.Win.C1Input.C1DateEdit();
            this.ocmAddSal = new C1.Win.C1Input.C1Button();
            this.olaCod = new System.Windows.Forms.Label();
            this.olaPdtCod = new System.Windows.Forms.Label();
            this.olaQty = new System.Windows.Forms.Label();
            this.olaPri = new System.Windows.Forms.Label();
            this.olaPriAmt = new System.Windows.Forms.Label();
            this.olaCstCod = new System.Windows.Forms.Label();
            this.olaSalDate = new System.Windows.Forms.Label();
            this.ocmEdtSal = new C1.Win.C1Input.C1Button();
            this.comClrSal = new C1.Win.C1Input.C1Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.olaId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.odgSal = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.ocmSalDet = new C1.Win.C1Input.C1Button();
            this.ocmReprt = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.odgPdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgCst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPdtCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCstCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmAddSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmEdtSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comClrSal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odgSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSalDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmReprt)).BeginInit();
            this.SuspendLayout();
            // 
            // odgPdt
            // 
            this.odgPdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.odgPdt.ColumnInfo = "10,1,0,0,0,-1,Columns:1{Style:\"BackColor:Window;\";}\t3{Style:\"BackColor:Window;\";}" +
    "\t";
            this.odgPdt.Location = new System.Drawing.Point(16, 40);
            this.odgPdt.Name = "odgPdt";
            this.odgPdt.Size = new System.Drawing.Size(643, 148);
            this.odgPdt.StyleInfo = resources.GetString("odgPdt.StyleInfo");
            this.odgPdt.TabIndex = 0;
            this.odgPdt.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.odgPdt.Click += new System.EventHandler(this.odgPdt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ข้อมูลการขาย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ข้อมูลสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ข้อมูลลูกค้า";
            // 
            // odgCst
            // 
            this.odgCst.BackColor = System.Drawing.Color.MistyRose;
            this.odgCst.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.odgCst.Location = new System.Drawing.Point(16, 34);
            this.odgCst.Name = "odgCst";
            this.odgCst.Size = new System.Drawing.Size(644, 151);
            this.odgCst.StyleInfo = resources.GetString("odgCst.StyleInfo");
            this.odgCst.TabIndex = 7;
            this.odgCst.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.odgCst.Click += new System.EventHandler(this.odgCst_Click);
            // 
            // otbSalCod
            // 
            this.otbSalCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalCod.Location = new System.Drawing.Point(119, 40);
            this.otbSalCod.Name = "otbSalCod";
            this.otbSalCod.Size = new System.Drawing.Size(252, 29);
            this.otbSalCod.TabIndex = 8;
            this.otbSalCod.Tag = null;
            // 
            // otbSalPdtCod
            // 
            this.otbSalPdtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalPdtCod.Location = new System.Drawing.Point(119, 85);
            this.otbSalPdtCod.Name = "otbSalPdtCod";
            this.otbSalPdtCod.Size = new System.Drawing.Size(252, 29);
            this.otbSalPdtCod.TabIndex = 9;
            this.otbSalPdtCod.Tag = null;
            // 
            // otbSalQty
            // 
            this.otbSalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalQty.Location = new System.Drawing.Point(119, 130);
            this.otbSalQty.Name = "otbSalQty";
            this.otbSalQty.Size = new System.Drawing.Size(252, 29);
            this.otbSalQty.TabIndex = 10;
            this.otbSalQty.Tag = null;
            this.otbSalQty.TextChanged += new System.EventHandler(this.otbSalQty_TextChanged);
            // 
            // otbSalPri
            // 
            this.otbSalPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalPri.Location = new System.Drawing.Point(119, 176);
            this.otbSalPri.Name = "otbSalPri";
            this.otbSalPri.Size = new System.Drawing.Size(252, 29);
            this.otbSalPri.TabIndex = 11;
            this.otbSalPri.Tag = null;
            this.otbSalPri.TextChanged += new System.EventHandler(this.otbSalPri_TextChanged);
            // 
            // otbSalAmt
            // 
            this.otbSalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalAmt.Location = new System.Drawing.Point(119, 223);
            this.otbSalAmt.Name = "otbSalAmt";
            this.otbSalAmt.Size = new System.Drawing.Size(252, 29);
            this.otbSalAmt.TabIndex = 12;
            this.otbSalAmt.Tag = null;
            // 
            // otbSalCstCod
            // 
            this.otbSalCstCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalCstCod.Location = new System.Drawing.Point(119, 267);
            this.otbSalCstCod.Name = "otbSalCstCod";
            this.otbSalCstCod.Size = new System.Drawing.Size(252, 29);
            this.otbSalCstCod.TabIndex = 13;
            this.otbSalCstCod.Tag = null;
            // 
            // otbSalDate
            // 
            // 
            // 
            // 
            this.otbSalDate.Calendar.DayNameLength = 1;
            this.otbSalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalDate.GapHeight = 0;
            this.otbSalDate.ImagePadding = new System.Windows.Forms.Padding(0);
            this.otbSalDate.Location = new System.Drawing.Point(119, 310);
            this.otbSalDate.Name = "otbSalDate";
            this.otbSalDate.Size = new System.Drawing.Size(252, 27);
            this.otbSalDate.TabIndex = 14;
            this.otbSalDate.Tag = null;
            // 
            // ocmAddSal
            // 
            this.ocmAddSal.BackColor = System.Drawing.Color.Lime;
            this.ocmAddSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmAddSal.Location = new System.Drawing.Point(106, 359);
            this.ocmAddSal.Name = "ocmAddSal";
            this.ocmAddSal.Size = new System.Drawing.Size(89, 35);
            this.ocmAddSal.TabIndex = 16;
            this.ocmAddSal.Text = "เพิ่ม";
            this.ocmAddSal.UseVisualStyleBackColor = false;
            this.ocmAddSal.UseVisualStyleForeColor = true;
            this.ocmAddSal.Click += new System.EventHandler(this.ocmAddSal_Click);
            // 
            // olaCod
            // 
            this.olaCod.AutoSize = true;
            this.olaCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaCod.Location = new System.Drawing.Point(23, 42);
            this.olaCod.Name = "olaCod";
            this.olaCod.Size = new System.Drawing.Size(67, 24);
            this.olaCod.TabIndex = 17;
            this.olaCod.Text = "รหัสขาย";
            // 
            // olaPdtCod
            // 
            this.olaPdtCod.AutoSize = true;
            this.olaPdtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPdtCod.Location = new System.Drawing.Point(20, 89);
            this.olaPdtCod.Name = "olaPdtCod";
            this.olaPdtCod.Size = new System.Drawing.Size(80, 24);
            this.olaPdtCod.TabIndex = 18;
            this.olaPdtCod.Text = "รหัสสินค้า";
            // 
            // olaQty
            // 
            this.olaQty.AutoSize = true;
            this.olaQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaQty.Location = new System.Drawing.Point(23, 134);
            this.olaQty.Name = "olaQty";
            this.olaQty.Size = new System.Drawing.Size(61, 24);
            this.olaQty.TabIndex = 19;
            this.olaQty.Text = "จำนวน";
            // 
            // olaPri
            // 
            this.olaPri.AutoSize = true;
            this.olaPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPri.Location = new System.Drawing.Point(23, 180);
            this.olaPri.Name = "olaPri";
            this.olaPri.Size = new System.Drawing.Size(45, 24);
            this.olaPri.TabIndex = 20;
            this.olaPri.Text = "ราคา";
            // 
            // olaPriAmt
            // 
            this.olaPriAmt.AutoSize = true;
            this.olaPriAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPriAmt.Location = new System.Drawing.Point(23, 227);
            this.olaPriAmt.Name = "olaPriAmt";
            this.olaPriAmt.Size = new System.Drawing.Size(72, 24);
            this.olaPriAmt.TabIndex = 21;
            this.olaPriAmt.Text = "ราคารวม";
            // 
            // olaCstCod
            // 
            this.olaCstCod.AutoSize = true;
            this.olaCstCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaCstCod.Location = new System.Drawing.Point(23, 271);
            this.olaCstCod.Name = "olaCstCod";
            this.olaCstCod.Size = new System.Drawing.Size(77, 24);
            this.olaCstCod.TabIndex = 22;
            this.olaCstCod.Text = "รหัสลูกค้า";
            // 
            // olaSalDate
            // 
            this.olaSalDate.AutoSize = true;
            this.olaSalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaSalDate.Location = new System.Drawing.Point(23, 314);
            this.olaSalDate.Name = "olaSalDate";
            this.olaSalDate.Size = new System.Drawing.Size(71, 24);
            this.olaSalDate.TabIndex = 23;
            this.olaSalDate.Text = "วันที่ขาย";
            // 
            // ocmEdtSal
            // 
            this.ocmEdtSal.BackColor = System.Drawing.Color.Orange;
            this.ocmEdtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmEdtSal.Location = new System.Drawing.Point(201, 359);
            this.ocmEdtSal.Name = "ocmEdtSal";
            this.ocmEdtSal.Size = new System.Drawing.Size(89, 35);
            this.ocmEdtSal.TabIndex = 24;
            this.ocmEdtSal.Text = "แก้ไข";
            this.ocmEdtSal.UseVisualStyleBackColor = false;
            this.ocmEdtSal.UseVisualStyleForeColor = true;
            this.ocmEdtSal.Click += new System.EventHandler(this.ocmEdtSal_Click);
            // 
            // comClrSal
            // 
            this.comClrSal.BackColor = System.Drawing.Color.Gray;
            this.comClrSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comClrSal.Location = new System.Drawing.Point(296, 359);
            this.comClrSal.Name = "comClrSal";
            this.comClrSal.Size = new System.Drawing.Size(89, 35);
            this.comClrSal.TabIndex = 26;
            this.comClrSal.Text = "ล้างข้อมูล";
            this.comClrSal.UseVisualStyleBackColor = false;
            this.comClrSal.UseVisualStyleForeColor = true;
            this.comClrSal.Click += new System.EventHandler(this.comClrSal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.odgPdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(419, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 198);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.odgCst);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(419, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 197);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.olaId);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.otbSalCod);
            this.panel3.Controls.Add(this.otbSalPdtCod);
            this.panel3.Controls.Add(this.otbSalQty);
            this.panel3.Controls.Add(this.olaSalDate);
            this.panel3.Controls.Add(this.ocmEdtSal);
            this.panel3.Controls.Add(this.olaCstCod);
            this.panel3.Controls.Add(this.olaPriAmt);
            this.panel3.Controls.Add(this.comClrSal);
            this.panel3.Controls.Add(this.olaPri);
            this.panel3.Controls.Add(this.otbSalPri);
            this.panel3.Controls.Add(this.olaQty);
            this.panel3.Controls.Add(this.otbSalAmt);
            this.panel3.Controls.Add(this.olaPdtCod);
            this.panel3.Controls.Add(this.otbSalCstCod);
            this.panel3.Controls.Add(this.olaCod);
            this.panel3.Controls.Add(this.otbSalDate);
            this.panel3.Controls.Add(this.ocmAddSal);
            this.panel3.Location = new System.Drawing.Point(18, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 406);
            this.panel3.TabIndex = 29;
            // 
            // olaId
            // 
            this.olaId.AutoSize = true;
            this.olaId.BackColor = System.Drawing.Color.Cornsilk;
            this.olaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaId.ForeColor = System.Drawing.Color.Cornsilk;
            this.olaId.Location = new System.Drawing.Point(264, 8);
            this.olaId.Name = "olaId";
            this.olaId.Size = new System.Drawing.Size(49, 24);
            this.olaId.TabIndex = 28;
            this.olaId.Text = "ลำดับ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(7, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "จัดการข้อมูลการขาย";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.odgSal);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(18, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 240);
            this.panel4.TabIndex = 30;
            // 
            // odgSal
            // 
            this.odgSal.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.odgSal.Location = new System.Drawing.Point(13, 38);
            this.odgSal.Name = "odgSal";
            this.odgSal.Size = new System.Drawing.Size(903, 189);
            this.odgSal.StyleInfo = resources.GetString("odgSal.StyleInfo");
            this.odgSal.TabIndex = 3;
            this.odgSal.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.odgSal.Click += new System.EventHandler(this.odgSal_Click);
            // 
            // ocmSalDet
            // 
            this.ocmSalDet.BackColor = System.Drawing.Color.Lime;
            this.ocmSalDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmSalDet.Location = new System.Drawing.Point(971, 439);
            this.ocmSalDet.Name = "ocmSalDet";
            this.ocmSalDet.Size = new System.Drawing.Size(118, 89);
            this.ocmSalDet.TabIndex = 31;
            this.ocmSalDet.Text = "รายละเอียดการขาย";
            this.ocmSalDet.UseVisualStyleBackColor = false;
            this.ocmSalDet.UseVisualStyleForeColor = true;
            this.ocmSalDet.Click += new System.EventHandler(this.ocmSalDet_Click);
            // 
            // ocmReprt
            // 
            this.ocmReprt.BackColor = System.Drawing.Color.Yellow;
            this.ocmReprt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmReprt.Location = new System.Drawing.Point(971, 545);
            this.ocmReprt.Name = "ocmReprt";
            this.ocmReprt.Size = new System.Drawing.Size(118, 89);
            this.ocmReprt.TabIndex = 32;
            this.ocmReprt.Text = "ออกรายงาน";
            this.ocmReprt.UseVisualStyleBackColor = false;
            this.ocmReprt.UseVisualStyleForeColor = true;
            // 
            // wWSmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 679);
            this.Controls.Add(this.ocmReprt);
            this.Controls.Add(this.ocmSalDet);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "wWSmain";
            this.Text = "ระบบขายสินค้า";
            ((System.ComponentModel.ISupportInitialize)(this.odgPdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgCst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPdtCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCstCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmAddSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmEdtSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comClrSal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odgSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSalDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmReprt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid odgPdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1FlexGrid.C1FlexGrid odgCst;
        private C1.Win.C1Input.C1TextBox otbSalCod;
        private C1.Win.C1Input.C1TextBox otbSalPdtCod;
        private C1.Win.C1Input.C1TextBox otbSalQty;
        private C1.Win.C1Input.C1TextBox otbSalPri;
        private C1.Win.C1Input.C1TextBox otbSalAmt;
        private C1.Win.C1Input.C1TextBox otbSalCstCod;
        private C1.Win.C1Input.C1DateEdit otbSalDate;
        private C1.Win.C1Input.C1Button ocmAddSal;
        private System.Windows.Forms.Label olaPdtCod;
        private System.Windows.Forms.Label olaQty;
        private System.Windows.Forms.Label olaPri;
        private System.Windows.Forms.Label olaPriAmt;
        private System.Windows.Forms.Label olaCstCod;
        private System.Windows.Forms.Label olaSalDate;
        private C1.Win.C1Input.C1Button ocmEdtSal;
        private C1.Win.C1Input.C1Button comClrSal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private C1.Win.C1Input.C1Button ocmSalDet;
        private C1.Win.C1Input.C1Button ocmReprt;
        private C1.Win.C1FlexGrid.C1FlexGrid odgSal;
        private System.Windows.Forms.Label olaId;
        private System.Windows.Forms.Label olaCod;
    }
}

