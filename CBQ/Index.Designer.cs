namespace CBQ
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_top = new System.Windows.Forms.Panel();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_member = new System.Windows.Forms.Label();
            this.lab_overtime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.lab_overtime);
            this.pan_top.Controls.Add(this.lab_member);
            this.pan_top.Controls.Add(this.lab_type);
            this.pan_top.Controls.Add(this.lab_username);
            this.pan_top.Controls.Add(this.pictureBox1);
            this.pan_top.Location = new System.Drawing.Point(12, 12);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(583, 97);
            this.pan_top.TabIndex = 1;
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(115, 19);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(41, 12);
            this.lab_username.TabIndex = 1;
            this.lab_username.Text = "用户名";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(115, 52);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(41, 12);
            this.lab_type.TabIndex = 2;
            this.lab_type.Text = "类型：";
            // 
            // lab_member
            // 
            this.lab_member.AutoSize = true;
            this.lab_member.Location = new System.Drawing.Point(153, 52);
            this.lab_member.Name = "lab_member";
            this.lab_member.Size = new System.Drawing.Size(29, 12);
            this.lab_member.TabIndex = 3;
            this.lab_member.Text = "会员";
            // 
            // lab_overtime
            // 
            this.lab_overtime.AutoSize = true;
            this.lab_overtime.Location = new System.Drawing.Point(433, 69);
            this.lab_overtime.Name = "lab_overtime";
            this.lab_overtime.Size = new System.Drawing.Size(53, 12);
            this.lab_overtime.TabIndex = 4;
            this.lab_overtime.Text = "到期时间";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 639);
            this.Controls.Add(this.pan_top);
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_top.ResumeLayout(false);
            this.pan_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_member;
        private System.Windows.Forms.Label lab_overtime;
    }
}

