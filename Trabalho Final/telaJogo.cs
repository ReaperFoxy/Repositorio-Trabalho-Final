using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Trabalho_Final
{
    public partial class TelaJogo : Form
    {
        Thread t2;

        public TelaJogo()
        {

            InitializeComponent();
            cronometro.Start();

        }

        PilhaPoições pilha = new PilhaPoições();



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
            if (panel4.Contains(peca2) && panel1.Contains(peca1) || panel5.Contains(peca2) && panel2.Contains(peca1) || panel6.Contains(peca2) && panel3.Contains(peca1) || panel7.Contains(peca2) && panel4.Contains(peca1) || panel8.Contains(peca2) && panel5.Contains(peca1) || panel9.Contains(peca2) && panel6.Contains(peca1))
                DoDragDrop(peca2, DragDropEffects.None);
            else
                DoDragDrop(peca2, DragDropEffects.Move);

        }
        private void Peca3_MouseDown(object sender, MouseEventArgs e)
        {
            if (panel7.Contains(peca3) && panel4.Contains(peca2) || panel8.Contains(peca3) && panel5.Contains(peca2) || panel9.Contains(peca3) && panel6.Contains(peca2) || panel7.Contains(peca3) && panel4.Contains(peca1) || panel8.Contains(peca3) && panel5.Contains(peca1) || panel9.Contains(peca3) && panel6.Contains(peca1))
                DoDragDrop(peca3, DragDropEffects.None);
            else
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
           
            if (panel1.Contains(peca3))
                pilha.AddPainel(7);

            //Gravidade
            if (panel4.Contains(peca2) == false)
                this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca2) == false && panel7.Contains(peca3) == false)
                this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca3) == true && panel4.Contains(peca2) == true)
                this.panel1.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel7.Contains(peca3) == true && panel1.Contains(peca2) == true)
                this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir Sobreposição
            //3
            if (panel7.Contains(peca2) && panel4.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }
            
        }
        private void pnl2_DragDrop(object sender, DragEventArgs e)
        {
            
            this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
            if (panel2.Contains(peca3))
                pilha.AddPainel(8);


            //Gravidade
            if (panel5.Contains(peca2) == false)
                this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca2) == false && panel8.Contains(peca3) == false)
                this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca3) == true && panel5.Contains(peca2) == true)
                this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel8.Contains(peca3) == true && panel2.Contains(peca2) == true)
                this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir 3 sobre 2
            if (panel8.Contains(peca2) && panel5.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }

        }
        private void pnl3_DragDrop(object sender, DragEventArgs e)
        {

            this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel3.Contains(peca3))
                pilha.AddPainel(9);

            //Gravidade
            if (panel6.Contains(peca2) == false)
                this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca2) == false && panel9.Contains(peca3) == false)
                this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca3) == true && panel6.Contains(peca2) == true)
                this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            if (panel9.Contains(peca3) == true && panel3.Contains(peca2) == true)
                this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir 3 sobre 2
            if (panel9.Contains(peca2) && panel6.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }

            ChecarVitoria();
        }
        private void pnl4_DragDrop(object sender, DragEventArgs e)
        {
            
            this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            
            if (panel4.Contains(peca3))
                pilha.AddPainel(7);

            //Gravidade
            if (panel7.Contains(peca3) == false && panel7.Contains(peca2) == false)
                this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir 3 sobre 2
            if (panel7.Contains(peca2) && panel4.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }

        }
        private void pnl5_DragDrop(object sender, DragEventArgs e)
        { 

            this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel5.Contains(peca3))
                pilha.AddPainel(8);

            //Gravidade
            if (panel8.Contains(peca3) == false && panel8.Contains(peca2) == false)
                this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir 3 sobre 2
            if (panel8.Contains(peca2) && panel5.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }

        }
        private void pnl6_DragDrop(object sender, DragEventArgs e)
        {

            this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel6.Contains(peca3))
                pilha.AddPainel(9);

            //Gravidade
            if (panel9.Contains(peca3) == false && panel9.Contains(peca2) == false)
                this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Impedir 3 sobre 2
            if (panel9.Contains(peca2) && panel6.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPainel();
                MoverPeca(UltimoPaineil, peca3, e);
            }

        }
        private void pnl7_DragDrop(object sender, DragEventArgs e)
        {

            this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel7.Contains(peca3))
                pilha.AddPainel(7);

        }
        private void pnl8_DragDrop(object sender, DragEventArgs e)
        {

            this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel8.Contains(peca3))
                pilha.AddPainel(8);

        }      
        private void pnl9_DragDrop(object sender, DragEventArgs e)
        {
           
            this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel9.Contains(peca3))
                pilha.AddPainel(9);
        }


        //Vitoria
        private void ChecarVitoria()
        {
            if (panel3.Contains(peca1) && panel6.Contains(peca2) && panel9.Contains(peca3))
            {
                cronometro.Stop();
                MessageBox.Show("Parabéns! Você ganhou!!");
                
                this.Close();
                t2 = new Thread(abrirJanela);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
            }
        }

        private void abrirJanela(object obj)
        {
                Application.Run(new TelaJogo2());
        }
 
        //Mover peça
        private void MoverPeca(int UltimoPainel, object sender, DragEventArgs e)
        {
            switch (UltimoPainel) {
                case 1:
                    this.panel1.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 2:
                    this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 3:
                    this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 4:
                    this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 5:
                    this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 6:
                    this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 7:
                    this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 8:
                    this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 9:
                    this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;

            }
        }


        //Cronometro
        Stopwatch cronometro = new Stopwatch();

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            if (cronometro.Elapsed.Minutes < 10)
                lblMinutos.Text = "0" + cronometro.Elapsed.Minutes.ToString();
            else
                lblMinutos.Text = cronometro.Elapsed.Minutes.ToString();

            if (cronometro.Elapsed.Seconds < 10)
                lblSegundos.Text = "0" +cronometro.Elapsed.Seconds.ToString();
            else
                lblSegundos.Text = cronometro.Elapsed.Seconds.ToString();
        }
    }


    //Pilhas
    public class PilhaPoições
    {

        private Stack<int> PilhaPaineis = new Stack<int>();
        public void AddPainel(int painel)
        {
            if (PilhaPaineis.Count == 0)
                PilhaPaineis.Push(7);

            PilhaPaineis.Push(painel);
        }

        public int RemoverPainel()
        {
            PilhaPaineis.Pop();

            int UltimoPainel = PilhaPaineis.Peek();

            return UltimoPainel;
        }

       

    }


}
