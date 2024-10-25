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
            this.otdSchSal = new C1.Win.C1Input.C1TextBox();
            this.ocmSsh = new C1.Win.C1Input.C1Button();
            this.olaBesSalPdtTit = new C1.Win.C1Input.C1Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ogdSumSal = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olaBesSalPdtTit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSumSal)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdSalDet
            // 
            this.ogdSalDet.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.ogdSalDet.Location = new System.Drawing.Point(23, 95);
            this.ogdSalDet.Name = "ogdSalDet";
            this.ogdSalDet.Size = new System.Drawing.Size(729, 176);
            this.ogdSalDet.StyleInfo = resources.GetString("ogdSalDet.StyleInfo");
            this.ogdSalDet.TabIndex = 0;
            this.ogdSalDet.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
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
            this.panel1.Controls.Add(this.otdSchSal);
            this.panel1.Controls.Add(this.ocmSsh);
            this.panel1.Controls.Add(this.olaSalDetTit);
            this.panel1.Controls.Add(this.ogdSalDet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 289);
            this.panel1.TabIndex = 2;
            // 
            // otdSchSal
            // 
            this.otdSchSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otdSchSal.Location = new System.Drawing.Point(34, 44);
            this.otdSchSal.Name = "otdSchSal";
            this.otdSchSal.Size = new System.Drawing.Size(597, 27);
            this.otdSchSal.TabIndex = 3;
            this.otdSchSal.Tag = null;
            // 
            // ocmSsh
            // 
            this.ocmSsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ocmSsh.Location = new System.Drawing.Point(650, 42);
            this.ocmSsh.Name = "ocmSsh";
            this.ocmSsh.Size = new System.Drawing.Size(102, 34);
            this.ocmSsh.TabIndex = 2;
            this.ocmSsh.Text = "ค้นหา";
            this.ocmSsh.UseVisualStyleBackColor = true;
            this.ocmSsh.UseVisualStyleForeColor = true;
            this.ocmSsh.Click += new System.EventHandler(this.ocmSsh_Click);
            // 
            // olaBesSalPdtTit
            // 
            this.olaBesSalPdtTit.AutoSize = true;
            this.olaBesSalPdtTit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olaBesSalPdtTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaBesSalPdtTit.Location = new System.Drawing.Point(23, 10);
            this.olaBesSalPdtTit.Name = "olaBesSalPdtTit";
            this.olaBesSalPdtTit.Size = new System.Drawing.Size(111, 25);
            this.olaBesSalPdtTit.TabIndex = 3;
            this.olaBesSalPdtTit.Tag = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ogdSumSal);
            this.panel2.Controls.Add(this.olaBesSalPdtTit);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 235);
            this.panel2.TabIndex = 4;
            // 
            // ogdSumSal
            // 
            this.ogdSumSal.ColumnInfo = "10,1,0,0,0,-1,Columns:";
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Wform2";
            this.Text = "รายละเอียดการขาย";
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olaBesSalPdtTit)).EndInit();
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
        private C1.Win.C1Input.C1Label olaBesSalPdtTit;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1FlexGrid.C1FlexGrid ogdSumSal;
    }
}