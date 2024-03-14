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
    public partial class Form4 : Form
    {
        string _user;
        public Form4(string user)
        {
            InitializeComponent(); 
            _user = user;
            this.ActiveControl = null;
            this.dogDadosTA.Fill(this.walDogDataSet.DogDados);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }


        // Adicionar um dog
        private void btt_adAumigo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3(_user).Show();
        }
        // Adicionar cartão
        private void btt_adCartao_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Form7(_user).Show();
        }
        // Marcar passeios
        private void btt_doPasseio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5(_user).Show();
        }
        // Ver passeios já e passeios que irão acontecer
        private void btt_verPasseios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6(_user).Show();

        }



        // Leva ao forms de Login (Form1)
        private void btt_trocarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
        //Sai da aplicacão
        private void tsBtt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Limpa os campos
        private void LimparCampos()
        {
            cBox_procurarDog.ResetText();

            lbl_racaCao.ResetText();
            rbtt_Simalergia.Checked = false;
            rbtt_Naoalergia.Checked = false;
            txt_descricao.Clear();

        }

        private void cBox_procurarDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();

            string selectedDogName = cBox_procurarDog.SelectedIndex.ToString(); // Obtém o nome do cão selecionado na lista
            var procurarDog = dogDadosTA.GetDataByDadosCao(_user);

            if (procurarDog.Rows.Count > 0)
            {
                DataRow row = procurarDog.Rows[int.Parse(selectedDogName)];

                string nomeOfDog = row["nameDog"].ToString();
                string racaCao = row["racaCachorro"].ToString();
                string alergia = row["alergia"].ToString();
                string descricao = row["descricao"].ToString();

                // Exibe os dados na interface do usuário
                groupBox1.Text = nomeOfDog;
                lbl_racaCao.Text = racaCao;

                if (alergia == "Sim")
                {
                    rbtt_Simalergia.Checked = true;
                }
                else
                {
                    rbtt_Naoalergia.Checked = true;
                }

                txt_descricao.Text = descricao;
            }
            
        }
    }
}
