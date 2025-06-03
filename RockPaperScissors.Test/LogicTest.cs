using static RockPaperScissors.GameLogic;

namespace RockPaperScissors.Test
{
    public class LogicTest
    {
        [Fact]
        public void PaperBeatsRock()
        {
            WinnerCalculator winnerCalculator = new WinnerCalculator(new InputHandler());
            Weapon weapon = new Weapon();
            WeaponType userChoice = WeaponType.Rock;
            WeaponType computerChoice = WeaponType.Paper;
            GameResult result = winnerCalculator.CalculateWinner(userChoice, computerChoice);
            Assert.Equal(GameResult.ComputerWin, result);


        }

        [Fact]
        public void RockBeatsScissors()
        {
            WinnerCalculator winnerCalculator = new WinnerCalculator(new InputHandler());
            Weapon weapon = new Weapon();
            WeaponType userChoice = WeaponType.Rock;
            WeaponType computerChoice = WeaponType.Scissors;
            GameResult result = winnerCalculator.CalculateWinner(userChoice, computerChoice);
            Assert.Equal(GameResult.UserWin, result);


        }

        [Fact]
        public void ScissorsBeatsPaper()
        {
            WinnerCalculator winnerCalculator = new WinnerCalculator(new InputHandler());
            Weapon weapon = new Weapon();
            WeaponType userChoice = WeaponType.Scissors;
            WeaponType computerChoice = WeaponType.Paper;
            GameResult result = winnerCalculator.CalculateWinner(userChoice, computerChoice);
            Assert.Equal(GameResult.UserWin, result);
        }


        [Fact]
        public void PaperLosesToScissors()
        {
            WinnerCalculator winnerCalculator = new WinnerCalculator(new InputHandler());
            Weapon weapon = new Weapon();
            WeaponType userChoice = WeaponType.Paper;
            WeaponType computerChoice = WeaponType.Scissors;
            GameResult result = winnerCalculator.CalculateWinner(userChoice, computerChoice);
            Assert.Equal(GameResult.ComputerWin, result);
        }

        [Fact]
        public void PaperAndPaperAreMatch()
        {
            WinnerCalculator winnerCalculator = new WinnerCalculator(new InputHandler());
            Weapon weapon = new Weapon();
            WeaponType userChoice = WeaponType.Paper;
            WeaponType computerChoice = WeaponType.Paper;
            GameResult result = winnerCalculator.CalculateWinner(userChoice, computerChoice);
            Assert.Equal(GameResult.Draw, result);
        }


    }
}