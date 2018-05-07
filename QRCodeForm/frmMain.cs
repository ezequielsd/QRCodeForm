using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QRCodeForm
{
    public partial class frmMain : Form
    {
        private string filePath = Path.Combine(Environment.CurrentDirectory, "QRCode");
        private string fileLocalitation = String.Empty;
        private int width = 150;
        private int height = 150;

        public frmMain()
        {
            InitializeComponent();

            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtTextoQRCode.Text) && !String.IsNullOrWhiteSpace(txtTextoQRCode.Text))
                {
                    switch (trackBar1.Value)
                    {
                        case 0:
                            width = 150;
                            height = 150;
                            break;
                        case 1:
                            width = 200;
                            height = 200;
                            break;
                        case 2:
                            width = 250;
                            height = 250;
                            break;
                        default:
                            break;
                    }

                    var barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    barcodeWriter.Options = new ZXing.Common.EncodingOptions
                    {
                        Width = width,
                        Height = height
                    };

                    fileLocalitation = String.Format(@"{0}\{1}.jpg", filePath, txtNomeQRCode.Text);

                    barcodeWriter.Write(txtTextoQRCode.Text).Save(fileLocalitation, ImageFormat.Jpeg);
                                        
                    if (File.Exists(fileLocalitation))
                    {
                        pictureBox1.Size = new Size(width, height);
                        pictureBox1.ImageLocation = fileLocalitation;
                    }
                }
                else
                    MessageBox.Show("Informe um texto a ser gravado no QRCode", "Informe um texto!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar QRCode {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            finally
            {
                //txtNomeQRCode.Clear();
                //txtTextoQRCode.Clear();
            }
        }

        private void btnAbrirLocalizacao_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }
    }
}
