using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalDog2.WalDogDataSetTableAdapters;

namespace WalDog2
{
    public partial class UserControlDays : UserControl
    {
        string _user;
        public UserControlDays(string user)
        {
            InitializeComponent();

            _user = user;
        }

       
        private void UserControlDays_Load(object sender, EventArgs e)
        {
            

        }


        private void pbox_marcacao_Click(object sender, EventArgs e)
        {
            // Caso o utilizador aperte no simbolo, apareça os dados do Passeio.
        }


        public void Dias(int numDias)
        {
            lbl_dia.Text = numDias + "";
        }

    }

}
