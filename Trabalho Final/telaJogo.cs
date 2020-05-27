using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final
{
    public partial class TelaJogo : Form
    {
        public TelaJogo()
        {
            InitializeComponent();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //MouseDown
        private void Peca1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(peca1, DragDropEffects.Move);

        }
        private void Peca2_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(peca2, DragDropEffects.Move);

        }
        private void Peca3_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(peca3, DragDropEffects.Move);

        }

        //DragEnter
        private void ControlaEfeito(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.Panel)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        private void pnl1_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl2_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl3_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl4_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl5_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl6_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl7_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl8_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }
        private void pnl9_DragEnter(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }

        //DragDrop
        private void pnl1_DragDrop(object sender, DragEventArgs e)
        {
            this.panel1.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            /* Control c1 = this.tableLayoutPanel1.GetControlFromPosition(0, 0);
             Control c2 = this.tableLayoutPanel1.GetControlFromPosition(1, 1);
            ChecarVazio(c1,c2,1);*/

        }
        private void pnl2_DragDrop(object sender, DragEventArgs e)
        {
            this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
        }
        private void pnl3_DragDrop(object sender, DragEventArgs e)
        {
            this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
        }
        private void pnl4_DragDrop(object sender, DragEventArgs e)
        {
            this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
        }
        private void pnl5_DragDrop(object sender, DragEventArgs e)
        {
            this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
          
        }
        private void pnl6_DragDrop(object sender, DragEventArgs e)
        {
            this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
           
        }
        private void pnl7_DragDrop(object sender, DragEventArgs e)
        {
            this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
        }
        private void pnl8_DragDrop(object sender, DragEventArgs e)
        {
            this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
          
        }
        private void pnl9_DragDrop(object sender, DragEventArgs e)
        {
            this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
        }


        //Gravidade
       /* public void ChecarVazio(Control c1, Control c2, int linha)
        {

            if (c2.Controls != null)
            {
                this.tableLayoutPanel1.SetRow(c1, linha);
            }
           
        }*/


    }
}
