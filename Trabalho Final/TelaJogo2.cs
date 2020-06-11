using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Trabalho_Final
{
    public partial class TelaJogo2 : Form
    {
        public TelaJogo2()
        {
            InitializeComponent();
            cronometro.Start();
        }

        PilhaPoiçõesDificil pilha = new PilhaPoiçõesDificil();

        //MouseDown
        private void Peca1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(peca1, DragDropEffects.Move);

        }
        private void Peca2_MouseDown(object sender, MouseEventArgs e)
        {
            if (panel4.Contains(peca2) && panel1.Contains(peca1) || panel5.Contains(peca2) && panel2.Contains(peca1) || panel6.Contains(peca2) && panel3.Contains(peca1) || panel7.Contains(peca2) && panel4.Contains(peca1) || panel8.Contains(peca2) && panel5.Contains(peca1) || panel9.Contains(peca2) && panel6.Contains(peca1) || panel10.Contains(peca2) && panel7.Contains(peca1) || panel11.Contains(peca2) && panel8.Contains(peca1) || panel12.Contains(peca2) && panel9.Contains(peca1) || panel13.Contains(peca2) && panel10.Contains(peca1) || panel14.Contains(peca2) && panel11.Contains(peca1) || panel15.Contains(peca2) && panel12.Contains(peca1))
                DoDragDrop(peca2, DragDropEffects.None);
            else
                DoDragDrop(peca2, DragDropEffects.Move);
        }
        private void Peca3_MouseDown(object sender, MouseEventArgs e)
        {
            if ((panel7.Contains(peca3) && (panel4.Contains(peca2) || panel4.Contains(peca1))) || (panel8.Contains(peca3) && (panel5.Contains(peca2) || panel5.Contains(peca1))) || (panel9.Contains(peca3) && (panel6.Contains(peca2) || panel6.Contains(peca1))) || (panel10.Contains(peca3) && (panel7.Contains(peca2) || panel7.Contains(peca1))) || (panel11.Contains(peca3) && (panel8.Contains(peca2) || panel8.Contains(peca1))) || (panel12.Contains(peca3) && (panel9.Contains(peca2) || panel9.Contains(peca1))) || (panel13.Contains(peca3) && (panel10.Contains(peca2) || panel10.Contains(peca1))) || (panel14.Contains(peca3) && (panel11.Contains(peca2) || panel11.Contains(peca1))) || (panel15.Contains(peca3) && (panel12.Contains(peca2) || panel12.Contains(peca1))))
                DoDragDrop(peca3, DragDropEffects.None);
            else
                DoDragDrop(peca3, DragDropEffects.Move);
        }
        private void Peca4_MouseDown(object sender, MouseEventArgs e)
        {
            if ((panel10.Contains(peca4) && (panel7.Contains(peca3) ||  panel7.Contains(peca2) || panel7.Contains(peca1))) || (panel11.Contains(peca4) && (panel8.Contains(peca3) || panel8.Contains(peca2) || panel8.Contains(peca1))) || (panel12.Contains(peca4) && (panel9.Contains(peca3) || panel9.Contains(peca2) || panel9.Contains(peca1))) || (panel13.Contains(peca4) && (panel10.Contains(peca3) || panel10.Contains(peca2) || panel10.Contains(peca1))) || (panel14.Contains(peca4) && (panel11.Contains(peca3) || panel11.Contains(peca2) || panel11.Contains(peca1))) || (panel15.Contains(peca4) && (panel12.Contains(peca3) || panel12.Contains(peca2) || panel12.Contains(peca1))))
                DoDragDrop(peca4, DragDropEffects.None);
            else
                DoDragDrop(peca4, DragDropEffects.Move);
        }
        private void Peca5_MouseDown(object sender, MouseEventArgs e)
        {

            if ((panel13.Contains(peca5) && (panel10.Contains(peca4) || panel10.Contains(peca3) || panel10.Contains(peca2) || panel10.Contains(peca1)))  ||  (panel14.Contains(peca5) && (panel11.Contains(peca4) || panel11.Contains(peca3) || panel11.Contains(peca2) || panel11.Contains(peca1)))  ||  (panel15.Contains(peca5) && (panel12.Contains(peca4) || panel12.Contains(peca3) || panel12.Contains(peca2) || panel12.Contains(peca1))))
                DoDragDrop(peca5, DragDropEffects.None);
            else
                DoDragDrop(peca5, DragDropEffects.Move);
        }

        //DragEnter
        private void ControlaEfeito(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void ImpedirSobrepor1Coluna1(DragEventArgs e)
        {
            if (panel4.Contains(peca1) || panel7.Contains(peca1) || panel10.Contains(peca1) || panel13.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void ImpedirSobrepor1Coluna2(DragEventArgs e)
        {
            if (panel5.Contains(peca1) || panel8.Contains(peca1) || panel11.Contains(peca1) || panel14.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }
        private void ImpedirSobrepor1Coluna3(DragEventArgs e)
        {
            if (panel6.Contains(peca1) || panel9.Contains(peca1) || panel12.Contains(peca1) || panel15.Contains(peca1))
                e.Effect = DragDropEffects.None;
            else
                this.ControlaEfeito(e);
        }

        private void pnl1_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna1(e);
           
        }
        private void pnl2_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna2(e);
        }
        private void pnl3_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna3(e);
        }
        private void pnl4_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna1(e);
        }
        private void pnl5_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna2(e);
        }
        private void pnl6_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna3(e);
        }
        private void pnl7_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna1(e);
        }
        private void pnl8_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna2(e);
        }
        private void pnl9_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna3(e);
        }
        private void pnl10_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna1(e);
        }
        private void pnl11_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna2(e);
        }
        private void pnl12_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna3(e);
        }
        private void pnl13_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna1(e);
        }
        private void pnl14_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna2(e);
        }
        private void pnl15_DragEnter(object sender, DragEventArgs e)
        {
            ImpedirSobrepor1Coluna3(e);
        }


        //DragDrop
        private void pnl1_DragDrop(object sender, DragEventArgs e)
        {

            this.panel1.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            
            //Gravidade
            if (panel4.Contains(peca2) == false)
            {
                this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                

                if (panel7.Contains(peca2) == false && panel7.Contains(peca3) == false)
                {
                    this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    

                    if (panel10.Contains(peca2) == false && panel10.Contains(peca3) == false && panel10.Contains(peca4) == false)
                    {
                        this.panel10.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                        

                        if (panel13.Contains(peca2) == false && panel13.Contains(peca3) == false && panel13.Contains(peca4) == false && panel13.Contains(peca5) == false)
                        {
                            this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                           
                        }
                    }
                }
            }

            ImpedirSobreposiçãoColuna1(e);

        }
        private void pnl2_DragDrop(object sender, DragEventArgs e)
        {

            this.panel2.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));


            //Gravidade
            if (panel5.Contains(peca2) == false)
            {
                this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel8.Contains(peca2) == false && panel8.Contains(peca3) == false)
                {
                    this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    if (panel11.Contains(peca2) == false && panel11.Contains(peca3) == false && panel11.Contains(peca4) == false)
                    {
                        this.panel11.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                        if (panel14.Contains(peca2) == false && panel14.Contains(peca3) == false && panel14.Contains(peca4) == false && panel14.Contains(peca5) == false)
                            this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    }
                }
            }

            ImpedirSobreposiçãoColuna2(e);

        }
        private void pnl3_DragDrop(object sender, DragEventArgs e)
        {

            this.panel3.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

           

            //Gravidade
            if (panel6.Contains(peca2) == false)
            {
                this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel9.Contains(peca2) == false && panel9.Contains(peca3) == false)
                {
                    this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    if (panel12.Contains(peca2) == false && panel12.Contains(peca3) == false && panel12.Contains(peca4) == false)
                    {
                        this.panel12.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                        if (panel15.Contains(peca2) == false && panel15.Contains(peca3) == false && panel15.Contains(peca4) == false && panel15.Contains(peca5) == false)
                            this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    }
                }
            }


            ImpedirSobreposiçãoColuna3(e);

            ChecarVitoria();
        }
        private void pnl4_DragDrop(object sender, DragEventArgs e)
        {

            this.panel4.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            

            //Gravidade
            if (panel7.Contains(peca3) == false && panel7.Contains(peca2) == false)
            {
                this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel10.Contains(peca2) == false && panel10.Contains(peca3) == false && panel10.Contains(peca4) == false)
                {
                    this.panel10.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    if (panel13.Contains(peca2) == false && panel13.Contains(peca3) == false && panel13.Contains(peca4) == false && panel13.Contains(peca5) == false)
                        this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                }
            }

            ImpedirSobreposiçãoColuna1(e);

        }
        private void pnl5_DragDrop(object sender, DragEventArgs e)
        {

            this.panel5.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            

            //Gravidade
            if (panel8.Contains(peca3) == false && panel8.Contains(peca2) == false)
            {
                this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel11.Contains(peca2) == false && panel11.Contains(peca3) == false && panel11.Contains(peca4) == false)
                {
                    this.panel11.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    if (panel14.Contains(peca2) == false && panel14.Contains(peca3) == false && panel14.Contains(peca4) == false && panel14.Contains(peca5) == false)
                        this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                }
            }

            ImpedirSobreposiçãoColuna2(e);

        }
        private void pnl6_DragDrop(object sender, DragEventArgs e)
        {

            this.panel6.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            

            //Gravidade
            if (panel9.Contains(peca3) == false && panel9.Contains(peca2) == false)
            {
                this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel12.Contains(peca2) == false && panel12.Contains(peca3) == false && panel12.Contains(peca4) == false)
                {
                    this.panel12.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    if (panel15.Contains(peca2) == false && panel15.Contains(peca3) == false && panel15.Contains(peca4) == false && panel15.Contains(peca5) == false)
                        this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                }
            }

            ImpedirSobreposiçãoColuna3(e);

        }
        private void pnl7_DragDrop(object sender, DragEventArgs e)
        {

            this.panel7.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel10.Contains(peca2) == false && panel10.Contains(peca3) == false && panel10.Contains(peca4) == false)
            {
                this.panel10.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel13.Contains(peca2) == false && panel13.Contains(peca3) == false && panel13.Contains(peca4) == false && panel13.Contains(peca5) == false)
                    this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            }

            ImpedirSobreposiçãoColuna1(e);

        }
        private void pnl8_DragDrop(object sender, DragEventArgs e)
        {

            this.panel8.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel11.Contains(peca2) == false && panel11.Contains(peca3) == false && panel11.Contains(peca4) == false)
            {
                this.panel11.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel14.Contains(peca2) == false && panel14.Contains(peca3) == false && panel14.Contains(peca4) == false && panel14.Contains(peca5) == false)
                    this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            }

            ImpedirSobreposiçãoColuna2(e);

        }
        private void pnl9_DragDrop(object sender, DragEventArgs e)
        {

            this.panel9.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            //Gravidade
            if (panel12.Contains(peca2) == false && panel12.Contains(peca3) == false && panel12.Contains(peca4) == false)
            {
                this.panel12.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                if (panel15.Contains(peca2) == false && panel15.Contains(peca3) == false && panel15.Contains(peca4) == false && panel15.Contains(peca5) == false)
                    this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
            }

            ImpedirSobreposiçãoColuna3(e);

        }
        private void pnl10_DragDrop(object sender, DragEventArgs e)
        {

            this.panel10.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel13.Contains(peca2) == false && panel13.Contains(peca3) == false && panel13.Contains(peca4) == false && panel13.Contains(peca5) == false)
                this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna1(e);

        }
        private void pnl11_DragDrop(object sender, DragEventArgs e)
        {

            this.panel11.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel14.Contains(peca2) == false && panel14.Contains(peca3) == false && panel14.Contains(peca4) == false && panel14.Contains(peca5) == false)
                this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna2(e);

        }
        private void pnl12_DragDrop(object sender, DragEventArgs e)
        {

            this.panel12.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            if (panel15.Contains(peca2) == false && panel15.Contains(peca3) == false && panel15.Contains(peca4) == false && panel15.Contains(peca5) == false)
                this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna3(e);

        }
        private void pnl13_DragDrop(object sender, DragEventArgs e)
        {

            this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna1(e);

        }
        private void pnl14_DragDrop(object sender, DragEventArgs e)
        {

            this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna2(e);

        }
        private void pnl15_DragDrop(object sender, DragEventArgs e)
        {

            this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));

            ImpedirSobreposiçãoColuna3(e);

        }


    //Vitoria
        private void ChecarVitoria()
        {
            if (panel3.Contains(peca1) && panel6.Contains(peca2) && panel9.Contains(peca3))
            {
                cronometro.Stop();
                MessageBox.Show("Parabéns! Você ganhou em " + cronometro.Elapsed.Minutes.ToString() + " minutos e " + cronometro.Elapsed.Seconds.ToString() + " segundos!! Fim de jogo.");
              
            }
        }

        //Mover peça
        private void MoverPeca(int UltimoPainel, object sender, DragEventArgs e)
        {
            switch (UltimoPainel)
            {
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
                case 10:
                    this.panel10.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 11:
                    this.panel11.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 12:
                    this.panel12.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 13:
                    this.panel13.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 14:
                    this.panel14.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;
                case 15:
                    this.panel15.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
                    break;


            }
        }

        //Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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
                lblSegundos.Text = "0" + cronometro.Elapsed.Seconds.ToString();
            else
                lblSegundos.Text = cronometro.Elapsed.Seconds.ToString();
        }

        //Impedir sobrepoisção (3, 4 e 5)
        private void ImpedirSobreposiçãoColuna1(DragEventArgs e)
        {

            
            //3
            if (panel4.Contains(peca3))
                pilha.AddPeca3(4);
            else if (panel7.Contains(peca3))
                pilha.AddPeca3(7);
            else if (panel10.Contains(peca3))
                pilha.AddPeca3(10);
            else if (panel13.Contains(peca3))
                pilha.AddPeca3(13);

            if (panel7.Contains(peca2) && panel4.Contains(peca3) || panel10.Contains(peca2) && panel7.Contains(peca3) || panel13.Contains(peca2) && panel10.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPeca3();
                MoverPeca(UltimoPaineil, peca3, e);
            }

            //4
            if (panel4.Contains(peca4))
                pilha.AddPeca4(4);
            else if (panel7.Contains(peca4))
                pilha.AddPeca4(7);
            else if (panel10.Contains(peca4))
                pilha.AddPeca4(10);
            else if (panel13.Contains(peca4))
                pilha.AddPeca4(13);


            if (panel4.Contains(peca4) && (panel7.Contains(peca2) || panel7.Contains(peca3)) || panel7.Contains(peca4) && (panel10.Contains(peca2) || panel10.Contains(peca3)) || panel10.Contains(peca4) && (panel13.Contains(peca2) || panel13.Contains(peca3)))
            {
                int UltimoPaineil = pilha.RemoverPeca4();
                MoverPeca(UltimoPaineil, peca4, e);
            }

            //5
            if (panel4.Contains(peca5))
                pilha.AddPeca5(4);
            else if (panel7.Contains(peca5))
                pilha.AddPeca5(7);
            else if (panel10.Contains(peca5))
                pilha.AddPeca5(10);
            else if (panel13.Contains(peca5))
                pilha.AddPeca5(13);

            if (panel4.Contains(peca5) && (panel7.Contains(peca2) || panel7.Contains(peca3) || panel7.Contains(peca4)) || panel7.Contains(peca5) && (panel10.Contains(peca2) || panel10.Contains(peca3) || panel10.Contains(peca4)) || panel10.Contains(peca5) && (panel13.Contains(peca2) || panel13.Contains(peca3) || panel13.Contains(peca4)))
            {
                int UltimoPaineil = pilha.RemoverPeca5();
                MoverPeca(UltimoPaineil, peca5, e);
            }

        }
        private void ImpedirSobreposiçãoColuna2(DragEventArgs e)
        {
            
            //3
            if (panel5.Contains(peca3))
                pilha.AddPeca3(5);
            else if (panel8.Contains(peca3))
                pilha.AddPeca3(8);
            else if (panel11.Contains(peca3))
                pilha.AddPeca3(11);
            else if (panel14.Contains(peca3))
                pilha.AddPeca3(14);

            if (panel8.Contains(peca2) && panel5.Contains(peca3) || panel11.Contains(peca2) && panel8.Contains(peca3) || panel14.Contains(peca2) && panel11.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPeca3();
                MoverPeca(UltimoPaineil, peca3, e);
            }

            //4
            if (panel5.Contains(peca4))
                pilha.AddPeca4(5);
            else if (panel8.Contains(peca4))
                pilha.AddPeca4(8);
            else if (panel11.Contains(peca4))
                pilha.AddPeca4(11);
            else if (panel14.Contains(peca4))
                pilha.AddPeca4(14);


            if (panel5.Contains(peca4) && (panel8.Contains(peca2) || panel8.Contains(peca3)) || panel8.Contains(peca4) && (panel11.Contains(peca2) || panel11.Contains(peca3)) || panel11.Contains(peca4) && (panel14.Contains(peca2) || panel14.Contains(peca3)))
            {
                int UltimoPaineil = pilha.RemoverPeca4();
                MoverPeca(UltimoPaineil, peca4, e);
            }

            //5
            if (panel5.Contains(peca5))
                pilha.AddPeca5(5);
            else if (panel8.Contains(peca5))
                pilha.AddPeca5(8);
            else if (panel11.Contains(peca5))
                pilha.AddPeca5(11);
            else if (panel14.Contains(peca5))
                pilha.AddPeca5(14);

            if (panel5.Contains(peca5) && (panel8.Contains(peca2) || panel8.Contains(peca3) || panel8.Contains(peca4)) || panel8.Contains(peca5) && (panel11.Contains(peca2) || panel11.Contains(peca3) || panel11.Contains(peca4)) || panel11.Contains(peca5) && (panel14.Contains(peca2) || panel14.Contains(peca3) || panel14.Contains(peca4)))
            {
                int UltimoPaineil = pilha.RemoverPeca5();
                MoverPeca(UltimoPaineil, peca5, e);
            }
        }
        private void ImpedirSobreposiçãoColuna3(DragEventArgs e)
        {
            
            //3
            if (panel6.Contains(peca3))
                pilha.AddPeca3(6);
            else if (panel9.Contains(peca3))
                pilha.AddPeca3(9);
            else if (panel12.Contains(peca3))
                pilha.AddPeca3(12);
            else if (panel15.Contains(peca3))
                pilha.AddPeca3(15);

            if (panel9.Contains(peca2) && panel6.Contains(peca3) || panel12.Contains(peca2) && panel9.Contains(peca3) || panel15.Contains(peca2) && panel12.Contains(peca3))
            {
                int UltimoPaineil = pilha.RemoverPeca3();
                MoverPeca(UltimoPaineil, peca3, e);
            }

            //4
            if (panel6.Contains(peca4))
                pilha.AddPeca4(6);
            else if (panel9.Contains(peca4))
                pilha.AddPeca4(9);
            else if (panel12.Contains(peca4))
                pilha.AddPeca4(12);
            else if (panel15.Contains(peca4))
                pilha.AddPeca4(15);


            if (panel6.Contains(peca4) && (panel9.Contains(peca2) || panel9.Contains(peca3)) || panel9.Contains(peca4) && (panel12.Contains(peca2) || panel12.Contains(peca3)) || panel12.Contains(peca4) && (panel15.Contains(peca2) || panel15.Contains(peca3)))
            {
                int UltimoPaineil = pilha.RemoverPeca4();
                MoverPeca(UltimoPaineil, peca4, e);
            }

            //5
            if (panel6.Contains(peca5))
                pilha.AddPeca5(6);
            else if (panel9.Contains(peca5))
                pilha.AddPeca5(9);
            else if (panel12.Contains(peca5))
                pilha.AddPeca5(12);
            else if (panel15.Contains(peca5))
                pilha.AddPeca5(15);

            if (panel6.Contains(peca5) && (panel9.Contains(peca2) || panel9.Contains(peca3) || panel9.Contains(peca4)) || panel9.Contains(peca5) && (panel12.Contains(peca2) || panel12.Contains(peca3) || panel12.Contains(peca4)) || panel12.Contains(peca5) && (panel15.Contains(peca2) || panel15.Contains(peca3) || panel15.Contains(peca4)))
            {
                int UltimoPaineil = pilha.RemoverPeca5();
                MoverPeca(UltimoPaineil, peca5, e);
            }
        }


    }

    //Pilhas
    public class PilhaPoiçõesDificil
    {
        //Peça 3
        private Stack<int> PilhaPeca3 = new Stack<int>();
        public void AddPeca3(int painel)
        {
            if (PilhaPeca3.Count == 0)
                PilhaPeca3.Push(7);

            PilhaPeca3.Push(painel);            
        }
        public int RemoverPeca3()
        {
            if (PilhaPeca3.Count == 0)
                 PilhaPeca3.Push(7);
               

            PilhaPeca3.Pop();

            if (PilhaPeca3.Count == 0)
                PilhaPeca3.Push(7);

            int UltimoPainel = PilhaPeca3.Peek();

            return UltimoPainel;
        }


        //Peçpa 4
        private Stack<int> PilhaPeca4 = new Stack<int>();
        public void AddPeca4(int painel)
        {
            if (PilhaPeca4.Count == 0)
                PilhaPeca4.Push(10);

            PilhaPeca4.Push(painel);
        }
        public int RemoverPeca4()
        {
            if (PilhaPeca4.Count == 0)
                PilhaPeca4.Push(10);
            

            PilhaPeca4.Pop();


            if (PilhaPeca4.Count == 0)
                PilhaPeca4.Push(10);

            int UltimoPainel = PilhaPeca4.Peek();

            return UltimoPainel;
        }


        //Peça 5
        private Stack<int> PilhaPeca5 = new Stack<int>();
        public void AddPeca5(int painel)
        {
            if (PilhaPeca5.Count == 0)
                PilhaPeca5.Push(13);

            PilhaPeca5.Push(painel);
        }
        public int RemoverPeca5()
        {
            if (PilhaPeca5.Count == 0)
                PilhaPeca5.Push(13); 

            PilhaPeca5.Pop();

            if (PilhaPeca5.Count == 0)
                PilhaPeca5.Push(13);

            int UltimoPainel = PilhaPeca5.Peek();

            return UltimoPainel;
        }

    }


}


