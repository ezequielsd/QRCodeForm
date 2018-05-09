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

        private void frmMain_Load(object sender, EventArgs e)
        {
            groupBoxEmail.Visible = false;
            groupBoxURL.Visible = false;
            groupBoxTexto.Visible = false;
            groupBoxSMS.Visible = false;
            groupBoxTelefone.Visible = false;
            groupBoxGeoLocalizacao.Visible = false;
            this.Size = new Size(956, 345);
            btnGerar.Location = new Point(814, 264);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {

                width = 250;
                height = 250;

                var barcodeWriter = new BarcodeWriter();
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options.Margin = 1;
                barcodeWriter.Options = new ZXing.Common.EncodingOptions
                {
                    Width = width,
                    Height = height
                };

                fileLocalitation = String.Format(@"{0}\{1}.jpg", filePath, txtNomeQRCode.Text);

                barcodeWriter.Write(FormatarConteudo(cmbTipoInformacao.SelectedIndex)).Save(fileLocalitation, ImageFormat.Jpeg);

                if (File.Exists(fileLocalitation))
                {
                    pictureBox1.Size = new Size(width, height);
                    pictureBox1.ImageLocation = fileLocalitation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar QRCode {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void btnAbrirLocalizacao_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }


        private void cmbTipoInformacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Index da lista
            //0 = Texto
            //1 = URL
            //2 = E-mail
            //3 = SMS
            //4 = Telefone           
            //5 = Localização Geográfica

            switch (((System.Windows.Forms.ComboBox)sender).SelectedIndex)
            {
                case 0:
                    groupBoxTexto.Visible = true;
                    groupBoxTexto.Location = new Point(304, 142);
                    groupBoxEmail.Visible = false;
                    groupBoxURL.Visible = false;
                    groupBoxSMS.Visible = false;
                    groupBoxTelefone.Visible = false;
                    groupBoxGeoLocalizacao.Visible = false;
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                case 1:
                    groupBoxURL.Visible = true;
                    groupBoxURL.Location = new Point(304, 142);
                    groupBoxTexto.Visible = false;
                    groupBoxEmail.Visible = false;
                    groupBoxSMS.Visible = false;
                    groupBoxTelefone.Visible = false;
                    groupBoxGeoLocalizacao.Visible = false;
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                case 2:
                    groupBoxEmail.Visible = true;
                    groupBoxEmail.Location = new Point(304, 142);
                    groupBoxURL.Visible = false;
                    groupBoxTexto.Visible = false;
                    groupBoxSMS.Visible = false;
                    groupBoxTelefone.Visible = false;
                    groupBoxGeoLocalizacao.Visible = false;
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                case 3:
                    groupBoxSMS.Visible = true;
                    groupBoxSMS.Location = new Point(304, 142);
                    groupBoxEmail.Visible = false;
                    groupBoxURL.Visible = false;
                    groupBoxTexto.Visible = false;
                    groupBoxTelefone.Visible = false;
                    groupBoxGeoLocalizacao.Visible = false;
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                case 4:
                    groupBoxTelefone.Visible = true;
                    groupBoxTelefone.Location = new Point(304, 142);
                    groupBoxSMS.Visible = false;
                    groupBoxEmail.Visible = false;
                    groupBoxURL.Visible = false;
                    groupBoxTexto.Visible = false;
                    groupBoxGeoLocalizacao.Visible = false;
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                case 5:
                    groupBoxGeoLocalizacao.Visible = true;
                    groupBoxGeoLocalizacao.Location = new Point(304, 142);
                    groupBoxTelefone.Visible = false;
                    groupBoxSMS.Visible = false;
                    groupBoxEmail.Visible = false;
                    groupBoxURL.Visible = false;
                    groupBoxTexto.Visible = false;                    
                    this.Size = new Size(956, 345);
                    btnGerar.Location = new Point(814, 264);
                    break;
                default:
                    break;
            }


            var teste = cmbTipoInformacao.SelectedText;
        }

        private string FormatarConteudo(int indexTipo)
        {
            string conteudo = string.Empty;

            //Index da lista
            //0 = Texto
            //1 = URL
            //2 = E-mail
            //3 = SMS
            //4 = Telefone
            //5 = Informação de Contato
            //6 = vCard
            //7 = Localização Geográfica
            switch (indexTipo)
            {
                case 0:
                    conteudo = $"{txtTextoQRCode.Text}";
                    break;
                case 1:
                    if (txtURL.Text.Contains("http://"))
                        conteudo = $"URLTO:{txtURL.Text}";
                    else
                        conteudo = $"URLTO:http://{txtURL.Text}";
                    break;
                case 2:
                    conteudo = $"mailto:{txtEmail.Text}";
                    break;
                case 3:
                    conteudo = $"SMSTO:{txtNumeroCelular.Text}:{txtSMS.Text}";
                    break;
                case 4:
                    conteudo = $"tel:{txtNumeroTelefone.Text}";
                    break;
                case 5:
                    conteudo = $"geo:{txtLatitude.Text.Replace(",",".")},{txtLogitude.Text.Replace(",", ".")},100";
                    break;                
                default:
                    break;
            }


            return conteudo;
        }
    }
}
