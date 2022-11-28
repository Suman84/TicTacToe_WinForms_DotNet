using SmartTicTacToe;

namespace SmartTicTacToeTests
{
    public class Tests
    {
        TicTacToe ticTacToe = new("player1", "player2");

        [SetUp]
        public void Setup()
        {
            TicTacToe ticTacToe = new("player1", "player2");
        }

        [Test]
        public void InitializeBoard_initializes_Board()
        {
            //Arrange
            Board board = new Board();
            board.data[1] = "X";
            board.data[2] = "X";
            board.data[3] = "O";
            board.data[4] = "X";
            board.data[5] = "X";
            board.data[6] = "X";
            board.data[7] = "O";
            board.data[8] = "X";
            board.data[9] = "O";

            //Act
            ticTacToe.InitializeBoard(board);

            //Assert
            board.data[1].Equals("");
            board.data[2].Equals("");
            board.data[3].Equals("");
            board.data[4].Equals("");
            board.data[5].Equals("");
            board.data[6].Equals("");
            board.data[7].Equals("");
            board.data[8].Equals("");
            board.data[9].Equals("");

            for ( int i =1; i<10; i++)
            {
                if (!board.data[i].Equals(""))
                {
                    Assert.Fail();
                }

            }
            
        }


        [Test]
        public void CheckIfThereIsAMatch_returns_true_If_matched()
        {
            //Arrange
            Board board1 = new Board();
            board1.data[1] = "X";
            board1.data[2] = "X";
            board1.data[3] = "X";
            Board board2 = new Board();
            board2.data[7] = "X";
            board2.data[8] = "X";
            board2.data[9] = "X";
            Board board3 = new Board();
            board3.data[3] = "O";
            board3.data[5] = "O";
            board3.data[7] = "O";
            //Act
            bool expected1 = ticTacToe.CheckIfThereIsaMatch(board1);
            bool expected2 = ticTacToe.CheckIfThereIsaMatch(board2);
            bool expected3 = ticTacToe.CheckIfThereIsaMatch(board3);


            //Assert
            if(expected1 && expected2 && expected3)
            {
                Assert.Pass();
            }
            else
                Assert.Fail();


        }

        [Test]
        public void CheckIfThereIsAMatch_returns_false_If_unmatched()
        {
            //Arrange
            Board board1 = new Board();
            board1.data[1] = "X";
            board1.data[2] = "X";
            board1.data[3] = "O";
            Board board2 = new Board();
            board2.data[7] = "O";
            board2.data[8] = "X";
            board2.data[9] = "X";
            Board board3 = new Board();
            board3.data[3] = "O";
            board3.data[5] = "X";
            board3.data[7] = "O";
            Board board4 = new Board();
            //Act
            bool expected1 = ticTacToe.CheckIfThereIsaMatch(board1);
            bool expected2 = ticTacToe.CheckIfThereIsaMatch(board2);
            bool expected3 = ticTacToe.CheckIfThereIsaMatch(board3);
            bool expected4 = ticTacToe.CheckIfThereIsaMatch(board4);


            //Assert
            if (expected1 || expected2 || expected3 || expected4)
            {
                Assert.Fail();
            }
            else
                Assert.Pass();

        }
        [Test]
        public void Random_Fill_On_Empty_Box_Fills_Unused_Box()
        {
            //Arrange
            Board board = new Board();
            board.data[5] = "X";
            board.data[6] = "X";
            board.data[7] = "X";

            //Act
            ticTacToe.Random_Fill_On_Empty_Box(board);


            //Assert
            if (board.data[5].Equals("X") && board.data[6].Equals("X") && board.data[7].Equals("X") &&
                (!board.data[1].Equals("") || !board.data[2].Equals("") || !board.data[3].Equals("") ||
                 !board.data[4].Equals("") || !board.data[8].Equals("") || !board.data[9].Equals("")))
            {
                Assert.Pass();
            }
            else
                Assert.Fail();


        }

        [Test]
        public void Smart_Fill_On_Empty_Box_Ends_game_with_winning_move()
        {
            //Arrange
            Board board = new Board();
            board.data[1] = "O";
            board.data[2] = "O";

            //Act
            ticTacToe.Smart_Fill_On_Empty_Box(board);

            //Assert
            if (!board.data[3].Equals("O"))
                Assert.Fail();
        }

        [Test]
        public void Smart_Fill_On_Empty_Box_Blocks_Opponent_from_winning()
        {
            //Arrange
            Board board = new Board();
            board.data[1] = "X";
            board.data[2] = "X";

            //Act
            ticTacToe.Smart_Fill_On_Empty_Box(board);

            //Assert
            if (!board.data[3].Equals("O"))
                Assert.Fail();
        }

        [Test]
        public void Smart_Fill_On_Empty_Box_Goes_for_centre_box_if_empty()
        {
            //Arrange
            Board board = new Board();
            board.data[1] = "X";
            board.data[8] = "X";
            //Act
            ticTacToe.Smart_Fill_On_Empty_Box(board);

            //Assert
            if (!board.data[5].Equals("O"))
                Assert.Fail();
        }

        [Test]
        public void Smart_Fill_On_Empty_Box_Goes_for_corner_box_second()
        {
            //Arrange
            Board board = new Board();
            board.data[5] = "X";

            //Act
            ticTacToe.Smart_Fill_On_Empty_Box(board);

            //Assert 
            if (board.data[1].Equals("O") || board.data[3].Equals("O") || board.data[7].Equals("O") || board.data[9].Equals("O"))
                Assert.Pass();
            else
                Assert.Fail();

        }

    }
}