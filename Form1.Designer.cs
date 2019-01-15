namespace LerArquivoTxt
{
    partial class LerArquivoTXT
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
            this.lerButton = new System.Windows.Forms.Button();
            this.dadosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lerButton
            // 
            this.lerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerButton.Location = new System.Drawing.Point(12, 12);
            this.lerButton.Name = "lerButton";
            this.lerButton.Size = new System.Drawing.Size(75, 23);
            this.lerButton.TabIndex = 0;
            this.lerButton.Text = "Ler";
            this.lerButton.UseVisualStyleBackColor = true;
            this.lerButton.Click += new System.EventHandler(this.lerButton_Click);
            // 
            // dadosListBox
            // 
            this.dadosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosListBox.FormattingEnabled = true;
            this.dadosListBox.ItemHeight = 14;
            this.dadosListBox.Location = new System.Drawing.Point(12, 41);
            this.dadosListBox.Name = "dadosListBox";
            this.dadosListBox.Size = new System.Drawing.Size(776, 396);
            this.dadosListBox.TabIndex = 1;
            // 
            // LerArquivoTXT
            // 
            this.AcceptButton = this.lerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dadosListBox);
            this.Controls.Add(this.lerButton);
            this.Name = "LerArquivoTXT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ler Txt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lerButton;
        private System.Windows.Forms.ListBox dadosListBox;
    }
}

