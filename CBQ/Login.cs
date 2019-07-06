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

            //if (!this.txtValidCode.Text.Equals(_validCode.CheckCode))
            //{

            //    MessageBox.Show(" 请输入正确的验证码!", this.Text);

            //    this.txtValidCode.Focus();

            //    return;

            //}
            //picValidCode.Image = Bitmap.FromStream(ValidCode.CreateCheckCodeImage());

        }

        /// <summary>
        /// 简单冒泡排序
        /// </summary>
        /// <param name="array"></param>
        static void BubbleSortSort(int[] array)
        {
            #region 简单参数检查
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (array.Length <= 0)
            {
                throw new IndexOutOfRangeException("array");
            }
            #endregion
            int length = array.Length;//数组长度
            int tmp; //临时变量用于交换位置
            for (int i = 0; i < length; i++) //外层循环N次
            {
                for (int j = 0; j < length - 1; j++)//完成一次完整的相邻元素比较 N-1次
                {
                    if (array[j] > array[j + 1])//比较大小
                    {
                        //交换位置
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

    }
}
