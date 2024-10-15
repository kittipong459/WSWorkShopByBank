namespace WindowsFormsApp1
{
    partial class wSalDetail
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
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1Button1 = new C1.Win.C1Input.C1Button();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(23, 95);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(729, 306);
            this.c1FlexGrid1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.c1TextBox1);
            this.panel1.Controls.Add(this.c1Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.c1FlexGrid1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 2;
            // 
            // c1Button1
            // 
            this.c1Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1Button1.Location = new System.Drawing.Point(650, 42);
            this.c1Button1.Name = "c1Button1";
            this.c1Button1.Size = new System.Drawing.Size(102, 34);
            this.c1Button1.TabIndex = 2;
            this.c1Button1.Text = "ค้นหา";
            this.c1Button1.UseVisualStyleBackColor = true;
            this.c1Button1.UseVisualStyleForeColor = true;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.c1TextBox1.Location = new System.Drawing.Point(34, 44);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(597, 27);
            this.c1TextBox1.TabIndex = 3;
            this.c1TextBox1.Tag = null;
            // 
            // wSalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "wSalDetail";
            this.Text = "wSalDetail";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1Button c1Button1;
    }
}