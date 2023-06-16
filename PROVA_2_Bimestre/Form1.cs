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

            int cpf = Convert.ToInt32(Convert.ToString(tx_cpf.Text));
            // tx_cpf.Text = Convert.ToString(cpf);
            string matricula = tx_matricula.Text;
            string nome = tx_nome.Text;
            double salario = Convert.ToInt32(Convert.ToString(tx_salario.Text));
           // tx_salario.Text = Convert.ToString(salario);
            string funcao = Convert.ToString(Convert.ToInt32( cb_funcao.Text));
            double porcentagem = 0;
            double resto;
            double porcentagemFinal = 0;

            if (funcao == "Médico" )
            {
                porcentagem = salario + salario % 20;
                Console.WriteLine(porcentagem);

            }
            if (funcao == "TI")
            {
                porcentagem = salario + 5600;
                Console.WriteLine(porcentagem);
            }
            if(funcao == "ADM")
            {
               
                porcentagem = salario + salario % 15;
                porcentagemFinal = porcentagem + 200;
                Console.WriteLine(porcentagemFinal);

            }

            if(porcentagemFinal => 5000)
            {
                resto = porcentagemFinal % 17;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_matricula.Clear();
            tx_salario.Clear();
        }
    }
}