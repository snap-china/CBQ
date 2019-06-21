namespace CBQ
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.Eamil_Tel = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Captcha = new System.Windows.Forms.Label();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eamil_Tel
            // 
            this.Eamil_Tel.AutoSize = true;
            this.Eamil_Tel.Location = new System.Drawing.Point(95, 169);
            this.Eamil_Tel.Name = "Eamil_Tel";
            this.Eamil_Tel.Size = new System.Drawing.Size(53, 12);
            this.Eamil_Tel.TabIndex = 0;
            this.Eamil_Tel.Text = "用户名：";
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(95, 208);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(41, 12);
            this.Pwd.TabIndex = 0;
            this.Pwd.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 21);
            this.textBox2.TabIndex = 1;
            // 
            // Captcha
            // 
            this.Captcha.AutoSize = true;
            this.Captcha.Location = new System.Drawing.Point(95, 248);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(77, 12);
            this.Captcha.TabIndex = 0;
            this.Captcha.Text = "输入验证码：";
            // 
            // txtValidCode
            // 
            this.txtValidCode.Location = new System.Drawing.Point(170, 245);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(82, 21);
            this.txtValidCode.TabIndex = 2;
            // 
            // picValidCode
            // 
            this.picValidCode.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.picValidCode.ImageSize = new System.Drawing.Size(16, 16);
            this.picValidCode.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Eamil_Tel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Eamil_Tel;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Captcha;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.ImageList picValidCode;
        private System.Windows.Forms.Button button1;
    }
}