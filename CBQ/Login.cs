using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBQ
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            if (!this.txtValidCode.Text.Equals(_validCode.CheckCode))
            {

                MessageBox.Show(" 请输入正确的验证码!", this.Text);

                this.txtValidCode.Focus();

                return;

            }
            picValidCode.Image = Bitmap.FromStream(ValidCode.CreateCheckCodeImage());

        }


    }
}
