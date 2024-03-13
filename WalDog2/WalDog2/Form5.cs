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
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }


        private void btt_escolherCaes_Click(object sender, EventArgs e)
        {
            ServiçosExtras();
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




        private void ServiçosExtras()
        {//precoPasseio *= Math.Pow(fatorNumeroCachorros, precoServicoExtra)


            // Preço base por hora do passeio
            double precoBasePorHora = 0.30;


            // Atribuição de valor e dos campos
            double tempoPasseio = double.Parse(mtxt_tempoPasseio.Text);
            DateTime dia = DateTime.Parse(mdata_passeio.Text);
            DateTime hoje = DateTime.Today;


            if (chek_treinamento.Checked)
            {
                precoChek = +50;
            }

            if (chek_alimentacao.Checked)
            {
                precoChek = +30;
            }

            if (chek_cuidadoEspe.Checked)
            {
                precoChek = +60;
            }


            //Validação de marcou um dia antes que hoje -- parei aqui
            if (dia < hoje)
            {

                // Validação para verificar o dia
                double fatorTempoAntecedenciaReserva = 0.8; // 20% de desconto para reservas feitas com antecedência.

                fatorTempoAntecedenciaReserva = (0 * precoBasePorHora);

                // Número de cachorros
                double fatorNumeroCachorros = 1.1; // 10% de acréscimo por cachorro adicional


                // Cálculo do preço base do passeio
                double precoPasseio = fatorNumeroCachorros * precoBasePorHora;

            }








        }
    }
}
