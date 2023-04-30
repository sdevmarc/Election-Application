using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myElectionAppSuarez
{
    public partial class Form1 : Form
    {
        VoteDisp Teresita = new VoteDisp();
        VoteDisp Gemalyn = new VoteDisp();

        VoteDisp Anton = new VoteDisp();
        VoteDisp Rodrigo = new VoteDisp();

        VoteDisp Ronald = new VoteDisp();
        VoteDisp Lenie = new VoteDisp();

        VoteDisp Francis = new VoteDisp();
        VoteDisp Joel = new VoteDisp();

        VoteDisp Trisha = new VoteDisp();
        VoteDisp Flor = new VoteDisp();

        VoteDisp Vhon = new VoteDisp();
        VoteDisp Herald = new VoteDisp();

        VoteDisp Gerald = new VoteDisp();
        VoteDisp Alpha = new VoteDisp();

        VoteDisp Jacob = new VoteDisp();
        VoteDisp Beauty = new VoteDisp();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbTeresita.Checked)
                {
                    Teresita.makeVote(1);
                    txtTeresita.Text = Teresita.getCount(1).ToString();


                }
                else if (rdbGemalyn.Checked)
                {
                    Gemalyn.makeVote(2);
                    txtGemalyn.Text = Gemalyn.getCount(2).ToString();

                }
                if (rdbAnton.Checked)
                {
                    Anton.makeVote(3);
                    txtAnton.Text = Anton.getCount(3).ToString();

                }
                else if (rdbRodrigo.Checked)
                {
                    Rodrigo.makeVote(4);
                    txtRodrigo.Text = Rodrigo.getCount(4).ToString();

                }
                if (rdbRonald.Checked)
                {
                    Ronald.makeVote(5);
                    txtRonald.Text = Ronald.getCount(5).ToString();

                }
                else if (rdbLenie.Checked)
                {
                    Lenie.makeVote(6);
                    txtLenie.Text = Lenie.getCount(6).ToString();

                }
                if (rdbFrancis.Checked)
                {
                    Francis.makeVote(7);
                    txtFrancis.Text = Francis.getCount(7).ToString();

                }
                else if (rdbJoel.Checked)
                {
                    Joel.makeVote(8);
                    txtJoel.Text = Joel.getCount(8).ToString();

                }
                if (rdbTrisha.Checked)
                {
                    Trisha.makeVote(9);
                    txtTrisha.Text = Trisha.getCount(9).ToString();

                }
                else if (rdbFlordeliza.Checked)
                {
                    Flor.makeVote(10);
                    txtFlordeliza.Text = Flor.getCount(10).ToString();

                }
                if (rdbVhon.Checked)
                {
                    Vhon.makeVote(11);
                    txtVhon.Text = Vhon.getCount(11).ToString();

                }
                else if (rdbHerald.Checked)
                {
                    Herald.makeVote(12);
                    txtHerald.Text = Herald.getCount(12).ToString();

                }
                if (rdbGerald.Checked)
                {
                    Gerald.makeVote(13);
                    txtGerald.Text = Gerald.getCount(13).ToString();

                }
                else if (rdbAlpha.Checked)
                {
                    Alpha.makeVote(14);
                    txtAlpha.Text = Alpha.getCount(14).ToString();

                }
                if (rdbJacob.Checked)
                {
                    Jacob.makeVote(15);
                    txtJacob.Text = Jacob.getCount(15).ToString();

                }
                else if (rdbBeauty.Checked)
                {
                    Beauty.makeVote(16);
                    txtBeauty.Text = Beauty.getCount(16).ToString();

                }    

                MessageBox.Show("Proceeding to vote!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdbTeresita.Checked = false;
                rdbGemalyn.Checked = false;

                rdbAnton.Checked = false;
                rdbRodrigo.Checked = false;

                rdbRonald.Checked = false;
                rdbLenie.Checked = false;

                rdbFrancis.Checked = false;
                rdbJoel.Checked = false;

                rdbTrisha.Checked = false;
                rdbFlordeliza.Checked = false;

                rdbVhon.Checked = false;
                rdbHerald.Checked = false;

                rdbGerald.Checked = false;
                rdbAlpha.Checked = false;

                rdbJacob.Checked = false;
                rdbBeauty.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("You have entered an invalid data!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                int Ter = int.Parse(txtTeresita.Text);
                int Gem = int.Parse(txtGemalyn.Text);

                int Ant = int.Parse(txtAnton.Text);
                int Rod = int.Parse(txtRodrigo.Text);

                int Ron = int.Parse(txtRonald.Text);
                int Len = int.Parse(txtLenie.Text);

                int Fra = int.Parse(txtFrancis.Text);
                int Joe = int.Parse(txtJoel.Text);

                int Tri = int.Parse(txtTrisha.Text);
                int Flo = int.Parse(txtFlordeliza.Text);

                int Vho = int.Parse(txtVhon.Text);
                int Her = int.Parse(txtHerald.Text);

                int Ger = int.Parse(txtGerald.Text);
                int Alp = int.Parse(txtAlpha.Text);

                int Jac = int.Parse(txtJacob.Text);
                int Bea = int.Parse(txtBeauty.Text);


                if (Ter > Gem)
                {
                    txtPres.Text = "Teresita";
                }
                else if (Gem > Ter)
                {
                    txtPres.Text = "Gemalyn";
                }
                else if(Gem == Ter)
                {
                    txtPres.Text = "TIED";
                }

                if (Ant > Rod)
                {
                    txtVPres.Text = "Anton";
                }
                else if (Rod > Ant)
                {
                    txtVPres.Text = "Rodrigo";
                }
                else if(Rod == Ant)
                {
                    txtVPres.Text = "TIED";
                }
                if (Ron > Len)
                {
                    txtSec.Text = "Ronald";
                }
                else if (Len > Ron)
                {
                    txtSec.Text = "Lenie";
                }
                else if(Len == Ron)
                {
                    txtSec.Text = "TIED";
                }
                if (Fra > Joe)
                {
                    txtTrea.Text = "Francis";
                }
                else if (Joe > Fra)
                {
                    txtTrea.Text = "Joel";
                }
                else if(Joe == Fra)
                {
                    txtTrea.Text = "TIED";
                }
                if (Tri > Flo)
                {
                    txtAud.Text = "Trisha";
                }
                else if (Flo > Tri)
                {
                    txtAud.Text = "Flordeliza";
                }
                else if(Flo == Tri)
                {
                    txtAud.Text = "TIED";
                }
                if (Vho > Her)
                {
                    txtPIO.Text = "Vhon";
                }
                else if (Her > Vho)
                {
                    txtPIO.Text = "Herald";
                }
                else if(Her == Vho)
                {
                    txtPIO.Text = "TIED";
                }
                if (Ger > Alp)
                {
                    txtBus1.Text = "Gerald";
                }
                else if (Alp > Ger)
                {
                    txtBus1.Text = "Alpha";
                }
                else if (Alp == Ger)
                {
                    txtBus1.Text = "TIED";
                }
                if (Jac > Bea)
                {
                    txtBus2.Text = "Jacob";
                }
                else if (Bea > Jac)
                {
                    txtBus2.Text = "Beauty";
                }
                else if(Bea == Jac)
                {
                    txtBus2.Text = "TIED";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You have entered an invalid data!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTeresita.Text = "";
            txtGemalyn.Text = "";

            txtAnton.Text = "";
            txtRodrigo.Text = "";

            txtTrisha.Text = "";
            txtFlordeliza.Text = "";

            txtRonald.Text = "";
            txtLenie.Text = "";

            txtVhon.Text = "";
            txtHerald.Text = "";

            txtGerald.Text = "";
            txtJacob.Text = "";

            txtAlpha.Text = "";
            txtBeauty.Text = "";

            txtFrancis.Text = "";
            txtJoel.Text = "";




            rdbTeresita.Checked = false;
            rdbGemalyn.Checked = false;

            rdbAnton.Checked = false;
            rdbRodrigo.Checked = false;

            rdbRonald.Checked = false;
            rdbLenie.Checked = false;

            rdbFrancis.Checked = false;
            rdbJoel.Checked = false;

            rdbTrisha.Checked = false;
            rdbFlordeliza.Checked = false;

            rdbVhon.Checked = false;
            rdbHerald.Checked = false;

            rdbGerald.Checked = false;
            rdbAlpha.Checked = false;

            rdbJacob.Checked = false;
            rdbBeauty.Checked = false;

        }
    }
}
