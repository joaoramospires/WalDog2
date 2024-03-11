using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalDog2.Resources;

namespace WalDog2
{
    public partial class Form5 : Form
    {
        string _user;
        public Form5(string user)
        {
            InitializeComponent();
            _user = user;
        }


        private void tsbtt_voltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Form4(_user).Show();
        }

        private void lst_mostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Preço base por hora do passeio
            double precoBasePorHora = 10.0;


            double tempoPasseio;
            double dia;

            bool treino = false;
            bool alimen = false;
            bool cuidEspeciasi = false;


            tempoPasseio = int.Parse(mtxt_tempoPasseio.Text);
            dia = int.Parse(mdata_passeio.Text);


            if (chek_treinamento.Checked)
            {

            }



            // Tipos de serviços extras
            double precoServicoExtra = 5.0;

            // Validação para verificar o dia
            double fatorTempoAntecedenciaReserva = 0.8; // 20% de desconto para reservas feitas com antecedência.

            fatorTempoAntecedenciaReserva = (precoServicoExtra * precoBasePorHora);

            // Número de cachorros
            double fatorNumeroCachorros = 1.1; // 10% de acréscimo por cachorro adicional
            // tipos de serviços
            bool servicoEspecial = true;




            // Cálculo do preço base do passeio
            double precoPasseio = 0 * precoBasePorHora;

        }

        private void tsBtt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServiçosExtras()
        {//precoPasseio *= Math.Pow(fatorNumeroCachorros, precoServicoExtra)

            double treinamento = 0.50;
            double alimentacao = 0.30;
            double outrsCuidados = 0.60;

        }

    }
}
