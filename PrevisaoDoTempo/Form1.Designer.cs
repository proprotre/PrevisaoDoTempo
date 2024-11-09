namespace PrevisaoDoTempo
{
    partial class PrevisaoDoTempo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrevisaoDoTempo));
            pbPlanoDeFundo = new PictureBox();
            btnConsultar = new Button();
            rtbRetorno = new RichTextBox();
            cbCidades = new ComboBox();
            lbCidades = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPlanoDeFundo).BeginInit();
            SuspendLayout();
            // 
            // pbPlanoDeFundo
            // 
            pbPlanoDeFundo.Dock = DockStyle.Fill;
            pbPlanoDeFundo.Image = (Image)resources.GetObject("pbPlanoDeFundo.Image");
            pbPlanoDeFundo.Location = new Point(0, 0);
            pbPlanoDeFundo.Name = "pbPlanoDeFundo";
            pbPlanoDeFundo.Size = new Size(800, 450);
            pbPlanoDeFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlanoDeFundo.TabIndex = 0;
            pbPlanoDeFundo.TabStop = false;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top;
            btnConsultar.BackColor = Color.Blue;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.Window;
            btnConsultar.Location = new Point(302, 110);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(205, 51);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // rtbRetorno
            // 
            rtbRetorno.Anchor = AnchorStyles.Top;
            rtbRetorno.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbRetorno.Location = new Point(151, 181);
            rtbRetorno.Name = "rtbRetorno";
            rtbRetorno.Size = new Size(502, 257);
            rtbRetorno.TabIndex = 2;
            rtbRetorno.Text = "";
            // 
            // cbCidades
            // 
            cbCidades.Anchor = AnchorStyles.Top;
            cbCidades.Cursor = Cursors.Hand;
            cbCidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidades.FlatStyle = FlatStyle.Popup;
            cbCidades.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCidades.FormattingEnabled = true;
            cbCidades.Items.AddRange(new object[] { "Presidente Prudente - SP", "Maceió - AL", "Macapá - AP", "Manaus - AM", "Salvador - BA", "Fortaleza - CE", "Brasília - DF", "Vitória - ES", "Goiânia - GO", "São Luís - MA", "Cuiabá - MT", "Campo Grande - MS", "Belo Horizonte - MG", "Belém - PA", "João Pessoa - PB", "Curitiba - PR", "Recife - PE", "Teresina - PI", "Rio de Janeiro - RJ", "Natal - RN", "Porto Alegre - RS", "Porto Velho - RO", "Boa Vista - RR", "Florianópolis - SC", "São Paulo - SP", "Aracaju - SE", "Palmas - TO" });
            cbCidades.Location = new Point(232, 70);
            cbCidades.Name = "cbCidades";
            cbCidades.Size = new Size(336, 27);
            cbCidades.TabIndex = 0;
            // 
            // lbCidades
            // 
            lbCidades.Anchor = AnchorStyles.Top;
            lbCidades.AutoSize = true;
            lbCidades.BackColor = Color.Lavender;
            lbCidades.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCidades.ForeColor = SystemColors.Desktop;
            lbCidades.Location = new Point(247, 19);
            lbCidades.Name = "lbCidades";
            lbCidades.Size = new Size(289, 32);
            lbCidades.TabIndex = 4;
            lbCidades.Text = "Selecione uma cidade";
            lbCidades.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PrevisaoDoTempo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCidades);
            Controls.Add(cbCidades);
            Controls.Add(rtbRetorno);
            Controls.Add(btnConsultar);
            Controls.Add(pbPlanoDeFundo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PrevisaoDoTempo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Previsão do Tempo";
            ((System.ComponentModel.ISupportInitialize)pbPlanoDeFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPlanoDeFundo;
        private Button btnConsultar;
        private RichTextBox rtbRetorno;
        private ComboBox cbCidades;
        private Label lbCidades;
    }
}
