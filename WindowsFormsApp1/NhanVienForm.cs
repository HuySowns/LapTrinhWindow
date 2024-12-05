using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NhanVienForm : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }

        public NhanVienForm()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MSNV = txt_MSNV.Text;
            TenNV = txt_TenNV.Text;
            LuongCB = decimal.Parse(txt_LuongCB.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
