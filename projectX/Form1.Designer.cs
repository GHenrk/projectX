namespace projectX
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCodigoOp = new System.Windows.Forms.TextBox();
            this.txbCodigoPeca = new System.Windows.Forms.TextBox();
            this.txbFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaquina = new System.Windows.Forms.ComboBox();
            this.txbObs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApontar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbOperacao = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apontamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código OP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peça:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(79, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Funcionário:";
            // 
            // txbCodigoOp
            // 
            this.txbCodigoOp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodigoOp.Location = new System.Drawing.Point(226, 97);
            this.txbCodigoOp.Name = "txbCodigoOp";
            this.txbCodigoOp.Size = new System.Drawing.Size(244, 39);
            this.txbCodigoOp.TabIndex = 4;
            // 
            // txbCodigoPeca
            // 
            this.txbCodigoPeca.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCodigoPeca.Location = new System.Drawing.Point(163, 168);
            this.txbCodigoPeca.Name = "txbCodigoPeca";
            this.txbCodigoPeca.Size = new System.Drawing.Size(307, 39);
            this.txbCodigoPeca.TabIndex = 5;
            // 
            // txbFuncionario
            // 
            this.txbFuncionario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFuncionario.Location = new System.Drawing.Point(237, 232);
            this.txbFuncionario.Name = "txbFuncionario";
            this.txbFuncionario.Size = new System.Drawing.Size(233, 39);
            this.txbFuncionario.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(79, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 54);
            this.label5.TabIndex = 8;
            this.label5.Text = "Máquina:";
            // 
            // cbMaquina
            // 
            this.cbMaquina.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMaquina.FormattingEnabled = true;
            this.cbMaquina.ItemHeight = 32;
            this.cbMaquina.Items.AddRange(new object[] {
            "Feeler FV-1300",
            "PanMachine VM-1000",
            "HartFord ABR-1000",
            "Fresadora Convencional",
            "TORNO CNC 1000",
            "TORNO CNC 600",
            "Torno Convencional ",
            "Torno Convencional 2"});
            this.cbMaquina.Location = new System.Drawing.Point(205, 301);
            this.cbMaquina.Name = "cbMaquina";
            this.cbMaquina.Size = new System.Drawing.Size(265, 40);
            this.cbMaquina.TabIndex = 9;
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(546, 167);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(391, 104);
            this.txbObs.TabIndex = 10;
            this.txbObs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(546, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 54);
            this.label6.TabIndex = 11;
            this.label6.Text = "Observações:";
            // 
            // btnApontar
            // 
            this.btnApontar.BackColor = System.Drawing.Color.Black;
            this.btnApontar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApontar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApontar.FlatAppearance.BorderSize = 3;
            this.btnApontar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApontar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApontar.Font = new System.Drawing.Font("Imprint MT Shadow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApontar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApontar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApontar.Location = new System.Drawing.Point(314, 476);
            this.btnApontar.Name = "btnApontar";
            this.btnApontar.Size = new System.Drawing.Size(244, 39);
            this.btnApontar.TabIndex = 12;
            this.btnApontar.Text = "Enviar Apontamento";
            this.btnApontar.UseVisualStyleBackColor = false;
            this.btnApontar.Click += new System.EventHandler(this.btnApontar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(79, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 54);
            this.label7.TabIndex = 13;
            this.label7.Text = "Operação:";
            // 
            // txbOperacao
            // 
            this.txbOperacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbOperacao.Location = new System.Drawing.Point(212, 374);
            this.txbOperacao.Name = "txbOperacao";
            this.txbOperacao.Size = new System.Drawing.Size(258, 39);
            this.txbOperacao.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(546, 333);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(128, 54);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "STATUS:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txbDate
            // 
            this.txbDate.BackColor = System.Drawing.Color.DarkGray;
            this.txbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDate.Location = new System.Drawing.Point(314, 547);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(386, 25);
            this.txbDate.TabIndex = 16;
            this.txbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDate.TextChanged += new System.EventHandler(this.txbDate_TextChanged);
            // 
            // txbStatus
            // 
            this.txbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txbStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbStatus.Location = new System.Drawing.Point(680, 333);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(257, 39);
            this.txbStatus.TabIndex = 17;
            this.txbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 3;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Imprint MT Shadow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(584, 475);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 39);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1008, 591);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txbOperacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnApontar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.cbMaquina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbFuncionario);
            this.Controls.Add(this.txbCodigoPeca);
            this.Controls.Add(this.txbCodigoOp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Apontamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txbCodigoOp;
        private TextBox txbCodigoPeca;
        private TextBox txbFuncionario;
        private Label label5;
        private ComboBox cbMaquina;
        private RichTextBox txbObs;
        private Label label6;
        private Button btnApontar;
        private Label label7;
        private TextBox txbOperacao;
        private Label lblStatus;
        private TextBox txbDate;
        private TextBox txbStatus;
        private Button btnLimpar;
    }
}