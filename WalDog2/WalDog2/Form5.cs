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

            this.dogDadosTA.FillByPasseioUser(this.walDogDataSet.DogDados, lst_mostrar.Text);
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            try {

                // TODO: esta linha de código carrega dados na tabela 'walDogDataSet.DogDados'. Você pode movê-la ou removê-la conforme necessário.
                this.dogDadosTA.Fill(this.walDogDataSet.DogDados);

                // TODO: esta linha de código carrega dados na tabela 'walDogDataSet1.BancoDinheiro'. Você pode movê-la ou removê-la conforme necessário.
                this.bancoDinheiroTA.Fill(this.walDogDataSet1.BancoDinheiro);
                this.bancoDinheiroTA.FillByCarteira(this.walDogDataSet.BancoDinheiro, cbox_Cartao.Text);
                this.passeiosTA.Fill(this.walDogDataSet1.Passeios);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActiveControl = null;

        }

        // Mostrar os dados relacionados ao Dono do cartão
        private void cbox_Cartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();

            var procurarCartao = bancoDinheiroTA.GetDataByCarteira(_user);
            string selectedName = cbox_Cartao.Text;
           
            if (procurarCartao.Rows.Count > 0)
            {
                DataRow row = procurarCartao.Rows[int.Parse(selectedName)];


                string nome = row["nome"].ToString();
                string nif = row["nif"].ToString();
                string numCartao = row["numCartao"].ToString();
                string codSegu = row["codSegu"].ToString();
                string pagamentos = row["valorConta"].ToString();



                // Exibe os dados na interface do usuário
                lbl_nome.Text = nome;
                lbl_nif.Text = nif;
                lbl_numCartao.Text = numCartao;
                lbl_cvc.Text = codSegu;
                lbl_valorConta.Text = pagamentos;

            }

        }



        private void btt_gerarPreco_Click(object sender, EventArgs e)
        {
            ContasPasseio();
        }
        

        private void btt_marcarPasseio_Click(object sender, EventArgs e)
        {
            // Gerando uma combinação aleatória de até 10 caracteres
            string verificacao = GeradordeCodigos(10);

            MessageBox.Show($"O seu código de verificação é: {verificacao}", "Atenção");

            mtxt_tempoPasseio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            double precoTotal = ContasPasseio();

            // Tenta converter o texto em mtxt_tempoPasseio para uma data
            DateTime dataPasseio = DateTime.Parse(mdata_passeio.Text);

            // chama o ID para ser introduzido na Bd
            var chamarID2 = dogDadosTA.GetDataByDadosCao(_user);
            int chamarID = chamarID2[0].idDoguinho;

            passeiosTA.Insert(dataPasseio, Convert.ToDecimal(precoTotal), verificacao, _user, chamarID);


            //var valorConta = pagamentosTA.GetDataByPagamentosUser(_user);

            //var total = Convert.ToInt32(valorConta) - Convert.ToInt32(precoTotal);


            //MessageBox.Show($"O resto é: {total}");

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



        // MÉTODOS ---------------------------------------------------------------------------------------------------------
        private void LimparCampos()
        {
            cbox_Cartao.ResetText();

            lbl_nome.ResetText();
            lbl_nif.ResetText();
            lbl_numCartao.ResetText();
            lbl_cvc.ResetText();
            lbl_valorConta.ResetText();

        }

        // Metodo para calcular o preço do passeio
        private double ContasPasseio()
        {
            double precoTotal = 0;
            mtxt_tempoPasseio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            // Atribuição dos valores
            double precoBasePorHora = 0.35; // Preço base por hora do passeio

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
                    
                    double precoChek = 0;
                    
                    if (chek_treinamento.Checked)
                    {
                        precoChek += 0.50; 
                    }

                    if (chek_alimentacao.Checked)
                    {
                        precoChek += 0.30;
                    }

                    if (chek_cuidadoEspe.Checked)
                    {
                        precoChek += 0.60;
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
                     precoTotal =  taxaDias + (precoChek  * (precoBasePorHora * tempoPasseio));

                    lbl_precoPasseio.Text = precoTotal.ToString();

                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma data posterior à data atual.", "Atenção", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione um dos seus animais.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return precoTotal;

        }


        // Função para gerar uma combinação aleatória de letras e números
        public static string GeradordeCodigos(int tamanho)
        {
            // Definindo os caracteres válidos (letras e números)
            const string caracteresValidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Criando um objeto Random para gerar números aleatórios
            Random random = new Random();

            // Criando uma variável para armazenar a combinação aleatória
            StringBuilder combinacao = new StringBuilder();

            // Gerando a combinação aleatória
            for (int i = 0; i < tamanho; i++)
            {
                // Selecionando um caractere aleatório da lista de caracteres válidos
                char caractere = caracteresValidos[random.Next(caracteresValidos.Length)];

                // Adicionando o caractere à combinação
                combinacao.Append(caractere);
            }

            // Retornando a combinação aleatória gerada
            return combinacao.ToString();
        }

        
    }

}


