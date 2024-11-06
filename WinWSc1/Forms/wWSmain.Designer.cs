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
            this.ogdPdt = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.olaSalResTitle = new System.Windows.Forms.Label();
            this.olaPdtTitle = new System.Windows.Forms.Label();
            this.olaCstTitle = new System.Windows.Forms.Label();
            this.ogdCst = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.olaCod = new System.Windows.Forms.Label();
            this.olaPdtCod = new System.Windows.Forms.Label();
            this.olaQty = new System.Windows.Forms.Label();
            this.olaPri = new System.Windows.Forms.Label();
            this.olaPriAmt = new System.Windows.Forms.Label();
            this.olaCstCod = new System.Windows.Forms.Label();
            this.olaSalDate = new System.Windows.Forms.Label();
            this.opnPdt = new System.Windows.Forms.Panel();
            this.opnCst = new System.Windows.Forms.Panel();
            this.opnManSal = new System.Windows.Forms.Panel();
            this.ocmClsSal = new System.Windows.Forms.Button();
            this.ocmEdtSal = new System.Windows.Forms.Button();
            this.ocmAddSal = new System.Windows.Forms.Button();
            this.otbSalDate = new System.Windows.Forms.DateTimePicker();
            this.otbSalCstCod = new System.Windows.Forms.TextBox();
            this.otbSalAmt = new System.Windows.Forms.TextBox();
            this.otbSalPri = new System.Windows.Forms.TextBox();
            this.otbSalQty = new System.Windows.Forms.TextBox();
            this.otbSalPdtCod = new System.Windows.Forms.TextBox();
            this.otbSalCod = new System.Windows.Forms.TextBox();
            this.olaId = new System.Windows.Forms.Label();
            this.olaManeSalTitle = new System.Windows.Forms.Label();
            this.opnSal = new System.Windows.Forms.Panel();
            this.ocmSalDet = new System.Windows.Forms.Button();
            this.ogdSal = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ogdPdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdCst)).BeginInit();
            this.opnPdt.SuspendLayout();
            this.opnCst.SuspendLayout();
            this.opnManSal.SuspendLayout();
            this.opnSal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSal)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdPdt
            // 
            this.ogdPdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdPdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ogdPdt.ColumnInfo = resources.GetString("ogdPdt.ColumnInfo");
            this.ogdPdt.Location = new System.Drawing.Point(16, 40);
            this.ogdPdt.Name = "ogdPdt";
            this.ogdPdt.Rows.MaxSize = 25;
            this.ogdPdt.Rows.MinSize = 25;
            this.ogdPdt.Size = new System.Drawing.Size(643, 148);
            this.ogdPdt.StyleInfo = resources.GetString("ogdPdt.StyleInfo");
            this.ogdPdt.TabIndex = 0;
            this.ogdPdt.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.ogdPdt.Click += new System.EventHandler(this.odgPdt_Click);
            // 
            // olaSalResTitle
            // 
            this.olaSalResTitle.AutoSize = true;
            this.olaSalResTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaSalResTitle.Location = new System.Drawing.Point(14, 6);
            this.olaSalResTitle.Name = "olaSalResTitle";
            this.olaSalResTitle.Size = new System.Drawing.Size(119, 25);
            this.olaSalResTitle.TabIndex = 4;
            this.olaSalResTitle.Text = "ข้อมูลการขาย";
            // 
            // olaPdtTitle
            // 
            this.olaPdtTitle.AutoSize = true;
            this.olaPdtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaPdtTitle.Location = new System.Drawing.Point(12, 11);
            this.olaPdtTitle.Name = "olaPdtTitle";
            this.olaPdtTitle.Size = new System.Drawing.Size(102, 25);
            this.olaPdtTitle.TabIndex = 5;
            this.olaPdtTitle.Text = "ข้อมูลสินค้า";
            // 
            // olaCstTitle
            // 
            this.olaCstTitle.AutoSize = true;
            this.olaCstTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaCstTitle.Location = new System.Drawing.Point(11, 6);
            this.olaCstTitle.Name = "olaCstTitle";
            this.olaCstTitle.Size = new System.Drawing.Size(99, 25);
            this.olaCstTitle.TabIndex = 6;
            this.olaCstTitle.Text = "ข้อมูลลูกค้า";
            // 
            // ogdCst
            // 
            this.ogdCst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdCst.BackColor = System.Drawing.Color.MistyRose;
            this.ogdCst.ColumnInfo = resources.GetString("ogdCst.ColumnInfo");
            this.ogdCst.Location = new System.Drawing.Point(16, 34);
            this.ogdCst.Name = "ogdCst";
            this.ogdCst.Rows.MaxSize = 25;
            this.ogdCst.Rows.MinSize = 25;
            this.ogdCst.Size = new System.Drawing.Size(644, 151);
            this.ogdCst.StyleInfo = resources.GetString("ogdCst.StyleInfo");
            this.ogdCst.TabIndex = 7;
            this.ogdCst.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.ogdCst.Click += new System.EventHandler(this.odgCst_Click);
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
            // opnPdt
            // 
            this.opnPdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opnPdt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.opnPdt.Controls.Add(this.ogdPdt);
            this.opnPdt.Controls.Add(this.olaPdtTitle);
            this.opnPdt.Location = new System.Drawing.Point(419, 12);
            this.opnPdt.Name = "opnPdt";
            this.opnPdt.Size = new System.Drawing.Size(673, 198);
            this.opnPdt.TabIndex = 27;
            // 
            // opnCst
            // 
            this.opnCst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opnCst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.opnCst.Controls.Add(this.ogdCst);
            this.opnCst.Controls.Add(this.olaCstTitle);
            this.opnCst.Location = new System.Drawing.Point(419, 221);
            this.opnCst.Name = "opnCst";
            this.opnCst.Size = new System.Drawing.Size(673, 197);
            this.opnCst.TabIndex = 28;
            // 
            // opnManSal
            // 
            this.opnManSal.BackColor = System.Drawing.Color.Cornsilk;
            this.opnManSal.Controls.Add(this.ocmClsSal);
            this.opnManSal.Controls.Add(this.ocmEdtSal);
            this.opnManSal.Controls.Add(this.ocmAddSal);
            this.opnManSal.Controls.Add(this.otbSalDate);
            this.opnManSal.Controls.Add(this.otbSalCstCod);
            this.opnManSal.Controls.Add(this.otbSalAmt);
            this.opnManSal.Controls.Add(this.otbSalPri);
            this.opnManSal.Controls.Add(this.otbSalQty);
            this.opnManSal.Controls.Add(this.otbSalPdtCod);
            this.opnManSal.Controls.Add(this.otbSalCod);
            this.opnManSal.Controls.Add(this.olaId);
            this.opnManSal.Controls.Add(this.olaManeSalTitle);
            this.opnManSal.Controls.Add(this.olaSalDate);
            this.opnManSal.Controls.Add(this.olaCstCod);
            this.opnManSal.Controls.Add(this.olaPriAmt);
            this.opnManSal.Controls.Add(this.olaPri);
            this.opnManSal.Controls.Add(this.olaQty);
            this.opnManSal.Controls.Add(this.olaPdtCod);
            this.opnManSal.Controls.Add(this.olaCod);
            this.opnManSal.Location = new System.Drawing.Point(18, 12);
            this.opnManSal.Name = "opnManSal";
            this.opnManSal.Size = new System.Drawing.Size(395, 406);
            this.opnManSal.TabIndex = 29;
            // 
            // ocmClsSal
            // 
            this.ocmClsSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ocmClsSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmClsSal.Location = new System.Drawing.Point(289, 359);
            this.ocmClsSal.Name = "ocmClsSal";
            this.ocmClsSal.Size = new System.Drawing.Size(79, 35);
            this.ocmClsSal.TabIndex = 38;
            this.ocmClsSal.Text = "ล้างข้อมูล";
            this.ocmClsSal.UseVisualStyleBackColor = false;
            this.ocmClsSal.Click += new System.EventHandler(this.ocmClsSal_Click);
            // 
            // ocmEdtSal
            // 
            this.ocmEdtSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ocmEdtSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmEdtSal.Location = new System.Drawing.Point(197, 359);
            this.ocmEdtSal.Name = "ocmEdtSal";
            this.ocmEdtSal.Size = new System.Drawing.Size(79, 35);
            this.ocmEdtSal.TabIndex = 37;
            this.ocmEdtSal.Text = "แก้ไข";
            this.ocmEdtSal.UseVisualStyleBackColor = false;
            this.ocmEdtSal.Click += new System.EventHandler(this.ocmEdtSal_Click);
            // 
            // ocmAddSal
            // 
            this.ocmAddSal.BackColor = System.Drawing.Color.Lime;
            this.ocmAddSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmAddSal.Location = new System.Drawing.Point(106, 359);
            this.ocmAddSal.Name = "ocmAddSal";
            this.ocmAddSal.Size = new System.Drawing.Size(79, 35);
            this.ocmAddSal.TabIndex = 36;
            this.ocmAddSal.Text = "เพิ่ม";
            this.ocmAddSal.UseVisualStyleBackColor = false;
            this.ocmAddSal.Click += new System.EventHandler(this.ocmAddSal_Click);
            // 
            // otbSalDate
            // 
            this.otbSalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalDate.Location = new System.Drawing.Point(106, 310);
            this.otbSalDate.Name = "otbSalDate";
            this.otbSalDate.Size = new System.Drawing.Size(262, 29);
            this.otbSalDate.TabIndex = 35;
            // 
            // otbSalCstCod
            // 
            this.otbSalCstCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalCstCod.Location = new System.Drawing.Point(106, 268);
            this.otbSalCstCod.Name = "otbSalCstCod";
            this.otbSalCstCod.Size = new System.Drawing.Size(262, 29);
            this.otbSalCstCod.TabIndex = 34;
            // 
            // otbSalAmt
            // 
            this.otbSalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalAmt.Location = new System.Drawing.Point(106, 222);
            this.otbSalAmt.Name = "otbSalAmt";
            this.otbSalAmt.Size = new System.Drawing.Size(262, 29);
            this.otbSalAmt.TabIndex = 33;
            // 
            // otbSalPri
            // 
            this.otbSalPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalPri.Location = new System.Drawing.Point(106, 175);
            this.otbSalPri.Name = "otbSalPri";
            this.otbSalPri.Size = new System.Drawing.Size(262, 29);
            this.otbSalPri.TabIndex = 32;
            this.otbSalPri.TextChanged += new System.EventHandler(this.otbSalPri_TextChanged);
            // 
            // otbSalQty
            // 
            this.otbSalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalQty.Location = new System.Drawing.Point(106, 129);
            this.otbSalQty.Name = "otbSalQty";
            this.otbSalQty.Size = new System.Drawing.Size(262, 29);
            this.otbSalQty.TabIndex = 31;
            this.otbSalQty.TextChanged += new System.EventHandler(this.otbSalQty_TextChanged);
            // 
            // otbSalPdtCod
            // 
            this.otbSalPdtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalPdtCod.Location = new System.Drawing.Point(106, 85);
            this.otbSalPdtCod.Name = "otbSalPdtCod";
            this.otbSalPdtCod.Size = new System.Drawing.Size(262, 29);
            this.otbSalPdtCod.TabIndex = 30;
            // 
            // otbSalCod
            // 
            this.otbSalCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otbSalCod.Location = new System.Drawing.Point(106, 40);
            this.otbSalCod.Name = "otbSalCod";
            this.otbSalCod.Size = new System.Drawing.Size(262, 29);
            this.otbSalCod.TabIndex = 29;
            // 
            // olaId
            // 
            this.olaId.AutoSize = true;
            this.olaId.BackColor = System.Drawing.Color.Cornsilk;
            this.olaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaId.ForeColor = System.Drawing.Color.Black;
            this.olaId.Location = new System.Drawing.Point(264, 8);
            this.olaId.Name = "olaId";
            this.olaId.Size = new System.Drawing.Size(49, 24);
            this.olaId.TabIndex = 28;
            this.olaId.Text = "ลำดับ";
            // 
            // olaManeSalTitle
            // 
            this.olaManeSalTitle.AutoSize = true;
            this.olaManeSalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaManeSalTitle.Location = new System.Drawing.Point(7, 8);
            this.olaManeSalTitle.Name = "olaManeSalTitle";
            this.olaManeSalTitle.Size = new System.Drawing.Size(255, 24);
            this.olaManeSalTitle.TabIndex = 27;
            this.olaManeSalTitle.Text = "จัดการข้อมูลการขาย           ลำดับที่";
            // 
            // opnSal
            // 
            this.opnSal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opnSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.opnSal.Controls.Add(this.ocmSalDet);
            this.opnSal.Controls.Add(this.ogdSal);
            this.opnSal.Controls.Add(this.olaSalResTitle);
            this.opnSal.Location = new System.Drawing.Point(18, 427);
            this.opnSal.Name = "opnSal";
            this.opnSal.Size = new System.Drawing.Size(1079, 240);
            this.opnSal.TabIndex = 30;
            // 
            // ocmSalDet
            // 
            this.ocmSalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ocmSalDet.BackColor = System.Drawing.Color.Lime;
            this.ocmSalDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSalDet.Location = new System.Drawing.Point(823, 4);
            this.ocmSalDet.Name = "ocmSalDet";
            this.ocmSalDet.Size = new System.Drawing.Size(237, 32);
            this.ocmSalDet.TabIndex = 39;
            this.ocmSalDet.Text = "รายละเอียดการขาย";
            this.ocmSalDet.UseVisualStyleBackColor = false;
            this.ocmSalDet.Click += new System.EventHandler(this.ocmSalDet_Click);
            // 
            // ogdSal
            // 
            this.ogdSal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdSal.ColumnInfo = resources.GetString("ogdSal.ColumnInfo");
            this.ogdSal.Location = new System.Drawing.Point(13, 41);
            this.ogdSal.Name = "ogdSal";
            this.ogdSal.Rows.MaxSize = 35;
            this.ogdSal.Rows.MinSize = 35;
            this.ogdSal.Size = new System.Drawing.Size(1048, 193);
            this.ogdSal.StyleInfo = resources.GetString("ogdSal.StyleInfo");
            this.ogdSal.TabIndex = 3;
            this.ogdSal.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.ogdSal.Click += new System.EventHandler(this.odgSal_Click);
            // 
            // wWSmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 679);
            this.Controls.Add(this.opnSal);
            this.Controls.Add(this.opnManSal);
            this.Controls.Add(this.opnCst);
            this.Controls.Add(this.opnPdt);
            this.Name = "wWSmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบขายสินค้า";
           // this.Shown += new System.EventHandler(this.wWSmain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ogdPdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogdCst)).EndInit();
            this.opnPdt.ResumeLayout(false);
            this.opnPdt.PerformLayout();
            this.opnCst.ResumeLayout(false);
            this.opnCst.PerformLayout();
            this.opnManSal.ResumeLayout(false);
            this.opnManSal.PerformLayout();
            this.opnSal.ResumeLayout(false);
            this.opnSal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid ogdPdt;
        private System.Windows.Forms.Label olaSalResTitle;
        private System.Windows.Forms.Label olaPdtTitle;
        private System.Windows.Forms.Label olaCstTitle;
        private C1.Win.C1FlexGrid.C1FlexGrid ogdCst;
        private System.Windows.Forms.Label olaPdtCod;
        private System.Windows.Forms.Label olaQty;
        private System.Windows.Forms.Label olaPri;
        private System.Windows.Forms.Label olaPriAmt;
        private System.Windows.Forms.Label olaCstCod;
        private System.Windows.Forms.Label olaSalDate;
        private System.Windows.Forms.Panel opnPdt;
        private System.Windows.Forms.Panel opnCst;
        private System.Windows.Forms.Panel opnManSal;
        private System.Windows.Forms.Label olaManeSalTitle;
        private System.Windows.Forms.Panel opnSal;
        private C1.Win.C1FlexGrid.C1FlexGrid ogdSal;
        private System.Windows.Forms.Label olaId;
        private System.Windows.Forms.Label olaCod;
        private System.Windows.Forms.DateTimePicker otbSalDate;
        private System.Windows.Forms.TextBox otbSalCstCod;
        private System.Windows.Forms.TextBox otbSalAmt;
        private System.Windows.Forms.TextBox otbSalPri;
        private System.Windows.Forms.TextBox otbSalQty;
        private System.Windows.Forms.TextBox otbSalPdtCod;
        private System.Windows.Forms.TextBox otbSalCod;
        private System.Windows.Forms.Button ocmClsSal;
        private System.Windows.Forms.Button ocmEdtSal;
        private System.Windows.Forms.Button ocmAddSal;
        private System.Windows.Forms.Button ocmSalDet;
    }
}

