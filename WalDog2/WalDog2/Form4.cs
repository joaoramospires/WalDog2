﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalDog2.WalDogDataSetTableAdapters;

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

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.dogDadosTA.Fill(this.walDogDataSet.DogDados);
            this.dogDadosTA.FillByMenu(this.walDogDataSet.DogDados, cBox_procurarDog.Text);
        }


        // Quando seleciono o nome do Dog ele me mostra alguns dados sobre eles
        private void cBox_procurarDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimparCampos();

            string selectedDogName = cBox_procurarDog.Text; // Obtém o nome do cão selecionado na lista
            var procurarDog = dogDadosTA.GetDataByDadosCao(_user);

            // Verifica se há linhas na tabela
            if (procurarDog.Rows.Count > 0)
            {
                DataRow row = null;

                // Procura a linha correspondente ao cão selecionado
                foreach (DataRow dr in procurarDog.Rows)
                {
                    if (dr["nameDog"].ToString() == selectedDogName)
                    {
                        row = dr;
                        break;
                    }
                }

                // Verifica se o cão foi encontrado
                if (row != null)
                {
                    // Extrai os dados do cão
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

                    btt_deletar.Visible = true;
                }
                
            }

        }

        private void btt_deletar_Click(object sender, EventArgs e)
        {
            string selectedDogName = cBox_procurarDog.Text; // Obtém o nome do cão selecionado na lista
            var procurarDog = dogDadosTA.GetDataByDadosCao(_user);

            if (procurarDog.Rows.Count > 0)
            {
                DialogResult resposta = MessageBox.Show("Deseja eliminar o resgistro selecionado? Se elimina-lo, perderá o dai do passeio",
                "Confirmação da seleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    // Procura pelo cão selecionado
                    foreach (DataRow row in procurarDog.Rows)
                    {
                        // Verifica se o nome do cão na linha atual corresponde ao cão selecionado
                        if (row["nameDog"].ToString() == selectedDogName)
                        {
                            // Obtém o ID do cão para exclusão
                            int idCao = Convert.ToInt32(row["idDoguinho"]); // Supondo que o ID do cão está em uma coluna chamada "ID"
                                                         
                            // chama o ID para ser introduzido na Bd
                            var chamarID2 = passeiosTA.GetDataByDados(_user);
                            int chamarID = chamarID2[0].idPasseio;


                            // PESQUISAR PARA VER SE EXISTE ALGUM PASSEIO, SE NÃO TIVER EXLUI UM DOG
                            //Escluir o passeio
                            passeiosTA.Delete(chamarID, _user, idCao);
                            passeiosTA.Update(walDogDataSet.Passeios);
                            passeiosTA.Fill(walDogDataSet.Passeios);

                            //Excluir o Dog
                            dogDadosTA.Delete(idCao, _user);
                            dogDadosTA.Update(walDogDataSet.DogDados);
                            dogDadosTA.Fill(walDogDataSet.DogDados);
                            LimparCampos();

                        }
                    }
                }
            }

                
        }


        // Mostra todos os outros botões
        private void btt_mais_Click(object sender, EventArgs e)
        {
            btt_adAumigo.Visible = true;
            btt_verPasseios.Visible = true;
            btt_adCartao.Visible = true;
            btt_doPasseio.Visible = true;
            btt_trocarConta.Visible = true;

        }

        // Adicionar um dog 
        private void btt_adAumigo_Click_1(object sender, EventArgs e)
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
            groupBox1.ResetText();
            lbl_racaCao.ResetText();
            rbtt_Simalergia.Checked = false;
            rbtt_Naoalergia.Checked = false;
            txt_descricao.Clear();

        }

       
    }
}
