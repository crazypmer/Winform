using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var code = txtMachineCode.Text;
            var reg = new SoftReg().getRNum(code);
            if (reg == txtRegistCode.Text)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("机器码错误");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var code = new SoftReg().getMNum();

            txtMachineCode.Text = code;
        }

        private void lbCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtMachineCode.Text);
            MessageBox.Show("复制成功");
        }
    }
}
