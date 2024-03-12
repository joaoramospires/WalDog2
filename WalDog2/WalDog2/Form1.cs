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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WalDog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btt_entrar_Click(object sender, EventArgs e)
        {

            // Pega todos os dados associados ao Username
            var procurar = logarTA.GetDataBy(txt_Username.Text, txt_Password.Text);

            if (procurar.Count == 0)
            {
                MessageBox.Show("Credênciais inválidos ou dados não existentes!", "Erro de acesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Esse campo serve para ir buscar os dados da minha Base de Dados (GetDataBy)
                string username = logarTA.GetDataByUser(txt_Username.Text)[0].ToString();

                var dadoCao = dogDadosTA.GetDataByDadosCao(txt_Username.Text);
                //Se não existr dados do cão
                if (dadoCao.Count == 0)
                {
                    this.Hide();
                    new Form3(txt_Username.Text).Show();
                }
                else
                {
                    this.Hide();
                    new Form4(txt_Username.Text).Show();
                }

            }

        }

        private void btt_cadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        //Página de Carregamento
        private int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Deixar 50 = 5s
            if (count == 0)
            {
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;

                txt_Username.Visible = true;
                txt_Password.Visible = true;

                btt_cadastrar.Visible = true;
                btt_entrar.Visible = true;
            }

            count++;
        }

        //Sair
        private void tsBtt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
