using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using WalDog2.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WalDog2
{
    public partial class Form5 : Form
    {
        string _user;
        double precoChek = 0;
        public Form5(string user)
        {
            InitializeComponent();
            _user = user;
            this.dogDadosTA.Fill(this.walDogDataSet.DogDados);
            this.bancoDinheiroTA.Fill(this.walDogDataSet.BancoDinheiro);
            this.ActiveControl = null;
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            
        }



        private void btt_gerarPreco_Click(object sender, EventArgs e)
        {
            ContasPasseio();
        }


        private void btt_escolherCaes_Click(object sender, EventArgs e)
        {
            
        }


        private void tsbtt_voltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Form4(_user).Show();
        }


        private void tsBtt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






        private void ContasPasseio()
        {

            mtxt_tempoPasseio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Atribuição dos valores
            double precoBasePorHora = 0.35; // Preço base por hora do passeio

            double quantidadeDog = lst_mostrar.SelectedItems.Count;
            double tempoPasseio = double.Parse(mtxt_tempoPasseio.Text);
            DateTime diaSelecionado = mdata_passeio.Value.Date; // Uso o (.Value) para obter a data do controle MetroDateTime
            DateTime hoje = DateTime.Today;

            // Verificar se a data selecionada está a 3, 5 ou 10 dias no futuro
            TimeSpan diferenca3Dias = diaSelecionado - hoje.AddDays(3);
            TimeSpan diferenca5Dias = diaSelecionado - hoje.AddDays(5);
            TimeSpan diferenca10Dias = diaSelecionado - hoje.AddDays(10);


            if (lst_mostrar.SelectedItems != null)
            {                   

                if (diaSelecionado > hoje)
                {
                    //precoChek = precoChek = ValorDosExtras * quantidadeDog * 1.1 acrescimoporDog
                    double precoChek = 0;
                    if (chek_treinamento.Checked)
                    {
                        precoChek += 0.50 * quantidadeDog * 1.1;
                    }

                    if (chek_alimentacao.Checked)
                    {
                        precoChek += 0.30 * quantidadeDog * 1.1;
                    }

                    if (chek_cuidadoEspe.Checked)
                    {
                        precoChek += 0.60 * quantidadeDog * 1.1;
                    }


                    // Se a diferença for negativa, significa que a data selecionada está no futuro
                    double taxaDias = 0;
                    if (diferenca10Dias.TotalDays >= 0)
                    {
                        taxaDias = 0.60;
                    }
                    else if (diferenca5Dias.TotalDays >= 0)
                    {
                        taxaDias = 0.80; 
                    }
                    else if (diferenca3Dias.TotalDays >= 0)
                    {

                        taxaDias = 1.0;
                    }

                    // Calcule o preço total do passeio, incluindo:
                    // precoBasePorHora, tempoPasseio, taxaDias, quantidadeDog, precoChek
                    double precoTotal = precoBasePorHora * tempoPasseio * taxaDias + precoChek;

                    //MessageBox.Show($"Preço total: {precoTotal}");

                    lbl_precoPasseio.Text = precoTotal.ToString();

                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma data posterior à data atual.");
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione um dos seus animais.");
            }

        }

       
        private void lst_mostrar_Enter(object sender, EventArgs e)
        {

        }

        
    }

}
