namespace ProjetoFinalTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsFuncBtn = new System.Windows.Forms.ToolStripButton();
            this.tsMaquinaBtn = new System.Windows.Forms.ToolStripButton();
            this.tsPecaBtn = new System.Windows.Forms.ToolStripButton();
            this.tsOpBtn = new System.Windows.Forms.ToolStripButton();
            this.tsApontamentoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsFuncBtn,
            this.tsMaquinaBtn,
            this.tsPecaBtn,
            this.tsOpBtn,
            this.tsApontamentoBtn,
            this.toolStripSeparator2});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 25);
            this.menu.TabIndex = 1;
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.toolStripLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel2.Size = new System.Drawing.Size(221, 22);
            this.toolStripLabel2.Text = "Central de Cadastros";
            this.toolStripLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // tsFuncBtn
            // 
            this.tsFuncBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFuncBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tsFuncBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFuncBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsFuncBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsFuncBtn.Image")));
            this.tsFuncBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsFuncBtn.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.tsFuncBtn.MergeIndex = 1;
            this.tsFuncBtn.Name = "tsFuncBtn";
            this.tsFuncBtn.Size = new System.Drawing.Size(82, 21);
            this.tsFuncBtn.Text = "Funcionário";
            this.tsFuncBtn.Click += new System.EventHandler(this.tsFuncBtn_Click);
            // 
            // tsMaquinaBtn
            // 
            this.tsMaquinaBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsMaquinaBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tsMaquinaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMaquinaBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMaquinaBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsMaquinaBtn.Image")));
            this.tsMaquinaBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsMaquinaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tsMaquinaBtn.MergeIndex = 1;
            this.tsMaquinaBtn.Name = "tsMaquinaBtn";
            this.tsMaquinaBtn.Size = new System.Drawing.Size(62, 21);
            this.tsMaquinaBtn.Text = "Máquina";
            // 
            // tsPecaBtn
            // 
            this.tsPecaBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsPecaBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tsPecaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPecaBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsPecaBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsPecaBtn.Image")));
            this.tsPecaBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsPecaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tsPecaBtn.MergeIndex = 1;
            this.tsPecaBtn.Name = "tsPecaBtn";
            this.tsPecaBtn.Size = new System.Drawing.Size(41, 21);
            this.tsPecaBtn.Text = "Peça";
            // 
            // tsOpBtn
            // 
            this.tsOpBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsOpBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tsOpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOpBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsOpBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsOpBtn.Image")));
            this.tsOpBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsOpBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tsOpBtn.MergeIndex = 1;
            this.tsOpBtn.Name = "tsOpBtn";
            this.tsOpBtn.Size = new System.Drawing.Size(30, 21);
            this.tsOpBtn.Text = "OP";
            // 
            // tsApontamentoBtn
            // 
            this.tsApontamentoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsApontamentoBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tsApontamentoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsApontamentoBtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsApontamentoBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsApontamentoBtn.Image")));
            this.tsApontamentoBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsApontamentoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tsApontamentoBtn.MergeIndex = 1;
            this.tsApontamentoBtn.Name = "tsApontamentoBtn";
            this.tsApontamentoBtn.Size = new System.Drawing.Size(96, 21);
            this.tsApontamentoBtn.Text = "Apontamento";
            this.tsApontamentoBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "A";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip menu;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton tsMaquinaBtn;
        private ToolStripButton tsPecaBtn;
        private ToolStripButton tsOpBtn;
        private ToolStripButton tsApontamentoBtn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsFuncBtn;
    }
}