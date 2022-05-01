using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class DialogueForm : Form
    {
        //id : 
        public DialogueForm()
        {
            InitializeComponent();
            
        }
        Point p = new Point(241,443);
        bool back = false;
        bool back2 = false;
        bool back3 = false;
        bool back4 = false;
        int ite=0; //defini un repère pour la conversation
        string rep; //réponse
        bool voyant=false;
        bool tristesse; //indice satisfaction
        bool question; //indique si l'ordi vient de poser une question
        bool questOuverte;//indique si c'et une réponse oui-non qui est attendue ou une réponse plus complexe
        
        private void button1_Click(object sender, EventArgs e)
        {
            ok();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            TBordi.Text = "BIH240: Bonjour!\r\nComment allez vous?\r\n"; //au demarage j'affiche toujours la meme phrase
            rep = "";
            timer1.Start();

        }

        private void TBclient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                ok();
                e.Handled = true;
                Focus();
            }
        }

        private void ok()
        {
            ite++;
            TBordi.Text =  TBordi.Text + "\r\n\r\nVous: " + TBclient.Text;    //je fais un historique de la discussion dans TBordi pour ensuite vider la TBclient       
            reponse();
            TBclient.Clear();
            TBordi.SelectionStart = TBordi.Text.Length;
            //TBordi.ScrollToCaret();

            if (tristesse==false)
            {
                Satisfaction.BackColor = Color.Gold;
            }
            else if (tristesse==true)
            {
                Satisfaction.BackColor = Color.Black;
            }
        }

        private void reponse()
        {
           
            if (ite == 1)
            {
                if (rep.Contains("ca va")|rep.Contains("bien") | rep.Contains("labesse") | rep.Contains("tranquille") | rep.Contains("tranquil") | rep.Contains("good") | rep.Contains("et toi") | rep.Contains("ça va"))
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nCool!";

                }
                else
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nDommage";
                    tristesse = true;
                }
                TBordi.Text = TBordi.Text + "\r\n\r\nTu aime les frites?";

            }

            if (ite == 2)
            {
                if (rep.Contains("oui") | rep.Contains("bien") | rep.Contains("labesse") | rep.Contains("tranquille") | rep.Contains("tranquil") | rep.Contains("good") | rep.Contains("et toi"))
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nCool!";
                    
                }
                else if(rep.Contains("non") | (rep.Contains("pa")&& rep.Contains("tro")))
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nDommage";                    
                }               
                else 
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nJe te demande pas de raconter ta vie";
                }               
                     TBordi.Text = TBordi.Text + "\r\n\r\nTu aime le sel?";
                }                
            if (ite==3)
            {
                    TBordi.Text= TBordi.Text + "\r\n\r\nOk, assez parlé de nous, tu veux que je te lise l'avenir?";
            }

               
                
            
            
            if (ite==4)
            {
                if (rep.Contains("oui")| rep.Contains("ouai") | rep.Contains("ye") | rep.Contains("yo") )
                {
                    voyant = true;
                    TBordi.Text = TBordi.Text + "\r\n\r\nOk tiens toi prêt, essaye de te contracter et pense à n'importe quelle question qui te passe par la tête.\r\n\r\nTape ensuite ta question et j'essayerai d'y répondre grace à mes dons incroyables...";
                }
                else 
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nBon bein tant pis, tu pourra pas voir mes supers pouvoir de machine folle.\r\nVous êtes sur de ne pas vouloir tester?";
                }
            }
            if (ite >4 && ite<15)
            {
                if (voyant == true)
                {
                    voyance();
                }
                else if (voyant == false && ite == 5)
                {
                    if (rep.Contains("oui") | rep.Contains("ouai") | rep.Contains("ye") | rep.Contains("yo") | rep.Contains("certain") | rep.Contains(""))
                    {
                        TBordi.Text = TBordi.Text + "\r\n\r\nOk tant pis on peut pas faire et marcher dedans.\r\nJe suis fatigué je crois que je vais te laisser.";
                    }
                    else
                    {
                        voyant = true;
                        TBordi.Text = TBordi.Text + "\r\n\r\nOk tiens toi prêt, essaye de te contracter et tape ta question.";
                    }
                }
                    if (voyant == false && ite == 6)
                    {
                        if (rep.Contains("no")| rep.Contains("pa"))
                        {
                            TBordi.Text = TBordi.Text + "\r\n\r\nOk, je prend ça pour un oui! tiens toi prêt, essaye de te contracter et pense à n'importe quelle question qui te passe par la tête.\r\n\r\nTape ensuite ta question et j'essayerai d'y répondre grace à mes dons incroyables...";
                            voyant = true;
                        }
                        else
                        {
                            TBordi.Text = TBordi.Text + "\r\n\r\nok à plus";
                        }

                    }
                    if (voyant == false && ite == 7)
                    {
                        Close();
                    }

                
            }
            if (ite==15)
            {
                TBordi.Text = TBordi.Text + "\r\n\r\nJe suis fatigué je crois que je vais te laisser.Reviens me voir bientôt!";
            }
            if (ite==16)
            {
                Close();
            }

        }

        private void voyance()
        {
            //bool combien= false;

           
             
            if (rep.Contains("lesquels") | rep.Contains("desquels") | rep.Contains("auxquels") | rep.Contains("des quels")| rep.Contains("les quels"))
            {
                Random rdm = new Random();
                int couleur = rdm.Next(0, 10);
                string[] tcouleur = { "rouges ", "bleus ", "verts ", "jaunes ", "marrons ", "oranges ", "", "", "", "" };
                int forme = rdm.Next(0, 10);
                string[] tforme = { "ronds ", "carrés ", "circulaires ", "triangulaires ", "", "", "", "", "", "" };
                int gout = rdm.Next(0, 10);
                string[] tgout = { "piquants ", "veloutés ", "acides ", "amers ", "", "", "", "", "", "" };
                int aspect = rdm.Next(0, 10);
                string[] taspect = { "dégoutants ", "énervants ", "envoutants ", "", "", "sublimes ", "", "", "", "" };
                int odeur = rdm.Next(0, 10);
                string[] todeur = { "puants ", "ennivrants ", "", "", "", "", "", "", "", "" };
                TBordi.Text = TBordi.Text + "\r\n\r\nLes "  + tforme[forme] + tcouleur[couleur] + tgout[gout] + taspect[aspect] + todeur[odeur];

            }
            else if (rep.Contains("lesquelles") | rep.Contains("desquelles") | rep.Contains("auxquelles") | rep.Contains("des quelles") | rep.Contains("aux quelles")|rep.Contains("les quelles"))
            {
                Random rdm = new Random();
                int couleur = rdm.Next(0, 10);
                string[] tcouleur = { "rouges ", "bleues ", "vertes ", "jaunes ", "marrons ", "oranges ", "", "", "", "" };
                int forme = rdm.Next(0, 10);
                string[] tforme = { "rondes ", "carrées ", "circulaires ", "triangulaires ", "", "", "", "", "", "" };
                int gout = rdm.Next(0, 10);
                string[] tgout = { "piquantes ", "veloutées ", "acides ", "amères ", "", "", "", "", "", "" };
                int aspect = rdm.Next(0, 10);
                string[] taspect = { "dégoutantes ", "énervantes ", "envoutantes ", "", "", "sublimes ", "", "", "", "" };
                int odeur = rdm.Next(0, 10);
                string[] todeur = { "puantes ", "ennivrantes ", "", "", "", "", "", "", "", "" };
                TBordi.Text = TBordi.Text + "\r\n\r\nLes " + tforme[forme] + tcouleur[couleur] + tgout[gout] + taspect[aspect] + todeur[odeur];

            }
            else if (rep.Contains("quelle") | rep.Contains("laquelle") | rep.Contains("la quelle"))
            {Random rdm = new Random();
                if (rep.Contains("partie") | rep.Contains("profondeur") | rep.Contains("condition") | rep.Contains("altitude") | rep.Contains("heure") | rep.Contains("vitesse")
                    | rep.Contains("vitesse"))
                {
                    int cpt = rdm.Next(0, 500);
                    
                    TBordi.Text = TBordi.Text + "\r\n\r\n"+cpt ;
                }
                else
                {
                int couleur = rdm.Next(0, 10);
                string[] tcouleur = { "rouge ", "bleu ", "vert ", "jaune ", "marron ", "orange ", "", "", "", "" };
                int forme = rdm.Next(0, 10);
                string[] tforme = { "ronde ", "carrée ", "grosse ", "petite ", "", "", "", "", "", "" };
                int gout = rdm.Next(0, 10);
                string[] tgout = { "piquante ", "veloutée ", "acide ", "amère ", "", "", "", "", "", "" };
                int aspect = rdm.Next(0, 10);
                string[] taspect = { "dégoutante ", "énervante ", "envoutante ", "", "", "sublime ", "", "", "", "" };
                int odeur = rdm.Next(0, 10);
                string[] todeur = { "puante ", "ennivrante ", "", "", "", "", "", "", "", "" };
                TBordi.Text = TBordi.Text + "\r\n\r\nLa " + tforme[forme] + tcouleur[couleur] + tgout[gout] + taspect[aspect] + todeur[odeur];
                }
                
                
            }
            else if (rep.Contains("quel") | rep.Contains("lequel") | rep.Contains("duquel") | rep.Contains("auquel") | rep.Contains("le quel"))
            {Random rdm = new Random();
                if (rep.Contains("age"))
                {
                    int cpt = rdm.Next(1,100);
                    if (cpt==1)
                    {
                        TBordi.Text = TBordi.Text + "\r\n\r\n" + cpt + "an";
                    }
                    else
                    {
                        TBordi.Text = TBordi.Text + "\r\n\r\n" + cpt+"ans";
                    }
                    
                }
                else
                if (rep.Contains("poid") | rep.Contains("altitude") | rep.Contains("mesure") | rep.Contains("heure"))
                {
                    int cpt = rdm.Next(0, 8000);

                    TBordi.Text = TBordi.Text + "\r\n\r\n" + cpt;
                }
                else
                {

                int couleur = rdm.Next(0, 10);
                string[] tcouleur = { "rouge ", "bleu ", "vert ", "jaune ", "marron ", "orange ", "", "", "", "" };
                int forme = rdm.Next(0, 10);
                string[] tforme = { "rond ", "carré ", "circulaire ", "triangle ", "", "", "", "", "", "" };
                int gout = rdm.Next(0, 10);
                string[] tgout = { "piquant ", "velouté ", "acide ", "amer ", "", "", "", "", "", "" };
                int aspect = rdm.Next(0, 10);
                string[] taspect = { "dégoutant ", "énervant ", "envoutant ", "", "", "sublime ", "", "", "", "" };
                int odeur = rdm.Next(0, 10);
                string[] todeur = { "puant ", "ennivrant ", "", "", "", "", "", "", "", "" };
                TBordi.Text = TBordi.Text + "\r\n\r\nLe " + tforme[forme] + tcouleur[couleur] + tgout[gout] + taspect[aspect] + todeur[odeur];
                }
                

            }
            //else if (rep.Contains("lequel") | rep.Contains("laquelle") | rep.Contains("lesquels") | rep.Contains("lesquelles") | rep.Contains("duquel") | rep.Contains("desquels") 
            //| rep.Contains("auquel") | rep.Contains("auxquels"))
            //{

            //}
            //else if (rep.Contains("quel") | rep.Contains("quelle") | rep.Contains("quels") | rep.Contains("quelles"))
            //{

            //}
            else if (rep.Contains("qui"))
            {
                Random rdm = new Random();
                int sexe = rdm.Next(0,2);
                string[] tsexe = { "un homme", "une femme" };
                int riche = rdm.Next(0, 3);
                string[] triche = { " riche", " ", " pauvre" };
                int hostile = rdm.Next(0, 5);
                string[] thostile = { "néfaste", "qui te veut du mal", "", "sympathique", "qui va t'aider" };
                TBordi.Text = TBordi.Text + "\r\n\r\n" + tsexe[sexe]+ triche[riche]         ;
                if (riche==0||riche==2)
                {
                    if (hostile==0||hostile==3)
                    {
                        TBordi.Text = TBordi.Text + " et " + thostile[hostile];
                    }
                    else
                    {
                        TBordi.Text = TBordi.Text + " " + thostile[hostile];
                    }
                }
                else
                {
                    TBordi.Text = TBordi.Text + " " + thostile[hostile];
                }



            }
            //else if (rep.Contains("a quoi")| rep.Contains("à quoi"))
            //{
            //    TBordi.Text = TBordi.Text + "\r\n\r\nIl y a tellement de possibilités";
            //}
            
            else if (rep.Contains("où") | rep.Contains("ou ") | rep.Contains("ou?"))
            {
                Random rdm = new Random();
                int ouija = rdm.Next(0, 4);
                string[] temp = { "ici", "à l'est", "à l'ouest", "au nord", "au sud" };
                TBordi.Text = TBordi.Text + "\r\n\r\n" + temp[ouija];
            }
            //else if (rep.Contains("que"))
            //{
            //    TBordi.Text = TBordi.Text + "\r\n\r\nIl y a tellement de possibilités";
            //}
            else if (rep.Contains("combien") && (rep.Contains("temps") | rep.Contains("an") | rep.Contains("mois") | rep.Contains("semaine") | rep.Contains("jour") | 
                rep.Contains("heure") | rep.Contains("seconde")) )
            {

                Random rdm = new Random();
                int dans = rdm.Next(0, 7);
                string[] tdans = { "dans ", "", "il y a ", "", "dans ", "", "dans " };
                int ouija = rdm.Next(1, 120);
                string[] temp = { "mois", "an", "mois", "semaine", "jour", "heure", "seconde" };
                int an = rdm.Next(0, 6);
                TBordi.Text = TBordi.Text + "\r\n\r\n"+tdans[dans] + ouija + " " + temp[an];
                if (ouija > 1 && an != 2)
                {
                    TBordi.Text = TBordi.Text + "s";
                }
            }
            else if (rep.Contains("combien"))
            {
                Random rdm = new Random();
                int ouija = rdm.Next(1, 120);
                TBordi.Text = TBordi.Text + ouija;
            }
            else if (rep.Contains("commen")| rep.Contains("comen"))
            {
                TBordi.Text = TBordi.Text + "\r\n\r\nsi je le savais...";
            }
            else if (rep.Contains("pourquoi")| rep.Contains("pourqoi")|rep.Contains("pourquo"))
            {
                TBordi.Text = TBordi.Text + "\r\n\r\nparce que.";
            }
            else if (rep.Contains("quoi"))
            {
                if (rep.Contains("sert") | rep.Contains("serv"))
                {
                    Random rdm = new Random();
                    int akoi = rdm.Next(0, 5);
                    string[] takoi = { "à rien", "à presque rien", "à tout", "à presque tout", "à faire chier", "à répandre l'amour" };
                    TBordi.Text = TBordi.Text + "\r\n\r\n" + takoi[akoi];
                }
                else
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nIl y a tellement de possibilités";
                }

            }
            else if (rep.Contains("quan") | rep.Contains("quand"))
            {
                Random rdm = new Random();
                int dans = rdm.Next(0, 7);
                string[] tdans = { "dans ", "", "il y a ", "", "dans ", "dans ", "dans " };
                int ouija = rdm.Next(1, 120);
                string[] temp = { "siècle", "an", "mois", "semaine", "jour", "heure", "seconde" };
                int an = rdm.Next(0, 6);
                TBordi.Text = TBordi.Text + "\r\n\r\n" + tdans[dans] + ouija + " " + temp[an];
                if (ouija>1 && an!=2)
                {
                    TBordi.Text = TBordi.Text + "s";
                }
            }
            else if (rep.Contains("qu'") | rep.Contains("qu "))
            {
                Random rdm = new Random();
                int dans = rdm.Next(0, 7);
                string[] tdans = { "dans ", "", "il y a ", "", "dans ", "dans ", "dans " };
                int ouija = rdm.Next(1, 120);
                string[] temp = { "siècle", "an", "mois", "semaine", "jour", "heure", "seconde" };
                int an = rdm.Next(0, 6);
                TBordi.Text = TBordi.Text + "\r\n\r\n" + tdans[dans] + ouija + " " + temp[an];
                if (ouija > 1 && an != 2)
                {
                    TBordi.Text = TBordi.Text + "s";
                }
            }
            else if (rep.Contains("pas"))
            {
                Random rdm = new Random();
                int ouija = rdm.Next(1, 3);
                if (ouija == 1)
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nSi";
                }
                else
                {
                    TBordi.Text = TBordi.Text + "\r\n\r\nNon";
                }
            }

            else
            {
                Random rdm = new Random();
                
                    int ouija= rdm.Next(1, 3);
                    if (ouija==1)
                    {
                        TBordi.Text = TBordi.Text + "\r\n\r\noui";
                    }
                    else
                    {
                         TBordi.Text = TBordi.Text + "\r\n\r\nnon";
                    }
                
                
            }



         
        }

        private void TBclient_TextChanged(object sender, EventArgs e)
        {
            rep = TBclient.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rapport_de_plantage rap = new rapport_de_plantage(TBordi.Text);
            rap.Show();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TBclient.Text = "non";
            ok();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBclient.Text = "oui";
            ok();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (button3.Width<181 && back == false)
            {
                 button3.Width++;
                 if (button3.Width == 180)
                {
                    back = true;
                }
            }
            
            else if (back==true)
            {
                button3.Width--;

                if (button3.Width == 100)
                {
                     back = false;
                }
            }
            if (button3.Height < 141 && back2 == false)
            {
                button3.Height++;
                if (button3.Height == 130)
                {
                    back2 = true;
                }
            }

            else if (back2 == true)
            {
                button3.Height--;

                if (button3.Height == 60)
                {
                    back2 = false;
                }
            }




        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button1.Height < 141 && back2 == false)
            {
                button1.Height++;
                if (button1.Height == 130)
                {
                    back2 = true;
                }
            }

            else if (back2 == true)
            {
                button1.Height--;

                if (button1.Height == 100)
                {
                    back2 = false;
                }
            }
            if (button3.Width < 181 && back == false)
            {
                button3.Width++;
                if (button3.Width == 180)
                {
                    back = true;
                }
            }

            else if (back == true)
            {
                button3.Width--;

                if (button3.Width == 100)
                {
                    back = false;
                }
            }
            
            
            if (button4.Height < 141 && back3 == false)
            {
                button4.Height++;
                p.X++;
                p.Y--;
                button4.Location=p;
                if (button4.Height == 130)
                {
                    back3 = true;
                }
            }

            else if (back3 == true)
            {
                button4.Height--;
                p.X--;
                p.Y++;
                button4.Location = p;

                if (button4.Height == 60)
                {
                    back3 = false;
                }
            }
            if (button3.Width < 181 && back == false)
            {
                button3.Width++;
                if (button3.Width == 180)
                {
                    back = true;
                }
            }

            else if (back == true)
            {
                button3.Width--;

                if (button3.Width == 100)
                {
                    back = false;
                }
            }
            if (button2.Height < 141 && back4 == false)
            {
                button2.Height++;
                if (button2.Height == 130)
                {
                    back4 = true;
                }
            }

            else if (back4 == true)
            {
                button2.Height--;

                if (button2.Height == 60)
                {
                    back4 = false;
                }
            }


            //if (button1.Height < 141)
            //{
            //    button1.Height++;
            //}
        }
    }
}
