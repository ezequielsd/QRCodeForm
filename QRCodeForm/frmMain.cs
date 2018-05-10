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
            this.Size = new Size(956, 339);
            btnGerar.Location = new Point(814, 264);
        }

        /// <summary>
        /// Evento do botão gerar QRCode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbTipoInformacao.SelectedIndex != 0)
                {
                    var barcodeWriter = new BarcodeWriter();
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    barcodeWriter.Options.Margin = 1;
                    barcodeWriter.Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 300,
                        Height = 300
                    };

                    fileLocalitation = String.Format(@"{0}\{1}.jpg", filePath, txtNomeQRCode.Text);

                    barcodeWriter.Write(FormatarConteudo(cmbTipoInformacao.SelectedIndex)).Save(fileLocalitation, ImageFormat.Jpeg);

                    if (File.Exists(fileLocalitation))
                    {
                        pictureBox1.Size = new Size(300, 300);
                        pictureBox1.ImageLocation = fileLocalitation;
                    }
                }
                else
                    MessageBox.Show($"Selecione um tipo de informação na lista do combo!", "Selecione um tipo de informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar QRCode {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        /// <summary>
        /// Evento do botão para abrir a pasta aonde os arquivos de QRCode estão sendo gravados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbrirLocalizacao_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }

        /// <summary>
        /// Evento do Combobox quando é selecionado um item na lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    btnGerar.Location = new Point(814, 264);
                    break;
                default:
                    break;
            }


            var teste = cmbTipoInformacao.SelectedText;
        }

        /// <summary>
        /// Método formata o tipo de dado e devolve uma string que será gravada no QR.
        /// Esta formatação auxilia os leituros do mobile a identificar e encaminhar a informação para determinada aplicação, como sms, email, chamada, etc.
        /// </summary>
        /// <param name="indexTipo">Valor do index do item selecionado</param>
        /// <returns>Retorna a string formatada conforme o tipo do item selecionado</returns>
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
