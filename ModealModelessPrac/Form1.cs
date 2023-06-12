using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModealModelessPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            MessageBox.Show("내용", "제목",MessageBoxButtons.RetryCancel);
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("사용자가 취소하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
