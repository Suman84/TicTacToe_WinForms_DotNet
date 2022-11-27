using SmartTicTacToe;
using Xunit;

namespace Tests
{
    public class TicTacToeTests
    {
        TicTacToe ticTacToe = new("player1", "player2");

        [Fact]
        public void CheckIfThereIsAMatch_returns_true_If_matched()
        {
            //Arrange
            ticTacToe.Check_for_draw;
        }

        [Fact]
        public void InitializeBoard_Initializes_Board()
        {
            //Arrange
            int turnCount = 0;

            
            SmartTicTacToe.TicTacToe ticTacToe = new("","")
            {

            };

            //Act

            //Assert

        }
    }
}