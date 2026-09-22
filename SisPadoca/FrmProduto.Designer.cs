namespace SisPadoca
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            LblNCM = new Label();
            TxbNCM = new TextBox();
            BtnNovo = new Button();
            ImgLista = new ImageList(components);
            CbxUnidade = new ComboBox();
            PbxImagem = new PictureBox();
            txbDescricao = new TextBox();
            LblDescricao = new Label();
            TxbCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            LblLote = new Label();
            TxbLote = new TextBox();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(218, 25);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            // 
            // TxbNCM
            // 
            TxbNCM.Location = new Point(218, 53);
            TxbNCM.Name = "TxbNCM";
            TxbNCM.Size = new Size(179, 31);
            TxbNCM.TabIndex = 1;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(31, 292);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(142, 62);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // CbxUnidade
            // 
            CbxUnidade.FormattingEnabled = true;
            CbxUnidade.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CbxUnidade.Location = new Point(510, 134);
            CbxUnidade.Name = "CbxUnidade";
            CbxUnidade.Size = new Size(182, 33);
            CbxUnidade.TabIndex = 3;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = (Image)resources.GetObject("PbxImagem.Image");
            PbxImagem.Location = new Point(12, 40);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(196, 225);
            PbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagem.TabIndex = 4;
            PbxImagem.TabStop = false;
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(218, 134);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(268, 31);
            txbDescricao.TabIndex = 5;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(218, 106);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 6;
            LblDescricao.Text = "Descrição";
            // 
            // TxbCodigoBarras
            // 
            TxbCodigoBarras.Location = new Point(218, 219);
            TxbCodigoBarras.Name = "TxbCodigoBarras";
            TxbCodigoBarras.Size = new Size(268, 31);
            TxbCodigoBarras.TabIndex = 7;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(218, 191);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 8;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(510, 106);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(143, 25);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Unidade medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(510, 191);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(510, 219);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(182, 31);
            TxbLote.TabIndex = 11;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(179, 292);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(142, 62);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(327, 292);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(142, 62);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(475, 292);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(142, 62);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(623, 292);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(142, 62);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 501);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TxbLote);
            Controls.Add(LblLote);
            Controls.Add(LblUnidade);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbCodigoBarras);
            Controls.Add(LblDescricao);
            Controls.Add(txbDescricao);
            Controls.Add(PbxImagem);
            Controls.Add(CbxUnidade);
            Controls.Add(BtnNovo);
            Controls.Add(TxbNCM);
            Controls.Add(LblNCM);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private TextBox TxbNCM;
        private Button BtnNovo;
        private ImageList ImgLista;
        private ComboBox CbxUnidade;
        private PictureBox PbxImagem;
        private TextBox txbDescricao;
        private Label LblDescricao;
        private TextBox TxbCodigoBarras;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private Label LblLote;
        private TextBox TxbLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
    }
}