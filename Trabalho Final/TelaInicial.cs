using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trabalho_Final
{
    public partial class TelaInicial : Form
    {
        Thread t1;

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new TelaJogo()); 
        }
    }
}
