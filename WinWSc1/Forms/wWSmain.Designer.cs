﻿namespace WindowsFormsApp1
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
            this.odgPdt = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.odgSal = new C1.Win.C1FlexGrid.C1FlexGrid();
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
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.c1Button2 = new C1.Win.C1Input.C1Button();
            this.c1Button3 = new C1.Win.C1Input.C1Button();
            this.c1Button4 = new C1.Win.C1Input.C1Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.odgPdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgCst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPdtCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCstCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // odgPdt
            // 
            this.odgPdt.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.odgPdt.Location = new System.Drawing.Point(17, 39);
            this.odgPdt.Name = "odgPdt";
            this.odgPdt.Size = new System.Drawing.Size(643, 148);
            this.odgPdt.TabIndex = 0;
            // 
            // odgSal
            // 
            this.odgSal.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.odgSal.Location = new System.Drawing.Point(12, 455);
            this.odgSal.Name = "odgSal";
            this.odgSal.Size = new System.Drawing.Size(1030, 212);
            this.odgSal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(13, 427);
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
            this.odgCst.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.odgCst.Location = new System.Drawing.Point(16, 34);
            this.odgCst.Name = "odgCst";
            this.odgCst.Size = new System.Drawing.Size(644, 151);
            this.odgCst.TabIndex = 7;
            // 
            // otbSalCod
            // 
            this.otbSalCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalCod.Location = new System.Drawing.Point(104, 40);
            this.otbSalCod.Name = "otbSalCod";
            this.otbSalCod.Size = new System.Drawing.Size(353, 29);
            this.otbSalCod.TabIndex = 8;
            this.otbSalCod.Tag = null;
            // 
            // otbSalPdtCod
            // 
            this.otbSalPdtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalPdtCod.Location = new System.Drawing.Point(104, 87);
            this.otbSalPdtCod.Name = "otbSalPdtCod";
            this.otbSalPdtCod.Size = new System.Drawing.Size(353, 29);
            this.otbSalPdtCod.TabIndex = 9;
            this.otbSalPdtCod.Tag = null;
            this.otbSalPdtCod.TextChanged += new System.EventHandler(this.c1TextBox2_TextChanged);
            // 
            // otbSalQty
            // 
            this.otbSalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalQty.Location = new System.Drawing.Point(104, 136);
            this.otbSalQty.Name = "otbSalQty";
            this.otbSalQty.Size = new System.Drawing.Size(353, 29);
            this.otbSalQty.TabIndex = 10;
            this.otbSalQty.Tag = null;
            this.otbSalQty.TextChanged += new System.EventHandler(this.otbSalQty_TextChanged);
            // 
            // otbSalPri
            // 
            this.otbSalPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalPri.Location = new System.Drawing.Point(104, 188);
            this.otbSalPri.Name = "otbSalPri";
            this.otbSalPri.Size = new System.Drawing.Size(353, 29);
            this.otbSalPri.TabIndex = 11;
            this.otbSalPri.Tag = null;
            this.otbSalPri.TextChanged += new System.EventHandler(this.otbSalPri_TextChanged);
            // 
            // otbSalAmt
            // 
            this.otbSalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalAmt.Location = new System.Drawing.Point(104, 239);
            this.otbSalAmt.Name = "otbSalAmt";
            this.otbSalAmt.Size = new System.Drawing.Size(353, 29);
            this.otbSalAmt.TabIndex = 12;
            this.otbSalAmt.Tag = null;
            this.otbSalAmt.TextChanged += new System.EventHandler(this.otbSalAmt_TextChanged);
            // 
            // otbSalCstCod
            // 
            this.otbSalCstCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otbSalCstCod.Location = new System.Drawing.Point(104, 286);
            this.otbSalCstCod.Name = "otbSalCstCod";
            this.otbSalCstCod.Size = new System.Drawing.Size(353, 29);
            this.otbSalCstCod.TabIndex = 13;
            this.otbSalCstCod.Tag = null;
            this.otbSalCstCod.TextChanged += new System.EventHandler(this.c1TextBox6_TextChanged);
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
            this.otbSalDate.Location = new System.Drawing.Point(104, 337);
            this.otbSalDate.Name = "otbSalDate";
            this.otbSalDate.Size = new System.Drawing.Size(353, 27);
            this.otbSalDate.TabIndex = 14;
            this.otbSalDate.Tag = null;
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1Button1.Location = new System.Drawing.Point(58, 383);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(89, 35);
            this.c1Button1.TabIndex = 16;
            this.c1Button1.Text = "เพิ่ม";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.UseVisualStyleForeColor = true;
            this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "รหัสขาย";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "รหัสสินค้า";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(18, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "จำนวน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(18, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "ราคา";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(18, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "ราคารวม";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(18, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "รหัสลูกค้า";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(18, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "วันที่ขาย";
            // 
            // c1Button2
            // 
            this.c1Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1Button2.Location = new System.Drawing.Point(162, 383);
            this.c1Button2.Name = "c1Button2";
            this.c1Button2.Size = new System.Drawing.Size(89, 35);
            this.c1Button2.TabIndex = 24;
            this.c1Button2.Text = "แก้ไข";
            this.c1Button2.UseVisualStyleBackColor = true;
            this.c1Button2.UseVisualStyleForeColor = true;
            this.c1Button2.Click += new System.EventHandler(this.c1Button2_Click);
            // 
            // c1Button3
            // 
            this.c1Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1Button3.Location = new System.Drawing.Point(266, 383);
            this.c1Button3.Name = "c1Button3";
            this.c1Button3.Size = new System.Drawing.Size(89, 35);
            this.c1Button3.TabIndex = 25;
            this.c1Button3.Text = "ลบ";
            this.c1Button3.UseVisualStyleBackColor = true;
            this.c1Button3.UseVisualStyleForeColor = true;
            // 
            // c1Button4
            // 
            this.c1Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1Button4.Location = new System.Drawing.Point(370, 383);
            this.c1Button4.Name = "c1Button4";
            this.c1Button4.Size = new System.Drawing.Size(89, 35);
            this.c1Button4.TabIndex = 26;
            this.c1Button4.Text = "ล้างข้อมูล";
            this.c1Button4.UseVisualStyleBackColor = true;
            this.c1Button4.UseVisualStyleForeColor = true;
            this.c1Button4.Click += new System.EventHandler(this.c1Button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.odgPdt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(478, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 198);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.odgCst);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(478, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 197);
            this.panel2.TabIndex = 28;
            // 
            // wWSmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c1Button4);
            this.Controls.Add(this.c1Button3);
            this.Controls.Add(this.c1Button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c1Button1);
            this.Controls.Add(this.otbSalDate);
            this.Controls.Add(this.otbSalCstCod);
            this.Controls.Add(this.otbSalAmt);
            this.Controls.Add(this.otbSalPri);
            this.Controls.Add(this.otbSalQty);
            this.Controls.Add(this.otbSalPdtCod);
            this.Controls.Add(this.otbSalCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odgSal);
            this.Name = "wWSmain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.wWSmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odgPdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odgCst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPdtCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalPri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalCstCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otbSalDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid odgPdt;
        private C1.Win.C1FlexGrid.C1FlexGrid odgSal;
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
        private C1.Win.C1Input.C1Button c1Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1Input.C1Button c1Button2;
        private C1.Win.C1Input.C1Button c1Button3;
        private C1.Win.C1Input.C1Button c1Button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

