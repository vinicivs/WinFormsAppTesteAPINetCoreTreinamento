namespace WinFormsAppTesteAPINetCoreTreinamento
{
    partial class FrmTesteJson
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
            BtnTeste = new Button();
            BtnSair = new Button();
            DgvListagem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvListagem).BeginInit();
            SuspendLayout();
            // 
            // BtnTeste
            // 
            BtnTeste.Location = new Point(12, 12);
            BtnTeste.Name = "BtnTeste";
            BtnTeste.Size = new Size(75, 23);
            BtnTeste.TabIndex = 0;
            BtnTeste.Text = "Json";
            BtnTeste.UseVisualStyleBackColor = true;
            BtnTeste.Click += BtnTeste_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(93, 12);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(75, 23);
            BtnSair.TabIndex = 1;
            BtnSair.Text = "Sai&r";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // DgvListagem
            // 
            DgvListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListagem.Location = new Point(12, 41);
            DgvListagem.Name = "DgvListagem";
            DgvListagem.Size = new Size(650, 410);
            DgvListagem.TabIndex = 2;
            // 
            // FrmTesteJson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 463);
            Controls.Add(DgvListagem);
            Controls.Add(BtnSair);
            Controls.Add(BtnTeste);
            MaximizeBox = false;
            Name = "FrmTesteJson";
            Text = "Teste Json";
            ((System.ComponentModel.ISupportInitialize)DgvListagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnTeste;
        private Button BtnSair;
        private DataGridView DgvListagem;
    }
}
