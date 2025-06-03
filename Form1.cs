using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4States
{
    public partial class Form1 : Form
    {
        //Create an Array of state names
        string[] states = { "ar", "tx", "ok", "la" };

        //Declare Variables
        int spinPts = 0;
        int totalPts;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            //Switch - case to specify the jackpot message

            string jackpotMsg = "Jackpot! You're a winner!";

            //Generate 3 random numbers
            Random random = new Random();
            int randomNum1 = random.Next(0, 4);
            int randomNum2 = random.Next(0, 4);
            int randomNum3 = random.Next(0, 4);

            //Assign state to string variable from the states array based on a random number
            string Lstate = states[randomNum1];
            string Mstate = states[randomNum2];
            string Rstate = states[randomNum3];

            //Animate pbxleft.image
            for (int i = 0; i < 10; i++)
            {
                pbxLeft.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(states[random.Next(0, 4)]);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            for (int i = 0; i < 10; i++)
            {
                pbxMiddle.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(states[random.Next(0, 4)]);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            for (int i = 0; i < 10; i++)
            {
                pbxLeft.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(states[random.Next(0, 4)]);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            pbxLeft.Image =
                (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(Lstate);
            pbxMiddle.Image =
                (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(Mstate);
            pbxRight.Image =
                (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(Rstate);

            //Calculate score
            if (randomNum1 == randomNum2 && randomNum1 == randomNum3)
            {
                //Jackpot
                spinPts = 50;

                lblSpinOutcome.Text = "All 3 Match!";

                //Switch - case to specify the jackpot message
                switch (randomNum1)
                {
                    case 0:
                        jackpotMsg = "Arkansas Jackpot!";
                        break;
                    case 1:
                        jackpotMsg = "Texas Jackpot!";
                        break;
                    case 2:
                        jackpotMsg = "Oklahoma Jackpot!";
                        break;
                    case 3:
                        jackpotMsg = "Louisiana Jackpot!";
                        break;
                    default:
                        jackpotMsg = "No Jackpot";
                        break;
                }
                //Display a message that informs the player that they have hit the Jackpot
                DialogResult = MessageBox.Show(jackpotMsg,
                    "Jackpot", MessageBoxButtons.OK,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1, 0);
            }
            else if (randomNum1 == randomNum2 || randomNum1 == randomNum3 || randomNum2 == randomNum3)
            {
                //two alike
                spinPts = 25;
                lblSpinOutcome.Text = "Two State Match";
            }
            else
            {
                //No match
                spinPts = -30;
                lblSpinOutcome.Text = "No Match";
            }
                totalPts += spinPts;

                //Display score
                lblSpinPointsOut.Text = spinPts.ToString();

                lblTotalPointsOut.Text = totalPts.ToString();



            }
        }
    }
