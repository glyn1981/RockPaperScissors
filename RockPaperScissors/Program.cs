using RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        // Create dependencies
        IInputHandler inputHandler = new InputHandler();
        ComputerWeaponChooser computerWeaponChooser = new ComputerWeaponChooser();
        IWinnerCalculator winnerCalculator = new WinnerCalculator( inputHandler);
        IGameLogic gameLogic = new GameLogic(inputHandler, computerWeaponChooser,winnerCalculator);

        // Fix: Pass the gameLogic instance directly instead of calling it like a method
        Game game = new Game(inputHandler, gameLogic);
        game.Start();
    }
}
