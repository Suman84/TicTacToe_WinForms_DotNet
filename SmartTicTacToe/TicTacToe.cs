using System;
using System.Windows.Forms;
namespace SmartTicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        bool PvP = true;
        int turnCount = 1;

        Board board = new Board();
       

        Player player1 = new()
        {
            name = "Player1",
            score = 0
        };
        Player player2 = new()
        {
            name = "Player2",
            score = 0
        };

        public TicTacToe(string player1name, string player2name)
        {
            InitializeComponent();
            if (player1name != "")
                player1.name = player1name;

            if(player2name == "RandomComputer")
            {
                PvP = false;
                label3.Text = "Player vs Computer";
                player2.name = player2name;
            }
            else if (player2name == "SmartComputer")
            {
                PvP = false;
                label3.Text = "Player vs Computer";
                player2.name = player2name;
            }
            else if (player2name != "")
                player2.name = player2name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1score.Text = player1.name + "'s score(X): " + player1.score;
            player2score.Text = player2.name + "'s score(O): " + player2.score;
        }


        private void button1_click(object sender, EventArgs e)
        {
            if (button1.Text == "" && turn == true)
            {
                board.data[1] = "X";
                Proceed();
            }
            else if(button1.Text == "" && turn == false)
            {
                board.data[1] = "O";
                Proceed();
            }
        }

        private void button2_click(object sender, EventArgs e)
        {
            if (button2.Text == "" && turn == true)
            {
                board.data[2] = "X";
                Proceed();
            }
            else if (button2.Text == "" && turn == false)
            {
                board.data[2] = "O";
                Proceed();
            }
        }

        private void button3_click(object sender, EventArgs e)
        {
            if (button3.Text == "" && turn == true)
            {
                board.data[3] = "X";
                Proceed();
            }
            else if (button3.Text == "" && turn == false)
            {
                board.data[3] = "O";
                Proceed();
            }
        }

        private void button4_click(object sender, EventArgs e)
        {
            if (button4.Text == "" && turn == true)
            {
                board.data[4] = "X";
                Proceed();
            }
            else if (button4.Text == "" && turn == false)
            {
                board.data[4] = "O";
                Proceed();
            }
        }

        private void button5_click(object sender, EventArgs e)
        {
            if (button5.Text == "" && turn == true)
            {
                board.data[5] = "X";
                Proceed();
            }
            else if (button5.Text == "" && turn == false)
            {
                board.data[5] = "O";
                Proceed();
            }
        }

        private void button6_click(object sender, EventArgs e)
        {
            if (button6.Text == "" && turn == true)
            {
                board.data[6] = "X";
                Proceed();
            }
            else if (button6.Text == "" && turn == false)
            {
                board.data[6] = "O";
                Proceed();
            }
        }

        private void button7_click(object sender, EventArgs e)
        {
            if (button7.Text == "" && turn == true)
            {
                board.data[7] = "X";
                Proceed();
            }
            else if (button7.Text == "" && turn == false)
            {
                board.data[7] = "O";
                Proceed();
            }
        }

        private void button8_click(object sender, EventArgs e)
        {
            if (button8.Text == "" && turn == true)
            {
                board.data[8] = "X";
                Proceed();
            }
            else if (button8.Text == "" && turn == false)
            {
                board.data[8] = "O";
                Proceed();
            }
        }

        private void button9_click(object sender, EventArgs e)
        {
            if (button9.Text == "" && turn == true)
            {
                board.data[9] = "X";
                Proceed();
            }
            else if (button9.Text == "" && turn == false)
            {
                board.data[9] = "O";
                Proceed();
            }
        }

        public void Proceed()
        {
            if (PvP == true)
            {
                turn = !turn;
                UpdateBoard();

                if (!turn)
                    check_for_winner_and_UpdateScore(player1);

                else
                    check_for_winner_and_UpdateScore(player2);

                Check_for_draw();
                turnCount++;
            }
            else if(PvP == false && player2.name == "RandomComputer")
            {
                UpdateBoard();
                check_for_winner_and_UpdateScore(player1);
                Check_for_draw();   //Since Board resets if draw or win, AI gets to play 1st next game. 
                turnCount++;
                Random_Fill_On_Empty_Box();
                UpdateBoard();
                check_for_winner_and_UpdateScore(player2);
                Check_for_draw();
                turnCount++;

            }
            else if (PvP == false && player2.name == "SmartComputer")
            {
                UpdateBoard();
                check_for_winner_and_UpdateScore(player1);
                Check_for_draw();
                turnCount++;
                Smart_Fill_On_Empty_Box();
                UpdateBoard();
                check_for_winner_and_UpdateScore(player2);
                Check_for_draw();
                turnCount++;
            }
        }


        public void Check_for_draw()
        {
            if (turnCount == 9)
            {
                MessageBox.Show("Its Draw!");
                InitializeBoard();
                Reset_UI();
                turnCount = 0;
            }
        }

        private void check_for_winner_and_UpdateScore(Player tempPlayer)
        {
            if( CheckIfThereIsaMatch())
            {
                MessageBox.Show(tempPlayer.name + " won, yay!");
                tempPlayer.score = tempPlayer.score + 1;
                InitializeBoard();
                Reset_UI();
                turnCount = 0;

                player1score.Text = player1.name + "'s score(X): " + player1.score;
                player2score.Text = player2.name + "'s score(O): " + player2.score;
            }


        }
        private bool CheckIfThereIsaMatch()
        {
            if (
                   //Horizontal checks
                   board.data[1] == board.data[2] && board.data[2] == board.data[3] && board.data[1] != ""  ||
                   board.data[4] == board.data[5] && board.data[5] == board.data[6] && board.data[4] != ""  ||
                   board.data[7] == board.data[8] && board.data[8] == board.data[9] && board.data[7] != ""  ||


                   //Vertical checks
                   board.data[1] == board.data[4] && board.data[4] == board.data[7] && board.data[1] != "" ||
                   board.data[2] == board.data[5] && board.data[5] == board.data[8] && board.data[2] != "" ||
                   board.data[3] == board.data[6] && board.data[6] == board.data[9] && board.data[3] != "" ||

                   //Diagonal checks
                   board.data[1] == board.data[5] && board.data[5] == board.data[9] && board.data[1] != "" ||
                   board.data[3] == board.data[5] && board.data[5] == board.data[7] && board.data[3] != ""  )
            {
                return true;
            }
            return false;
        }

        private void InitializeBoard()
        {
            board.data[1] = "";
            board.data[2] = "";
            board.data[3] = "";
            board.data[4] = "";
            board.data[5] = "";
            board.data[6] = "";
            board.data[7] = "";
            board.data[8] = "";
            board.data[9] = "";
        }
        private void Reset_UI()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void UpdateBoard()
        {
            button1.Text = board.data[1];
            button2.Text = board.data[2];
            button3.Text = board.data[3];
            button4.Text = board.data[4];
            button5.Text = board.data[5];
            button6.Text = board.data[6];
            button7.Text = board.data[7];
            button8.Text = board.data[8];
            button9.Text = board.data[9];
        }

        private void Random_Fill_On_Empty_Box()
        {
            Random random = new Random();
            int randomNumber;
            while (turnCount < 9)
            {
                randomNumber = random.Next(1, 10);
                if(board.data[randomNumber] == "")
                {
                    board.data[randomNumber] = "O";
                    break;
                }

            }
        }

        private void Smart_Fill_On_Empty_Box()
        {
            bool moveFound = false;

            //Game ending by winning move

            for( var i= 1; i < 10; i++)
            {
                if (board.data[i] == "")
                {
                    board.data[i] = "O";
                    if (!CheckIfThereIsaMatch())
                        board.data[i] = "";
                    else
                    {
                        moveFound = true;
                        break;
                    }
                }
            }

            //Block Opponent from winning move
            for (var i = 1; i < 10; i++) if (!moveFound && turnCount < 9)
            {
                if (board.data[i] == "")
                {
                    board.data[i] = "X";
                    if (CheckIfThereIsaMatch())
                    {
                            board.data[i] = "O";
                            moveFound = true;
                            break;
                    }
                    else
                            board.data[i] = "";
                }
            }

            //the movement is carried out in this order
            if (!moveFound && turnCount < 9)
            {
                Random random = new Random();

                //Highest priority to midddle box
                if (board.data[5] == "")
                {
                    board.data[5] = "O";
                }

                //Secondary priority to corner boxes
                else if (board.data[1] == "" && board.data[3] == "" && board.data[7] == "" && board.data[9] == "")
                {
                    int randomNumber = random.Next(1, 5);
                    if (randomNumber == 1 || randomNumber == 2)
                        board.data[randomNumber * 2 - 1] = "O";
                    else
                        board.data[randomNumber * 2 + 1] = "O";
                }
                else if (board.data[1] == "")
                {
                    board.data[1] = "O";
                }
                else if (board.data[3] == "")
                {
                    board.data[3] = "O";
                }
                else if (board.data[7] == "")
                {
                    board.data[7] = "O";
                }
                else if (board.data[9] == "")
                {
                    board.data[9] = "O";
                }

                //Least priority to remaining boxes
                else if (board.data[2] == "" && board.data[4] == "" && board.data[6] == "" && board.data[8] == "")
                {
                    int randomNumber = random.Next(1, 5);
                    board.data[randomNumber * 2] = "O";
                }
                else if (board.data[2] == "")
                {
                    board.data[2] = "O";
                }
                else if (board.data[4] == "")
                {
                    board.data[4] = "O";
                }
                else if (board.data[6] == "")
                {
                    board.data[6] = "O";
                }
                else if (board.data[8] == "")
                {
                    board.data[8] = "O";
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}