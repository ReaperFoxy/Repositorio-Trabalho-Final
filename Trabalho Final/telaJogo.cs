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
            if (e.Data.GetDataPresent(typeof(Panel)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }


        private void pnl1_DragEnter(object sender, DragEventArgs e)
        {
            if (panel7.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else if (panel4.Contains(peca1))
                e.Effect = DragDropEffects.None;
            //Lembrar limitar o 3
            else
                this.ControlaEfeito(e);
        }
        private void pnl2_DragEnter(object sender, DragEventArgs e)
        {
            if (panel8.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else if (panel5.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void pnl3_DragEnter(object sender, DragEventArgs e)
        {
            if (panel9.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else if (panel6.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void pnl4_DragEnter(object sender, DragEventArgs e)
        {
            if (panel7.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void pnl5_DragEnter(object sender, DragEventArgs e)
        {
            if (panel8.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void pnl6_DragEnter(object sender, DragEventArgs e)
        {
            if (panel9.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
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

            //Gravidade
            if (panel4.Contains(peca2) == false)
                this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca2) == false && panel7.Contains(peca3) == false)
                this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca3) == true && panel4.Contains(peca2) == true)
                this.panel1.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca3) == true && panel1.Contains(peca2) == true)
                this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Condição Maior/Menor
            //Se sobrepor peça maior -> cancelar ação
            if (panel7.Contains(peca1))
                e.Effect = DragDropEffects.None;

        }
        private void pnl2_DragDrop(object sender, DragEventArgs e)
        {
            this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel5.Contains(peca2) == false)
                this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca2) == false && panel8.Contains(peca3) == false)
                this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca3) == true && panel5.Contains(peca2) == true)
                this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca3) == true && panel2.Contains(peca2) == true)
                this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));


        }
        private void pnl3_DragDrop(object sender, DragEventArgs e)
        {
            this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel6.Contains(peca2) == false)
                this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca2) == false && panel9.Contains(peca3) == false)
                this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca3) == true && panel6.Contains(peca2) == true)
                this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca3) == true && panel3.Contains(peca2) == true)
                this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ChecarVitoria();
        }
        private void pnl4_DragDrop(object sender, DragEventArgs e)
        {
            this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel7.Contains(peca3) == false && panel7.Contains(peca2) == false)
                this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

        }
        private void pnl5_DragDrop(object sender, DragEventArgs e)
        {
            this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel8.Contains(peca3) == false && panel8.Contains(peca2) == false)
                this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

        }
        private void pnl6_DragDrop(object sender, DragEventArgs e)
        {
            this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel9.Contains(peca3) == false && panel9.Contains(peca2) == false)
                this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
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


        //Vitoria
        private void ChecarVitoria()
        {
            if (panel3.Contains(peca1) && panel6.Contains(peca2) && panel9.Contains(peca3))
            {
                //Lembrar colocar premios
                MessageBox.Show("Parabéns! Você ganhou!!");

            }

        }

        
    }
}
