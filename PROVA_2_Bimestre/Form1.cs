namespace PROVA_2_Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //função é combobox
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int cpf = 0;
            string matricula = tx_matricula.Text;
            string nome = tx_nome.Text;
            tx_cpf.Text = Convert.ToString(cpf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_matricula.Clear();
        }
    }
}