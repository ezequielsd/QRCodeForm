namespace QRCodeForm
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtTextoQRCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNomeQRCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirLocalizacao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTexto = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxURL = new System.Windows.Forms.GroupBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbTipoInformacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBoxSMS = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroCelular = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.groupBoxTelefone = new System.Windows.Forms.GroupBox();
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.groupBoxGeoLocalizacao = new System.Windows.Forms.GroupBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLogitude = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTexto.SuspendLayout();
            this.groupBoxURL.SuspendLayout();
            this.groupBoxEmail.SuspendLayout();
            this.groupBoxSMS.SuspendLayout();
            this.groupBoxTelefone.SuspendLayout();
            this.groupBoxGeoLocalizacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(814, 264);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(119, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar QRCode";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtTextoQRCode
            // 
            this.txtTextoQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoQRCode.Location = new System.Drawing.Point(21, 31);
            this.txtTextoQRCode.Name = "txtTextoQRCode";
            this.txtTextoQRCode.Size = new System.Drawing.Size(585, 22);
            this.txtTextoQRCode.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNomeQRCode
            // 
            this.txtNomeQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeQRCode.Location = new System.Drawing.Point(21, 30);
            this.txtNomeQRCode.Name = "txtNomeQRCode";
            this.txtNomeQRCode.Size = new System.Drawing.Size(304, 22);
            this.txtNomeQRCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gerador de QRCode";
            // 
            // btnAbrirLocalizacao
            // 
            this.btnAbrirLocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirLocalizacao.Location = new System.Drawing.Point(168, 277);
            this.btnAbrirLocalizacao.Name = "btnAbrirLocalizacao";
            this.btnAbrirLocalizacao.Size = new System.Drawing.Size(119, 23);
            this.btnAbrirLocalizacao.TabIndex = 7;
            this.btnAbrirLocalizacao.Text = "Abrir localização";
            this.btnAbrirLocalizacao.UseVisualStyleBackColor = true;
            this.btnAbrirLocalizacao.Click += new System.EventHandler(this.btnAbrirLocalizacao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeQRCode);
            this.groupBox1.Location = new System.Drawing.Point(304, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome para salvar o arquivo do QRCode a ser gerado";
            // 
            // groupBoxTexto
            // 
            this.groupBoxTexto.Controls.Add(this.txtTextoQRCode);
            this.groupBoxTexto.Location = new System.Drawing.Point(304, 142);
            this.groupBoxTexto.Name = "groupBoxTexto";
            this.groupBoxTexto.Size = new System.Drawing.Size(629, 70);
            this.groupBoxTexto.TabIndex = 14;
            this.groupBoxTexto.TabStop = false;
            this.groupBoxTexto.Text = "Texto a ser gravado no QRCode";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(277, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 247);
            this.panel1.TabIndex = 15;
            // 
            // groupBoxURL
            // 
            this.groupBoxURL.Controls.Add(this.txtURL);
            this.groupBoxURL.Location = new System.Drawing.Point(304, 217);
            this.groupBoxURL.Name = "groupBoxURL";
            this.groupBoxURL.Size = new System.Drawing.Size(487, 70);
            this.groupBoxURL.TabIndex = 15;
            this.groupBoxURL.TabStop = false;
            this.groupBoxURL.Text = "Informe a URL";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(21, 31);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(455, 22);
            this.txtURL.TabIndex = 2;
            // 
            // cmbTipoInformacao
            // 
            this.cmbTipoInformacao.BackColor = System.Drawing.Color.White;
            this.cmbTipoInformacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInformacao.FormattingEnabled = true;
            this.cmbTipoInformacao.Items.AddRange(new object[] {
            "Texto",
            "URL",
            "E-mail",
            "SMS",
            "Telefone",
            "Localização Geográfica"});
            this.cmbTipoInformacao.Location = new System.Drawing.Point(703, 63);
            this.cmbTipoInformacao.Name = "cmbTipoInformacao";
            this.cmbTipoInformacao.Size = new System.Drawing.Size(184, 21);
            this.cmbTipoInformacao.TabIndex = 16;
            this.cmbTipoInformacao.SelectedIndexChanged += new System.EventHandler(this.cmbTipoInformacao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selecione o tipo de informação";
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.txtEmail);
            this.groupBoxEmail.Location = new System.Drawing.Point(304, 290);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Size = new System.Drawing.Size(487, 70);
            this.groupBoxEmail.TabIndex = 16;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Informe o Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(21, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(455, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // groupBoxSMS
            // 
            this.groupBoxSMS.Controls.Add(this.label5);
            this.groupBoxSMS.Controls.Add(this.label4);
            this.groupBoxSMS.Controls.Add(this.txtNumeroCelular);
            this.groupBoxSMS.Controls.Add(this.label2);
            this.groupBoxSMS.Controls.Add(this.txtSMS);
            this.groupBoxSMS.Location = new System.Drawing.Point(304, 375);
            this.groupBoxSMS.Name = "groupBoxSMS";
            this.groupBoxSMS.Size = new System.Drawing.Size(487, 146);
            this.groupBoxSMS.TabIndex = 17;
            this.groupBoxSMS.TabStop = false;
            this.groupBoxSMS.Text = "SMS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(117, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sem separação e apenas numeros com código de área.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Numero do celular";
            // 
            // txtNumeroCelular
            // 
            this.txtNumeroCelular.Location = new System.Drawing.Point(21, 37);
            this.txtNumeroCelular.Name = "txtNumeroCelular";
            this.txtNumeroCelular.Size = new System.Drawing.Size(90, 20);
            this.txtNumeroCelular.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Texto do SMS";
            // 
            // txtSMS
            // 
            this.txtSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMS.Location = new System.Drawing.Point(21, 81);
            this.txtSMS.Multiline = true;
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(455, 54);
            this.txtSMS.TabIndex = 2;
            // 
            // groupBoxTelefone
            // 
            this.groupBoxTelefone.Controls.Add(this.txtNumeroTelefone);
            this.groupBoxTelefone.Location = new System.Drawing.Point(304, 527);
            this.groupBoxTelefone.Name = "groupBoxTelefone";
            this.groupBoxTelefone.Size = new System.Drawing.Size(237, 70);
            this.groupBoxTelefone.TabIndex = 17;
            this.groupBoxTelefone.TabStop = false;
            this.groupBoxTelefone.Text = "Informe o numero do telefone ou celular";
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTelefone.Location = new System.Drawing.Point(21, 31);
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroTelefone.TabIndex = 2;
            // 
            // groupBoxGeoLocalizacao
            // 
            this.groupBoxGeoLocalizacao.Controls.Add(this.label8);
            this.groupBoxGeoLocalizacao.Controls.Add(this.label7);
            this.groupBoxGeoLocalizacao.Controls.Add(this.label6);
            this.groupBoxGeoLocalizacao.Controls.Add(this.txtLogitude);
            this.groupBoxGeoLocalizacao.Controls.Add(this.txtLatitude);
            this.groupBoxGeoLocalizacao.Location = new System.Drawing.Point(797, 293);
            this.groupBoxGeoLocalizacao.Name = "groupBoxGeoLocalizacao";
            this.groupBoxGeoLocalizacao.Size = new System.Drawing.Size(394, 70);
            this.groupBoxGeoLocalizacao.TabIndex = 17;
            this.groupBoxGeoLocalizacao.TabStop = false;
            this.groupBoxGeoLocalizacao.Text = "GeoLocalização: Informe os pontos";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(54, 35);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(123, 22);
            this.txtLatitude.TabIndex = 2;
            // 
            // txtLogitude
            // 
            this.txtLogitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogitude.Location = new System.Drawing.Point(255, 36);
            this.txtLogitude.Name = "txtLogitude";
            this.txtLogitude.Size = new System.Drawing.Size(123, 22);
            this.txtLogitude.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Latitude:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Longitude:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(206, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Exemplo:  -26.299912, -48.833053";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 664);
            this.Controls.Add(this.groupBoxGeoLocalizacao);
            this.Controls.Add(this.groupBoxTelefone);
            this.Controls.Add(this.groupBoxSMS);
            this.Controls.Add(this.groupBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoInformacao);
            this.Controls.Add(this.groupBoxURL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxTexto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirLocalizacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTexto.ResumeLayout(false);
            this.groupBoxTexto.PerformLayout();
            this.groupBoxURL.ResumeLayout(false);
            this.groupBoxURL.PerformLayout();
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.groupBoxSMS.ResumeLayout(false);
            this.groupBoxSMS.PerformLayout();
            this.groupBoxTelefone.ResumeLayout(false);
            this.groupBoxTelefone.PerformLayout();
            this.groupBoxGeoLocalizacao.ResumeLayout(false);
            this.groupBoxGeoLocalizacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtTextoQRCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomeQRCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbrirLocalizacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxTexto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cmbTipoInformacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBoxSMS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtNumeroCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTelefone;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.GroupBox groupBoxGeoLocalizacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogitude;
        private System.Windows.Forms.TextBox txtLatitude;
    }
}

