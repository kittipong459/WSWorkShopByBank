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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ocmCls = new C1.Win.C1Input.C1Button();
            this.otdSchSal = new C1.Win.C1Input.C1TextBox();
            this.ocmSsh = new C1.Win.C1Input.C1Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ogdSumSal = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.olaBesSalPdtTit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocmCls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSumSal)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdSalDet
            // 
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ocmCls);
            this.panel1.Controls.Add(this.otdSchSal);
            this.panel1.Controls.Add(this.ocmSsh);
            this.panel1.Controls.Add(this.olaSalDetTit);
            this.panel1.Controls.Add(this.ogdSalDet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 289);
            this.panel1.TabIndex = 2;
            // 
            // ocmCls
            // 
            this.ocmCls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ocmCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmCls.Location = new System.Drawing.Point(650, 42);
            this.ocmCls.Name = "ocmCls";
            this.ocmCls.Size = new System.Drawing.Size(102, 34);
            this.ocmCls.TabIndex = 4;
            this.ocmCls.Text = "ล้างข้อมูล";
            this.ocmCls.UseVisualStyleBackColor = false;
            this.ocmCls.UseVisualStyleForeColor = true;
            this.ocmCls.Click += new System.EventHandler(this.ocmCls_Click);
            // 
            // otdSchSal
            // 
            this.otdSchSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.otdSchSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otdSchSal.Location = new System.Drawing.Point(24, 44);
            this.otdSchSal.Name = "otdSchSal";
            this.otdSchSal.Size = new System.Drawing.Size(488, 27);
            this.otdSchSal.TabIndex = 3;
            this.otdSchSal.Tag = null;
            this.otdSchSal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.otdSchSal_KeyUp);
            // 
            // ocmSsh
            // 
            this.ocmSsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ocmSsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmSsh.Location = new System.Drawing.Point(542, 42);
            this.ocmSsh.Name = "ocmSsh";
            this.ocmSsh.Size = new System.Drawing.Size(102, 34);
            this.ocmSsh.TabIndex = 2;
            this.ocmSsh.Text = "ค้นหา";
            this.ocmSsh.UseVisualStyleBackColor = false;
            this.ocmSsh.UseVisualStyleForeColor = true;
            this.ocmSsh.Click += new System.EventHandler(this.ocmSsh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.olaBesSalPdtTit);
            this.panel2.Controls.Add(this.ogdSumSal);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 235);
            this.panel2.TabIndex = 4;
            // 
            // ogdSumSal
            // 
            this.ogdSumSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ogdSumSal.ColumnInfo = resources.GetString("ogdSumSal.ColumnInfo");
            this.ogdSumSal.Location = new System.Drawing.Point(23, 39);
            this.ogdSumSal.Name = "ogdSumSal";
            this.ogdSumSal.Size = new System.Drawing.Size(729, 182);
            this.ogdSumSal.StyleInfo = resources.GetString("ogdSumSal.StyleInfo");
            this.ogdSumSal.TabIndex = 4;
            this.ogdSumSal.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
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
            // Wform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Wform2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายละเอียดการขาย";
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ocmCls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSumSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid ogdSalDet;
        private System.Windows.Forms.Label olaSalDetTit;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1TextBox otdSchSal;
        private C1.Win.C1Input.C1Button ocmSsh;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1FlexGrid.C1FlexGrid ogdSumSal;
        private C1.Win.C1Input.C1Button ocmCls;
        private System.Windows.Forms.Label olaBesSalPdtTit;
    }
}