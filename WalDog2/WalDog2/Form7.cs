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
    public partial class Form7 : Form
    {
        //Crio uma variavel para buscar o username inserido no Login
        string _user;
        public Form7(string user)
        {
            InitializeComponent();
            _user = user;
        }

        //Adicionar novos cartões
        private void btt_adCartao_Click(object sender, EventArgs e)
        {
            // ISSO FAZ RETIRAR O TRAÇO OU QUALQUER CARACTER USADO NA MASKBOX
            //Tira a formatação
            mtxt_numCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxt_validadeCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;




            this.Hide();
            new Form4(_user).Show();
        }
        // Voltar ao Forms Principal (Form4)
        private void tsbtt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4(_user).Show();
        }
        //Sair da aplicação
        private void tsbtt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool Validar()
        {

            bool temErros = false;
            Erros.Clear();


            if (txt_nome.Text == "" || txt_nome.Text == null)
            {
                temErros = true;
                Erros.SetError(txt_nome, "Valor necessario!");
            }

            if (mtxt_nif.Text == "" || mtxt_nif.Text == null)
            {
                temErros = true;
                Erros.SetError(mtxt_nif, "Valor necessario!");
            }

            if (mtxt_numCartao.Text == "" || mtxt_numCartao.Text == null)
            {
                temErros = true;
                Erros.SetError(mtxt_numCartao, "Valor necessario!");
            }

            if (mtxt_validadeCartao.Text == "" || mtxt_validadeCartao.Text == null)
            {
                temErros = true;
                Erros.SetError(mtxt_validadeCartao, "Valor necessario!");
            }

            if (mtxt_cvc.Text == "" || mtxt_cvc.Text == null)
            {
                temErros = true;
                Erros.SetError(mtxt_cvc, "Valor necessario!");
            }

            if (txt_valorConta.Text == "" || txt_valorConta.Text == null)
            {
                temErros = true;
                Erros.SetError(txt_valorConta, "Valor necessario!");
            }

            return temErros;
        }

        
    }
}
