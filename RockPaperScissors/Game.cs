namespace RockPaperScissors
{
    class Game : IGame
    {

        private IInputHandler _inputHandler;
        private IGameLogic _gameLogic;


        public Game(IInputHandler inputHandler, IGameLogic gameLogic)
        {
            _inputHandler = inputHandler ?? throw new ArgumentNullException(nameof(inputHandler));
            _gameLogic = gameLogic ?? throw new ArgumentNullException(nameof(gameLogic));
        }

        public void Start()
        {
            _inputHandler.HandleOutput("Welcome to Rock, Paper, Scissors! Type 'exit' to quit the game.");
            GameResult result = _gameLogic.Play();

            while (result != GameResult.Exit)
            {
                switch (result)
                {
                    case GameResult.Draw:
                        _inputHandler.HandleOutput("It's a tie! Try again.");
                        break;
                    case GameResult.UserWin:
                        _inputHandler.HandleOutput("You win! Congratulations!");
                        break;
                    case GameResult.ComputerWin:
                        _inputHandler.HandleOutput("You lose! Better luck next time.");
                        break;
                }
                result = _gameLogic.Play();
            }
            _inputHandler.HandleOutput("Thanks for playing! Goodbye!");


        }


    }
}
