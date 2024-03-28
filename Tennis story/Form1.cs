using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Tennis_story
{
    public partial class TennisPlayerSim : Form
    {
        
        int page = 1;
        SoundPlayer applause = new SoundPlayer(Properties.Resources.Applause);
        SoundPlayer boo = new SoundPlayer(Properties.Resources.You_lost);
        


        Random randGen = new Random();
        public TennisPlayerSim()
        {
            
            InitializeComponent();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 25)
                {
                    page = 15;
                }
                else
                {
                    page = 16;
                }

            }
            else if (page == 14)
            {
                page = 22;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 10)
                {
                    page = 19;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 32;
            }
            else if (page == 22)
            {
                page = 28;
            }
            else if (page == 23)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 80;
                }
                else
                {
                    page = 60;
                }

            }
            else if (page == 24)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 80;
                }
                else
                {
                    page = 60;
                }
            }
            else if (page == 25)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 36;
                }
                else
                {
                    page = 35;
                }
            }
            else if (page == 26)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 36;
                }
                else
                {
                    page = 35;
                }
            }
            else if (page == 27)
            {
                page = 31;
            }
            else if (page == 28)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 36;
                }
                else
                {
                    page = 35;
                }

            }
            else if (page == 29)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 36;
                }
                else
                {
                    page = 35;
                }

            }
            else if (page == 30)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 80;
                }
                else
                {
                    page = 60;
                }
            }
            else if (page == 31)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 35)
                {
                    page = 80;
                }
                else
                {
                    page = 60;
                }
            }
            else if (page == 32)
            {
                page = 23;
            }
            else if (page == 33)
            {
                page = 42;
            }
            else if (page == 34)
            {
                page = 39;
            }
            else if (page == 35)
            {
                page = 39;
            }
            else if (page == 36)
            {
                page = 42;
            }
            else if (page == 37)
            {
                page = 26;
            }
            else if (page == 38)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 51;
                }
                else
                {
                    page = 52;
                }

            }
            else if (page == 39)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 58;
                }
                else
                {
                    page = 59;
                }

            }
            else if (page == 40)
            {
                page = 39;
            }
            else if (page == 41)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 58;
                }
                else
                {
                    page = 59;
                }
            }
            else if (page == 42)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 65;
                }
                else
                {
                    page = 66;
                }
            }
            else if (page == 43)
            {
                page = 45;
            }
            else if (page == 44)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 72;
                }
                else
                {
                    page = 73;
                }
            }
            else if (page == 45)
            {
                int randValue = randGen.Next(1, 101);

                if (randValue > 85)
                {
                    page = 51;
                }
                else
                {
                    page = 52;
                }
            }
            else if (page == 47)
            {
                page = 75;
            }
            else if (page == 48)
            {
                page = 50;
            }
            else if (page == 49)
            {
                page = 75;
            }
            else if (page == 50)
            {
                page = 81;
            }
            else if (page == 51)
            {
                page = 1;
            }
            else if (page == 52)
            {
                page = 75;
            }
            else if (page == 53)
            {
                page = 1;
            }
            else if (page == 54)
            {
                page = 78;
            }
            else if (page == 55)
            {
                page = 57;
            }
            else if (page == 56)
            {
                page = 78;
            }
            else if (page == 57)
            {
                page = 75;
            }
            else if (page == 58)
            {
                page = 1;
            }
            else if (page == 59)
            {
                page = 78;
            }
            else if (page == 60)
            {
                page = 45;
            }
            else if (page == 61)
            {
                page = 1;
            }
            else if (page == 62)
            {
                page = 64;
            }
            else if (page == 63)
            {
                page = 1;
            }
            else if (page == 64)
            {
                page = 78;
            }
            else if (page == 65)
            {
                page = 1;
            }
            else if (page == 66)
            {
                page = 1;
            }
            else if (page == 67)
            {
                page = 1;
            }
            else if (page == 68)
            {
                page = 81;
            }
            else if (page == 69)
            {
                page = 71;
            }
            else if (page == 70)
            {
                page = 81;
            }
            else if (page == 71)
            {
                page = 1;
            }
            else if (page == 72)
            {
                page = 1;
            }
            else if (page == 73)
            {
                page = 81;
            }
            else if (page == 74)
            {
                page = 1;
            }
            else if (page == 75)
            {
                page = 53;
            }
            else if (page == 76)
            {
                page = 53;
            }
            else if (page == 78)
            {
                page = 1;
            }
            else if (page == 79)
            {
                page = 1;
            }
            else if (page == 80)
            {
                page = 1;
            }
            else if (page == 81)
            {
                page = 1;
            }
            else if (page == 82)
            {
                page = 1;
            }

            displayPage();



        }

        private void option2Button_Click(object sender, EventArgs e)
        {

            {
                if (page == 1)
                {
                    page = 3;
                }
                else if (page == 2)
                {
                    page = 5;
                }
                else if (page == 3)
                {
                    page = 99;
                }
                else if (page == 4)
                {
                    page = 99;
                }
                else if (page == 5)
                {
                    page = 7;
                }
                else if (page == 6)
                {
                    page = 99;
                }
                else if (page == 7)
                {
                    page = 9;
                }
                else if (page == 8)
                {
                    page = 11;
                }
                else if (page == 9)
                {
                    page = 99;
                }
                else if (page == 10)
                {
                    page = 99;
                }
                else if (page == 11)
                {
                    page = 13;
                }
                else if (page == 12)
                {
                    page = 99;
                }
                else if (page == 13)
                {
                    page = 14;
                }
                else if (page == 14)
                {
                    page = 27;
                }
                else if (page == 15)
                {
                    page = 17;
                }
                else if (page == 16)
                {
                    page = 99;
                }
                else if (page == 17)
                {
                    page = 99;
                }
                else if (page == 18)
                {
                    page = 21;
                }
                else if (page == 19)
                {
                    page = 27;
                }
                else if (page == 20)
                {
                    page = 99;
                }
                else if (page == 21)
                {
                    page = 37;
                }
                else if (page == 22)
                {
                    page = 30;
                }
                else if (page == 23)
                {
                    page = 40;
                }
                else if (page == 24)
                {
                    page = 40;
                }
                else if (page == 25)
                {
                    page = 33;
                }
                else if (page == 26)
                {
                    page = 33;
                }
                else if (page == 27)
                {
                    page = 29;
                }
                else if (page == 28)
                {
                    page = 40;
                }
                else if (page == 29)
                {
                    page = 40;
                }
                else if (page == 30)
                {
                    page = 33;
                }
                else if (page == 31)
                {
                    page = 33;
                }
                else if (page == 32)
                {
                    page = 25;
                }
                else if (page == 33)
                {
                    page = 41;
                }
                else if (page == 34)
                {
                    page = 38;
                }
                else if (page == 35)
                {
                    page = 38;
                }
                else if (page == 36)
                {
                    page = 41;
                }
                else if (page == 37)
                {
                    page = 24;
                }
                else if (page == 38)
                {
                    page = 47;
                }
                else if (page == 39)
                {
                    page = 54;
                }
                else if (page == 40)
                {
                    page = 38;
                }
                else if (page == 41)
                {
                    page = 54;
                }
                else if (page == 42)
                {
                    page = 61;
                }
                else if (page == 43)
                {
                    page = 44;
                }
                else if (page == 44)
                {
                    page = 68;
                }
                else if (page == 45)
                {
                    page = 47;
                }
                else if (page == 47)
                {
                    page = 76;
                }
                else if (page == 48)
                {
                    page = 49;
                }
                else if (page == 49)
                {
                    page = 76;
                }
                else if (page == 50)
                {
                    page = 82;
                }
                else if (page == 51)
                {
                    page = 1;
                }
                else if (page == 52)
                {
                    page = 76;
                }
                else if (page == 53)
                {
                    page = 1;
                }
                else if (page == 54)
                {
                    page = 79;
                }
                else if (page == 55)
                {
                    page = 58;
                }
                else if (page == 56)
                {
                    page = 79;
                }
                else if (page == 57)
                {
                    page = 76;
                }
                else if (page == 58)
                {
                    page = 1;
                }
                else if (page == 59)
                {
                    page = 79;
                }
                else if (page == 60)
                {
                    page = 44;
                }
                else if (page == 61)
                {
                    page = 1;
                }
                else if (page == 62)
                {
                    page = 63;
                }
                else if (page == 63)
                {
                    page = 1;
                }
                else if (page == 64)
                {
                    page = 79;
                }
                else if (page == 65)
                {
                    page = 1;
                }
                else if (page == 66)
                {
                    page = 1;
                }
                else if (page == 67)
                {
                    page = 1;
                }
                else if (page == 68)
                {
                    page = 82;
                }
                else if (page == 69)
                {
                    page = 70;
                }
                else if (page == 70)
                {
                    page = 82;
                }
                else if (page == 71)
                {
                    page = 1;
                }
                else if (page == 72)
                {
                    page = 1;
                }
                else if (page == 73)
                {
                    page = 83;
                }
                else if (page == 74)
                {
                    page = 1;
                }
                else if (page == 75)
                {
                    page = 67;
                }
                else if (page == 76)
                {
                    page = 67;
                }
                else if (page == 78)
                {
                    page = 1;
                }
                else if (page == 79)
                {
                    page = 1;
                }
                else if (page == 80)
                {
                    page = 1;
                }
                else if (page == 81)
                {
                    page = 1;
                }
                else if (page == 82)
                {
                    page = 1;
                }

                displayPage();


            }

        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 23)
            {
                page = 43;
            }
            else if (page == 24)
            {
                page = 43;
            }
            else if (page == 25)
            {
                page = 34;
            }
            else if (page == 26)
            {
                page = 34;
            }
            else if (page == 28)
            {
                page = 43;
            }
            else if (page == 29)
            {
                page = 43;
            }
            else if (page == 30)
            {
                page = 34;
            }
            else if (page == 31)
            {
                page = 34;
            }
            else if (page == 38)
            {
                page = 48;
            }
            else if (page == 39)
            {
                page = 54;
            }

            else if (page == 41)
            {
                page = 54;
            }
            else if (page == 42)
            {
                page = 62;
            }
            else if (page == 44)
            {
                page = 69;
            }
            else if (page == 45)
            {
                page = 48;
            }
            else if (page == 75)
            {
                page = 74;
            }
            else if (page == 76)
            {
                page = 74;
            }

            displayPage();

        }

        private void displayPage()

        {
            switch (page)
            {
                case 1:
                    option3Button.Visible = false;
                    outputLabel.Text = "You're a professional tennis player and there’s a tournament coming up, would you like to enter it";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.Calendar;
                    break;
                case 2:
                    outputLabel.Text = "You got accepted into the tournament, you need a way to get there. Drive or Fly?";
                    option1Label.Text = "Drive";
                    option2Label.Text = "Fly";
                    pictureBox.Image = Properties.Resources.Envelope;
                    break;
                case 3:
                    outputLabel.Text = "Nothing wrong with resting, play again?";
                    boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 4:
                    outputLabel.Text = "You got stuck in traffic and you were too late, play again?";
                    boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 5:
                    outputLabel.Text = "Your plane landed safely, you're early and hungry. You see a McDonalds, go to it?";
                    option1Label.Text = "Eat there";
                    option2Label.Text = "Keep walking";
                    pictureBox.Image = Properties.Resources.Plane;
                    break;
                case 6:
                    outputLabel.Text = "What are you doing? Eating McDonalds before playing tennis, disappointing. Play again?";
                    boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 7:
                    outputLabel.Text = "You find a subway and choose to eat healthy, you arrive at the tournament and your game is about to start. Stretch?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.Subway;
                    break;
                case 8:
                    outputLabel.Text = "Good choice, you end up winning your first game. Your next game is in an hour. What are you going to do in between?";
                    option1Label.Text = "Practice";
                    option2Label.Text = "Rest";
                    pictureBox.Image = Properties.Resources.Check;
                    break;
                case 9:
                    outputLabel.Text = "You tore a muscle in warm-up and are out for the season, play again?";
                    boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 10:
                    outputLabel.Text = "You get too tired before your next game and get crushed, play again?";
                    boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 11:
                    outputLabel.Text = "You rested for your game and ended up advancing to the semi finals. You have time before your next game. Go watch your opponent?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    boo.Play();
                    outputLabel.Text = "You get hit in the head by a ball and get a concussion, you can’t play in the semis or the rest of the tournament. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox.Image = Properties.Resources.X;
                    break;
                case 13:
                    outputLabel.Text = "You talk to your coach about strategy and he helps you beat your opponent in the semi finals and head to the finals. You get offered an apple take it?";
                    option1Label.Text = "Accept";
                    option2Label.Text = "Decline";
                    pictureBox.Image = Properties.Resources.Apple;
                    break;
                case 14:
                    outputLabel.Text = "You played it safe before the finals and missed out on the mystery apple.";
                    pictureBox.Image = Properties.Resources.Serve;
                    Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe finals has started and you are in a very close game, The score is 7 - 5 3 - 6 6 - 1 4 - 6 5 - 4, you are serving for the set. Where are you serving ? ";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 15:
                    outputLabel.Text = "It was a performance enhancing apple and you feel very energized for the finals. Are you excited?";
                    pictureBox.Image = Properties.Resources.Check;
                   option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "It was a poisonous apple and you died. Play again?";
                    pictureBox.Image = Properties.Resources.X;
                   boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "You are not ready enough and lose the match too quickly. Play again?";
                    pictureBox.Image = Properties.Resources.X;
                   boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "Of course you are, it's the finals, the match is about to start. Take a quick nap?";
                    pictureBox.Image = Properties.Resources.Sleep;
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 19:
                    outputLabel.Text = "Your nap canceled out the performance enhancing apple.";
                    pictureBox.Image = Properties.Resources.Serve;
                    Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe finals has started and you are in a very close game, The score is 7 - 5 3 - 6 6 - 1 4 - 6 5 - 4, you are serving for the set. Where are you serving ?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 20:
                    outputLabel.Text = "Your alarm didn't go off and you sleep through your game, play again?";
                    pictureBox.Image = Properties.Resources.X;
                   boo.Play();
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = " The finals have started and you are smoking your opponent.";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou are winning 6 - 1 6 - 2 5 - 3 in the third set, You are serving for the game. Where are you serving?";
                    option1Label.Text = "Left";
                    option2Label.Text = "Right";
                    break;
                case 22:
                    outputLabel.Text = "Where on the left side, Front or Back?";
                    option1Label.Text = "Front";
                    option2Label.Text = "Right";
                    break;
                case 23:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "You missed the serve into the net and lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 0 - 15 and you're still feeling great. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the Line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 24:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "You missed the serve into the net and lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 0 - 15 and you're still feeling great. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the Line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 25:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "You aced him";
                    pictureBox.Image = Properties.Resources.BallHit1;
                    Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 15 - 0 and you're feeling better than ever. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross court";
                    option3Label.Text = "Middle";
                    break; 
                case 26:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "He returned the ball out of the court, nice serve!";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 15 - 0 and you're feeling better than ever. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 27:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Where on the right side, Front or Back?";
                    option1Label.Text = "Back";
                    option2Label.Text = "Front";
                    break;
                case 28:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "You missed the serve into the net and lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 0 - 15 and you're still feeling great. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 29:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "You missed the serve into the net and lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 0 - 15 and you're still feeling great. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 30:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    Refresh();
                    outputLabel.Text = "You aced him";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 15 - 0 and you're feeling better than ever. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 31:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "He returned the ball out of the court, nice serve!";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is 15 - 0 and you're feeling better than ever. Your opponent hits you a forehand. Where would you like to hit the ball?";
                    option1Label.Text = "Down the line";
                    option2Label.Text = "Cross Court";
                    option3Label.Text = "Middle";
                    break;
                case 32:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Where on the left side, Front or Back?";
                    option1Label.Text = "Front";
                    option2Label.Text = "Back";
                    break;
                case 33:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You smash a winner by him and your opponent loses confidence.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 30 - 0 and your opponent looks tired, he hits a short ball to you.  What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 34:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = " Your opponent smashes a winner by you and gains confidence back.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 15 - 15 and your opponent looks tired, he hits a short ball to you. What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 35:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You smashed it out, your opponent feels like they were just saved, close shot!";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 15 - 15 and your opponent looks tired, he hits a short ball to you.";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 36:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You smash a winner by him and your opponent loses confidence.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 30 - 0 and your opponent looks tired, he hits a short ball to you.  What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 37:
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    outputLabel.Text = "Where on the right side, Front or Back?";
                    option1Label.Text = "Back";
                    option2Label.Text = "Front";
                    break;
                case 38:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "Oops you missed the winner and your opponent starts smiling.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 15 - 30 and you're starting to get tired, it's your serve.Where are you serving?";
                    option1Label.Text = "Underhand/Front";
                    option2Label.Text = "Back corners";
                    option3Label.Text = "Middle";
                    break;
                case 39:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "You played it safe and your opponent didn't make it on time ";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 30 - 15 and you're starting to get tired, it's your serve.Where are you serving?";
                    option1Label.Text = "Underhand/Front";
                    option2Label.Text = "Back Corners";
                    option3Label.Text = "Middle";
                    break;
                case 40:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You smash a winner by him and your opponent loses confidence.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 15-15 and your opponent looks tired, he hits a short ball to you. What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 41:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "Oops you missed the winner and your opponent starts smiling ";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 30 - 15 and your starting to get tired, its your serve. Where are you serving?";
                    option1Label.Text = "Underhand front";
                    option2Label.Text = "Back corners";
                    option3Label.Text = "Middle";
                    break;
                case 42:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "You played it safe and your opponent didn't make it on time";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 40 - 0 MATCH POINT and your starting to get tired, its your serve. Where are you serving?";
                    option1Label.Text = "Underhand front";
                    option2Label.Text = "Back corners";
                    option3Label.Text = "Middle";
                    break;
                case 43:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent smashes a winner by you and gains even more confidence.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIts 0 - 30 and your opponent looks tired, he hits a short ball to you. What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 44:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "Oops you missed the winner and your opponent starts smiling.";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 0 - 40 and you're starting to get tired, it's your serve. Where are you serving?";
                    option1Label.Text = "Underhand front";
                    option2Label.Text = "Back corners";
                    option3Label.Text = "Middle";
                    break;
                case 45:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You played it safe and your opponent didn't make it on time";
                    pictureBox.Image = Properties.Resources.Serve;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt is now 15 - 30 and you're starting to get tired, it's your serve. Where are you serving?";
                    option1Label.Text = "Underhand/Front ";
                    option2Label.Text = "Back corners";
                    option3Label.Text = "Middle";
                    break;
                case 47:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You aced him and your opponent smashes his racquet.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 30 - 30 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 48:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent returns the ball and you have lots of time. Where are you hitting the ball?";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   option1Label.Text = "Middle";
                    option2Label.Text = "Cross court";
                    break;
                case 49:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Nice shot! The opponent couldn't return that shot.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 30 - 30 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 50:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent hits it back into a corner and you lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt's 15-40 and your opponent is very confident right now. Your opponent hits a shot down the middle. Where will you hit the ball";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 51:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Your opponent doesn't reach the ball in time and trips over something and cant play. YOU WIN!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 52:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "He can't get the ball in time and you win the point, nice shot!";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 30 - 30 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 53:
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Wow! great shot, your opponent missed the ball and you won the point.";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 54:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You aced him and your opponent smashes his racquet.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 - 15 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 55:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent returns the ball and you have lots of time. Where are you hitting the ball?";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   option1Label.Text = "Middle";
                    option2Label.Text = "Cross court";
                    break;
                case 56:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Nice shot! The opponent couldn't return that shot. ";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 - 15 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 57:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent hits it back into a corner and you lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 30 - 30 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 58:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Your opponent doesn't reach the ball in time and trips over something and can't play. YOU WIN!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 59:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "He can't get the ball in time and you win the point, nice shot!";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 - 15 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 60:
                    option3Label.Visible = false;
                    option3Button.Visible = false;
                    outputLabel.Text = "You smashed it out, your opponent feels like they were just saved, close shot! ";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt's 0 - 30 and your opponent looks tired, he hits a short ball to you. What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner";
                    break;
                case 61:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You aced him and your opponent smashes his racquet.";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 62:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent returns the ball and you have lots of time. Where are you hitting the ball?";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   option1Label.Text = "Middle";
                    option2Label.Text = "Cross court";
                    break;
                case 63:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Nice shot! The opponent couldn't return that shot.";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += " \n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 64:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent hits it back into a corner and you lost the point.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 - 15 and you're getting nervous. Your opponent hit a shot down the middle. Where will you hit the ball?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 65:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Your opponent doesn't reach the ball in time and trips over something and can't play. YOU WIN!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 66:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "He cant get the ball in time and you win the point, nice shot!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 67:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You smashed the ball and won the point, great shot!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 68:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You aced him and your opponent smashes his racquet.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt's 15-40 and your opponent is very confident right now. Your opponent hits a shot down the middle. Where will you hit the ball";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 69:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent returns the ball and you have lots of time. Where are you hitting the ball?";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   option1Label.Text = "Middle";
                    option2Label.Text = "Cross court";
                    break;
                case 70:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Nice shot! The opponent couldn't return that shot.";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt's 15-40 and your opponent is very confident right now. Your opponent hits a shot down the middle. Where will you hit the ball";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 71:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Your opponent hits it back into a corner and you lost the point.";
                    pictureBox.Image = Properties.Resources.TournamentLoss;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou tripped in the next point and couldn't play anymore! You came 2nd place and got 1 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 72:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Your opponent doesn't reach the ball in time and trips over something and cant play. YOU WIN!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou tripped in the next point and couldn't play anymore! You came 2nd place and got 1 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 73:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "He cant get the ball in time and you win the point, nice shot!";
                    pictureBox.Image = Properties.Resources.BallHit1;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nIt's 15-40 and your opponent is very confident right now. Your opponent hits a shot down the middle. Where will you hit the ball";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Down the line";
                    break;
                case 74:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "Your opponent miss read the bounce and missed the ball, tricky shot!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 75:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "The ball trickled on top of the net and dropped on their side. Lucky!";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 -30 so close! Your opponent hits a slow serve. What shot will you hit?";
                    option1Label.Text = "Forehand";
                    option2Label.Text = "Backhand";
                    option3Label.Text = "Slice";
                    break;
                case 76:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    applause.Play();
                    outputLabel.Text = "The ball bounced right on the line and you celebrate that amazing shot. Nice!";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nThe score is 40 -30 so close! Your opponent hits a slow serve. What shot will you hit?";
                    option1Label.Text = "Forehand";
                    option2Label.Text = "Backhand";
                    option3Label.Text = "Slice";
                    break;
                case 78:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "The ball trickled on top of the net and dropped on their side. Lucky!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 79:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "The ball bounced right on the line and you celebrate that amazing shot. Nice!";
                    pictureBox.Image = Properties.Resources.TournamentWin;
                   Refresh();
                    Thread.Sleep(1000);
                    Refresh();
                    outputLabel.Text += "\n\nYou won the tournament and won 5 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 80:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    applause.Play();
                    outputLabel.Text = "You smash a winner by him and your opponent loses confidence.";
                    pictureBox.Image = Properties.Resources.BallHit2;
                   Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += "\n\nIts 15 - 15 and your opponent looks tired, he hits a short ball to you. What shot are you going to hit?";
                    option1Label.Text = "Drop shot";
                    option2Label.Text = "Hit a winner"; 
                    break;
                case 81:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Oh no you barely missed, you lost the point!";
                    pictureBox.Image = Properties.Resources.TournamentLoss;
                   Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += "\n\nYou tripped in the next point and couldn't play anymore! You came 2nd place and got 1 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 82:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Oh no! It was too short! You lost the point";
                    pictureBox.Image = Properties.Resources.TournamentLoss;
                   Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += "\n\nYou tripped in the next point and couldn't play anymore! You came 2nd place and got 1 million dollars! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "thanks for playing";
                    option1Button.Visible = false;
                    option1Label.Visible = false;
                    option2Button.Visible = false;
                    option2Label.Visible = false;
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;


            }

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
