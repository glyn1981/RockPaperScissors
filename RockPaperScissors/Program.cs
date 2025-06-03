using RockPaperScissors;

public class Program
{
    public class GameLogicArgs
    {
        public IInputHandler? InputHandler { get; set; }
        public IComputerWeaponChooser? ComputerWeaponChooser { get; set; }
        public IWinnerCalculator? WinnerCalculator { get; set; }
    }

    static void Main(string[] args)
    {
        // Create dependencies
        IInputHandler inputHandler = new InputHandler();
        ComputerWeaponChooser computerWeaponChooser = new ComputerWeaponChooser();
        IWinnerCalculator winnerCalculator = new WinnerCalculator( inputHandler);

        GameLogicArgs gameLogicArgs = new GameLogicArgs
        {
            InputHandler = inputHandler,
            ComputerWeaponChooser = computerWeaponChooser,
            WinnerCalculator = winnerCalculator
        };

        IGameLogic gameLogic = new GameLogic(gameLogicArgs);

        // Fix: Pass the gameLogic instance directly instead of calling it like a method
        Game game = new Game(inputHandler, gameLogic);
        game.Start();
    }
}
