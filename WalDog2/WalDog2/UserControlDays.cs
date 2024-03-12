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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void Dias(int numDias)
        {
            lbl_dia.Text = numDias + "";
        }

        private void pbox_marcacao_Click(object sender, EventArgs e)
        {
            // Caso o utilizador aperte no simbolo, apareça os dados do Passeio.
        }
    }
}
