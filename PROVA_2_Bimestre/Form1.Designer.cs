namespace PROVA_2_Bimestre
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
            cb_funcao = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tx_nome = new TextBox();
            tx_cpf = new TextBox();
            tx_matricula = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            tx_salario = new TextBox();
            SuspendLayout();
            // 
            // cb_funcao
            // 
            cb_funcao.FormattingEnabled = true;
            cb_funcao.Items.AddRange(new object[] { "Médico", "TI", "ADM" });
            cb_funcao.Location = new Point(193, 142);
            cb_funcao.Name = "cb_funcao";
            cb_funcao.Size = new Size(121, 23);
            cb_funcao.TabIndex = 0;
            cb_funcao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(383, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Matricula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 137);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 4;
            label4.Text = "Função:";
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(78, 14);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(552, 23);
            tx_nome.TabIndex = 5;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(429, 59);
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(201, 23);
            tx_cpf.TabIndex = 6;
            // 
            // tx_matricula
            // 
            tx_matricula.Location = new Point(109, 59);
            tx_matricula.Name = "tx_matricula";
            tx_matricula.Size = new Size(259, 23);
            tx_matricula.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(109, 345);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(528, 345);
            button2.Name = "button2";
            button2.Size = new Size(92, 41);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(109, 190);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 10;
            label5.Text = "Salario:";
            // 
            // tx_salario
            // 
            tx_salario.Location = new Point(193, 190);
            tx_salario.Name = "tx_salario";
            tx_salario.Size = new Size(121, 23);
            tx_salario.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tx_salario);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx_matricula);
            Controls.Add(tx_cpf);
            Controls.Add(tx_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_funcao);
            Name = "Form1";
            Text = "Formulario_cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_funcao;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tx_nome;
        private TextBox tx_cpf;
        private TextBox tx_matricula;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox tx_salario;
    }
}