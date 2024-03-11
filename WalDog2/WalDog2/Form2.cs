using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalDog2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Voltar ao forms de Login(Form1)
        private void tsbtt_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
        //Fechar a aplicação
        private void tsBtt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Realizar cadastro
        private void btt_cadastrar_Click(object sender, EventArgs e)
        {
            // ISSO FAZ RETIRAR O TRAÇO OU QUALQUER CARACTER USADO NA MASKBOX
            //Tira a formatação
            mtxt_numCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxt_validadeCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;





            this.Hide();
            new Form1().Show();
        }

        // Validação para não deixar os campos null e confirmar as duas senhas
        private bool Validar()
        {

            bool temErros = false;
            Erros.Clear();


            if (txt_username.Text == "" || txt_username.Text == null)
            {
                temErros = true;
                Erros.SetError(txt_username, "Valor necessario!");
            }

            if (txt_password.Text == "" || txt_password.Text == null)
            {
                temErros = true;
                Erros.SetError(txt_password, "Valor necessario!");
            }

            if (txt_password.Text != txt_confirmPassword.Text)
            {
                temErros = true;
                Erros.SetError(txt_confirmPassword, "Os valores não se coincidem!");
            }

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
