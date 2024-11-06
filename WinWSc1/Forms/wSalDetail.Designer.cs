namespace WindowsFormsApp1
{
    partial class Wform2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wform2));
            this.ogdSalDet = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.olaSalDetTit = new System.Windows.Forms.Label();
            this.opnSalDet = new System.Windows.Forms.Panel();
            this.ocmCls = new System.Windows.Forms.Button();
            this.ocmSsh = new System.Windows.Forms.Button();
            this.otdSchSal = new System.Windows.Forms.TextBox();
            this.opnBestSal = new System.Windows.Forms.Panel();
            this.olaBesSalPdtTit = new System.Windows.Forms.Label();
            this.ogdSumSal = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).BeginInit();
            this.opnSalDet.SuspendLayout();
            this.opnBestSal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSumSal)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdSalDet
            // 
            this.ogdSalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdSalDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ogdSalDet.ColumnInfo = resources.GetString("ogdSalDet.ColumnInfo");
            this.ogdSalDet.Location = new System.Drawing.Point(23, 82);
            this.ogdSalDet.Name = "ogdSalDet";
            this.ogdSalDet.Size = new System.Drawing.Size(729, 189);
            this.ogdSalDet.StyleInfo = resources.GetString("ogdSalDet.StyleInfo");
            this.ogdSalDet.TabIndex = 0;
            this.ogdSalDet.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.ogdSalDet.Click += new System.EventHandler(this.ogdSalDet_Click);
            // 
            // olaSalDetTit
            // 
            this.olaSalDetTit.AutoSize = true;
            this.olaSalDetTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaSalDetTit.Location = new System.Drawing.Point(19, 9);
            this.olaSalDetTit.Name = "olaSalDetTit";
            this.olaSalDetTit.Size = new System.Drawing.Size(143, 24);
            this.olaSalDetTit.TabIndex = 1;
            this.olaSalDetTit.Text = "รายละเอียดการขาย";
            // 
            // opnSalDet
            // 
            this.opnSalDet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opnSalDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.opnSalDet.Controls.Add(this.ocmCls);
            this.opnSalDet.Controls.Add(this.ocmSsh);
            this.opnSalDet.Controls.Add(this.otdSchSal);
            this.opnSalDet.Controls.Add(this.olaSalDetTit);
            this.opnSalDet.Controls.Add(this.ogdSalDet);
            this.opnSalDet.Location = new System.Drawing.Point(12, 12);
            this.opnSalDet.Name = "opnSalDet";
            this.opnSalDet.Size = new System.Drawing.Size(776, 289);
            this.opnSalDet.TabIndex = 2;
            // 
            // ocmCls
            // 
            this.ocmCls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ocmCls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ocmCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmCls.Location = new System.Drawing.Point(654, 43);
            this.ocmCls.Name = "ocmCls";
            this.ocmCls.Size = new System.Drawing.Size(98, 32);
            this.ocmCls.TabIndex = 7;
            this.ocmCls.Text = "ล้างข้อมูล";
            this.ocmCls.UseVisualStyleBackColor = false;
            this.ocmCls.Click += new System.EventHandler(this.ocmCls_Click);
            // 
            // ocmSsh
            // 
            this.ocmSsh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ocmSsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ocmSsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocmSsh.Location = new System.Drawing.Point(550, 44);
            this.ocmSsh.Name = "ocmSsh";
            this.ocmSsh.Size = new System.Drawing.Size(98, 32);
            this.ocmSsh.TabIndex = 6;
            this.ocmSsh.Text = "ค้นหา";
            this.ocmSsh.UseVisualStyleBackColor = false;
            this.ocmSsh.Click += new System.EventHandler(this.ocmSsh_Click);
            // 
            // otdSchSal
            // 
            this.otdSchSal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otdSchSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otdSchSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otdSchSal.Location = new System.Drawing.Point(24, 44);
            this.otdSchSal.Name = "otdSchSal";
            this.otdSchSal.Size = new System.Drawing.Size(502, 29);
            this.otdSchSal.TabIndex = 5;
            this.otdSchSal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.otdSchSal_KeyUp);
            // 
            // opnBestSal
            // 
            this.opnBestSal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opnBestSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.opnBestSal.Controls.Add(this.olaBesSalPdtTit);
            this.opnBestSal.Controls.Add(this.ogdSumSal);
            this.opnBestSal.Location = new System.Drawing.Point(12, 307);
            this.opnBestSal.Name = "opnBestSal";
            this.opnBestSal.Size = new System.Drawing.Size(776, 235);
            this.opnBestSal.TabIndex = 4;
            // 
            // olaBesSalPdtTit
            // 
            this.olaBesSalPdtTit.AutoSize = true;
            this.olaBesSalPdtTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaBesSalPdtTit.Location = new System.Drawing.Point(20, 9);
            this.olaBesSalPdtTit.Name = "olaBesSalPdtTit";
            this.olaBesSalPdtTit.Size = new System.Drawing.Size(170, 24);
            this.olaBesSalPdtTit.TabIndex = 5;
            this.olaBesSalPdtTit.Text = "สรุปรายการสินค้าขายดี";
            // 
            // ogdSumSal
            // 
            this.ogdSumSal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdSumSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ogdSumSal.ColumnInfo = resources.GetString("ogdSumSal.ColumnInfo");
            this.ogdSumSal.Location = new System.Drawing.Point(23, 39);
            this.ogdSumSal.Name = "ogdSumSal";
            this.ogdSumSal.Size = new System.Drawing.Size(729, 182);
            this.ogdSumSal.StyleInfo = resources.GetString("ogdSumSal.StyleInfo");
            this.ogdSumSal.TabIndex = 4;
            this.ogdSumSal.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // Wform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.opnBestSal);
            this.Controls.Add(this.opnSalDet);
            this.Name = "Wform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายละเอียดการขาย";
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).EndInit();
            this.opnSalDet.ResumeLayout(false);
            this.opnSalDet.PerformLayout();
            this.opnBestSal.ResumeLayout(false);
            this.opnBestSal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSumSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid ogdSalDet;
        private System.Windows.Forms.Label olaSalDetTit;
        private System.Windows.Forms.Panel opnSalDet;
        private System.Windows.Forms.Panel opnBestSal;
        private C1.Win.C1FlexGrid.C1FlexGrid ogdSumSal;
        private System.Windows.Forms.Label olaBesSalPdtTit;
        private System.Windows.Forms.TextBox otdSchSal;
        private System.Windows.Forms.Button ocmSsh;
        private System.Windows.Forms.Button ocmCls;
    }
}