
namespace XMLCK
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TBLogin_52 = new System.Windows.Forms.TextBox();
            this.TBPass_52 = new System.Windows.Forms.TextBox();
            this.BT1_52 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label1.Location = new System.Drawing.Point(89, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(441, 33);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "ĐĂNG NHẬP QUẢN TRỊ VIÊN ";
            // 
            // TBLogin_52
            // 
            this.TBLogin_52.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.TBLogin_52.Location = new System.Drawing.Point(226, 128);
            this.TBLogin_52.Margin = new System.Windows.Forms.Padding(6);
            this.TBLogin_52.Name = "TBLogin_52";
            this.TBLogin_52.Size = new System.Drawing.Size(220, 20);
            this.TBLogin_52.TabIndex = 26;
            // 
            // TBPass_52
            // 
            this.TBPass_52.Location = new System.Drawing.Point(226, 175);
            this.TBPass_52.Margin = new System.Windows.Forms.Padding(6);
            this.TBPass_52.Name = "TBPass_52";
            this.TBPass_52.Size = new System.Drawing.Size(220, 20);
            this.TBPass_52.TabIndex = 27;
            // 
            // BT1_52
            // 
            this.BT1_52.Location = new System.Drawing.Point(137, 264);
            this.BT1_52.Margin = new System.Windows.Forms.Padding(6);
            this.BT1_52.Name = "BT1_52";
            this.BT1_52.Size = new System.Drawing.Size(126, 49);
            this.BT1_52.TabIndex = 28;
            this.BT1_52.Text = "Đăng Nhập";
            this.BT1_52.UseVisualStyleBackColor = true;
            this.BT1_52.Click += new System.EventHandler(this.BT1_52_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(226, 229);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(114, 17);
            this.CheckBox1.TabIndex = 31;
            this.CheckBox1.Text = "Hiển thị PassWord";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(340, 264);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(126, 49);
            this.Button1.TabIndex = 32;
            this.Button1.Text = "Thoát";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(133, 134);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Tài Khoản";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(131, 181);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "PassWord";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::XMLCK.Properties.Resources.padlock;
            this.PictureBox2.Location = new System.Drawing.Point(456, 169);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(24, 26);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox2.TabIndex = 30;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::XMLCK.Properties.Resources.user__1_;
            this.PictureBox1.Location = new System.Drawing.Point(456, 122);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(24, 26);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 29;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(2, 0);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(611, 394);
            this.PictureBox3.TabIndex = 37;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 394);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.BT1_52);
            this.Controls.Add(this.TBPass_52);
            this.Controls.Add(this.TBLogin_52);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TBLogin_52;
        internal System.Windows.Forms.TextBox TBPass_52;
        internal System.Windows.Forms.Button BT1_52;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}

