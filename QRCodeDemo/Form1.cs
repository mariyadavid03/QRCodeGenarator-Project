using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(txtText.Text == "")
            {
                MessageBox.Show("Enter Valid Text");
                return;
            }
            QRCodeGenerator qRCode = new QRCodeGenerator();
            QRCodeData codeData = qRCode.CreateQrCode(txtText.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qR = new QRCode(codeData);
            pic.Image = qR.GetGraphic(5);
        }

    }
}
