

using static RockPaperScissors.GameLogic;

namespace RockPaperScissors
{



    public class WinnerCalculator : IWinnerCalculator
    {
        IInputHandler _inputHandler;


        public WinnerCalculator(IInputHandler inputHandler)
        {
            _inputHandler = inputHandler;
        }

        public GameResult CalculateWinner(WeaponType userChoice, WeaponType computerChoice)
        {
            if (userChoice == computerChoice)
            {
                _inputHandler.HandleOutput("It's a tie!");
                return GameResult.Draw;
            }
            else if ((userChoice == WeaponType.Rock && computerChoice == WeaponType.Scissors) ||
                     (userChoice == WeaponType.Paper && computerChoice == WeaponType.Rock) ||
                     (userChoice == WeaponType.Scissors && computerChoice == WeaponType.Paper))
            {
                _inputHandler.HandleOutput("You win!");
                return GameResult.UserWin;
            }
            else
            {
                _inputHandler.HandleOutput("You lose!");
                return GameResult.ComputerWin;
            }

        }
    }
}
