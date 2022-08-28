namespace ProjetoFinalTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsFuncBtn_Click(object sender, EventArgs e)
        {
            fecharFormsAberto();

            Form2 funcionarioForm = new Form2();
            funcionarioForm.WindowState = FormWindowState.Maximized;
            funcionarioForm.MdiParent = this;
            funcionarioForm.Show();
        }

        
        private void fecharFormsAberto()
        {
            int qntdForms = Application.OpenForms.Count;

            for(int i = 0; i<qntdForms; i++)
            {
                bool isChild = Application.OpenForms[i].IsMdiChild;
                if (isChild)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }



 
    }
}