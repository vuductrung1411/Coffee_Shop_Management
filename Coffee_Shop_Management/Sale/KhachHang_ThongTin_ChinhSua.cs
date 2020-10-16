using Coffee_Shop_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale
{
    public partial class KhachHang_ThongTin_ChinhSua : System.Windows.Forms.Form
    {
        public KhachHang_ThongTin_ChinhSua()
        {
            InitializeComponent();
            dtpsinhnhat.Format = DateTimePickerFormat.Custom;
            dtpsinhnhat.CustomFormat = "dd/MM/yyyy";
        }

        private void KhachHang_ThongTin_ChinhSua_Load(object sender, EventArgs e)
        {

        }
    }
}
