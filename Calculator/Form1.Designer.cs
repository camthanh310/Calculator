namespace Calculator
{
    partial class Form1
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(101, 12);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 20);
            this.txtSoA.TabIndex = 0;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(35, 116);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(44, 34);
            this.btnCong.TabIndex = 1;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số B";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(101, 47);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 20);
            this.txtSoB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "KQ";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(101, 73);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(101, 116);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(44, 34);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(157, 116);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(44, 34);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(212, 116);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(44, 34);
            this.btnChia.TabIndex = 9;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

