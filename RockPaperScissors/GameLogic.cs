
using static Program;

namespace RockPaperScissors
{
    public class GameLogic : IGameLogic
    {
        private IInputHandler _inputHandler;
        private IComputerWeaponChooser _computerWeaponChooser;
        private IWinnerCalculator _winnerCalculator;
        public GameLogic(GameLogicArgs args)
        {
            _inputHandler = args.InputHandler ?? throw new ArgumentNullException(nameof(args.InputHandler));
            _computerWeaponChooser = args.ComputerWeaponChooser ?? throw new ArgumentNullException(nameof(args.ComputerWeaponChooser));
            _winnerCalculator = args.WinnerCalculator ?? throw new ArgumentNullException(nameof(args.WinnerCalculator));      
        }

        public GameResult Play()
        {
            string userInput = _inputHandler.HandleInput() ?? string.Empty;
            WeaponType userChoice = WeaponType.Unknown;

            if(userInput == "exit")
            {
                return GameResult.Exit;
            }
            userChoice = new Weapon().FromString(userInput);


            while (userChoice == WeaponType.Unknown && userInput != "exit")
            { 
                _inputHandler.HandleOutput("Invalid choice. Please choose Rock, Paper, or Scissors.");
                userInput = _inputHandler.HandleInput() ?? string.Empty;
                userChoice = new Weapon().FromString(userInput);
            }


            WeaponType computerChoice = _computerWeaponChooser.ChooseWeapon();
            _inputHandler.HandleOutput($"The computer chose {computerChoice.ToString()}");
            return _winnerCalculator.CalculateWinner(userChoice, computerChoice);
        }
        }
    }

