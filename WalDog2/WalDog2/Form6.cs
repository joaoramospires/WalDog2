using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalDog2.Resources;

namespace WalDog2
{
    public partial class Form6 : Form
    {
        string _user;
        public Form6(string user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            displayDays();
        }



        int mes, ano;
        private void btt_next_Click(object sender, EventArgs e)
        {
            //Limpar container
            dayContanier.Controls.Clear();

            if (mes != 12)
            {
                //incrementa para ir de mês em mês
                mes++;
            }
            else
            {
                ano++;
                mes = 1;
            }


            // Isso faz o ano mudar, tanto número quanto palavra
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbl_ano.Text = nomeMes + " " + ano;

            // Conseguir o primeiro dia do mês
            DateTime comecoMes = new DateTime(ano, mes, 1);

            //Contar os dias do mês
            int dia = DateTime.DaysInMonth(ano, mes);

            //Converter o comecoMes para INT
            int diasDaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d"));

            //Criar um UserControl (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 0; i < diasDaSemana; i++)
            {
                UserControlBlancks userConBln = new UserControlBlancks();
                dayContanier.Controls.Add(userConBln);
            }

            //Criar um UserControl para os dias (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 1; i <= dia; i++)
            {
                UserControlDays userConDay = new UserControlDays();
                userConDay.Dias(i);
                dayContanier.Controls.Add(userConDay);
            }
        }

        private void btt_previous_Click(object sender, EventArgs e)
        {
            //Limpar container
            dayContanier.Controls.Clear();

            if (mes != 1)
            {
                // voltar para ir de mês em mês
                mes--;
            }
            else
            {
                ano--;
                mes = 12;
            }

            // Isso faz o ano mudar, tanto número quanto palavra
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbl_ano.Text = nomeMes + " " + ano;

            // Conseguir o primeiro dia do mês
            DateTime comecoMes = new DateTime(ano, mes, 1);

            //Contar os dias do mês
            int dia = DateTime.DaysInMonth(ano, mes);

            //Converter o comecoMes para INT
            int diasDaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d"));

            //Criar um UserControl (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 0; i < diasDaSemana; i++)
            {
                UserControlBlancks userConBln = new UserControlBlancks();
                dayContanier.Controls.Add(userConBln);
            }

            //Criar um UserControl para os dias (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 1; i <= dia; i++)
            {
                UserControlDays userConDay = new UserControlDays();
                userConDay.Dias(i);
                dayContanier.Controls.Add(userConDay);
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
         
        // Criação dos dias ------- Métodos ---------------------------------
        private void displayDays()
        {
            DateTime hoje = DateTime.Now;

            mes = hoje.Month;
            ano = hoje.Year;

            // Isso faz o ano mudar, tanto número quanto palavra
            String nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbl_ano.Text = nomeMes + " " + ano;

            // Conseguir o primeiro dia do mês
            DateTime comecoMes = new DateTime(ano, mes, 1);

            //Contar os dias do mês
            int dia = DateTime.DaysInMonth(ano, mes);

            //Converter o comecoMes para INT
            int diasDaSemana = Convert.ToInt32(comecoMes.DayOfWeek.ToString("d"));

            //Criar um UserControl (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 0; i < diasDaSemana; i++)
            {
                UserControlBlancks userConBln = new UserControlBlancks();
                dayContanier.Controls.Add(userConBln);
            }

            //Criar um UserControl para os dias (Fica na barra de tarefas -> Controle de Usuário)
            for (int i = 1; i <= dia; i++)
            {
                UserControlDays userConDay = new UserControlDays();
                userConDay.Dias(i);
                dayContanier.Controls.Add(userConDay);
            }
        }
    }
}
