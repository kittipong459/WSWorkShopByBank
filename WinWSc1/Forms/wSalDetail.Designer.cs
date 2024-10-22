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
            this.ogdSalDet = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.otdSchSal = new C1.Win.C1Input.C1TextBox();
            this.ocmSsh = new C1.Win.C1Input.C1Button();
            this.c1PictureBox1 = new C1.Win.C1Input.C1PictureBox();
            this.ocmSetImg = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSetImg)).BeginInit();
            this.SuspendLayout();
            // 
            // ogdSalDet
            // 
            this.ogdSalDet.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.ogdSalDet.Location = new System.Drawing.Point(23, 95);
            this.ogdSalDet.Name = "ogdSalDet";
            this.ogdSalDet.Size = new System.Drawing.Size(729, 306);
            this.ogdSalDet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "รายละเอียดการขาย";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.otdSchSal);
            this.panel1.Controls.Add(this.ocmSsh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ogdSalDet);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
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
            // c1PictureBox1
            // 
            this.c1PictureBox1.Location = new System.Drawing.Point(313, 444);
            this.c1PictureBox1.Name = "c1PictureBox1";
            this.c1PictureBox1.Size = new System.Drawing.Size(193, 106);
            this.c1PictureBox1.TabIndex = 3;
            this.c1PictureBox1.TabStop = false;
            // 
            // ocmSetImg
            // 
            this.ocmSetImg.Location = new System.Drawing.Point(126, 472);
            this.ocmSetImg.Name = "ocmSetImg";
            this.ocmSetImg.Size = new System.Drawing.Size(100, 43);
            this.ocmSetImg.TabIndex = 4;
            this.ocmSetImg.Text = "เลือกรูป";
            this.ocmSetImg.UseVisualStyleBackColor = true;
            this.ocmSetImg.UseVisualStyleForeColor = true;
            this.ocmSetImg.Click += new System.EventHandler(this.ocmSetImg_Click_1);
            // 
            // Wform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.ocmSetImg);
            this.Controls.Add(this.c1PictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Wform2";
            this.Text = "รายละเอียดการขาย";
            ((System.ComponentModel.ISupportInitialize)(this.ogdSalDet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otdSchSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSsh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocmSetImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid ogdSalDet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1TextBox otdSchSal;
        private C1.Win.C1Input.C1Button ocmSsh;
        private C1.Win.C1Input.C1PictureBox c1PictureBox1;
        private C1.Win.C1Input.C1Button ocmSetImg;
    }
}