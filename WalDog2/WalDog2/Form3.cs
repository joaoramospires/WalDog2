using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalDog2.Resources
{
    public partial class Form3 : Form
    {
        string _user;
        public Form3(string user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btt_submeter_Click(object sender, EventArgs e)
        {
            // Array para armazenar os valores de cada GroupBox
            string[] valores = new string[4];

            // Interar sobre cada GroupBox e associar os valores aos campos do array
            int i = 0; // Inicializa um contador para rastrear o índice no array 'valores'
            foreach (var groupBox in Controls.OfType<GroupBox>())
            {
                // Procura o RadioButton selecionado dentro da GroupBox atual
                RadioButton selectedRadioButton = groupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

                if (selectedRadioButton != null) // Se um RadioButton estiver selecionado
                {
                    // Armazena o valor do RadioButton selecionado no array 'valores'
                    valores[i] = selectedRadioButton.Text;
                    i++; // Incrementa o contador para o próximo campo do array 'valores'
                }
            }

            // Inserir os valores no SQL
            if (i == 4) // Verifica se foram selecionados quatro valores
            {

                //dogDadosTA.Insert(txt_nomeDog.Text, cbox_Tamanho.SelectedItem.ToString(), valores[0], valores[2], valores[1],
                //    valores[3], txt_descricao.Text, _user, cbox_racaDog.SelectedValue.ToString());

                this.Hide();
                new Form4(_user).Show();

            }
            else
            {
                MessageBox.Show("Por favor, selecione uma opção em cada .");
            }


        }

        private void tsbtt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4(_user).Show();
        }
        private void tsbtt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Validação dos campos
        private bool Validar()
        {
            bool temErros = false;
            Erros.Clear();

            if (cbox_racaDog.SelectedItem == null)
            {
                temErros = true;
                Erros.SetError(cbox_racaDog, "Valor necessario!");
            }

            if (txt_nomeDog.Text == null || txt_nomeDog.Text == "")
            {
                temErros = true;
                Erros.SetError(txt_nomeDog, "Valor necessario!");
            }

            if (cbox_Tamanho.SelectedItem == null)
            {
                temErros = true;
                Erros.SetError(cbox_Tamanho, "Valor necessario!");
            }

            return temErros;
        }

        
    }
}
