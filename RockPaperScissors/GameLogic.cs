
namespace RockPaperScissors
{
    public class GameLogic : IGameLogic
    {
        private IInputHandler _inputHandler;
        private IComputerWeaponChooser _computerWeaponChooser;
        private IWinnerCalculator _winnerCalculator;
        public GameLogic(IInputHandler inputHandler,
            IComputerWeaponChooser computerWeaponChooser,
            IWinnerCalculator winnerCalculator)
        {
            _inputHandler = inputHandler ?? throw new ArgumentNullException(nameof(inputHandler));
            _computerWeaponChooser = computerWeaponChooser ?? throw new ArgumentNullException(nameof(computerWeaponChooser));
            _winnerCalculator = winnerCalculator ?? throw new ArgumentNullException(nameof(winnerCalculator));      
        }




        public GameResult Play()
        {
            _inputHandler.HandleOutput("Welcome to Rock, Paper, Scissors! Type 'exit' to quit the game.");
            string userInput = _inputHandler.HandleInput() ?? string.Empty;
            WeaponType userChoice = WeaponType.Unknown;

            while(userChoice == WeaponType.Unknown && userInput != "exit")
            { 
                _inputHandler.HandleOutput("Invalid choice. Please choose Rock, Paper, or Scissors.");
                userInput = _inputHandler.HandleInput() ?? string.Empty;
                userChoice = new Weapon().FromString(userInput);
            }

            if (userInput == "exit")
            {
                _inputHandler.HandleOutput("Thanks for playing! Goodbye!");
                return GameResult.Exit;
            }

            WeaponType computerChoice = _computerWeaponChooser.ChooseWeapon();
            _inputHandler.HandleOutput($"The computer chose {computerChoice.ToString()}");
            return _winnerCalculator.CalculateWinner(userChoice, computerChoice);
        }
        }
    }

