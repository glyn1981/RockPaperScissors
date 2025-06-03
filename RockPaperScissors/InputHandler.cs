
namespace RockPaperScissors
{
    public class InputHandler : IInputHandler
    {

        public string HandleInput()
        {
            HandleOutput("Please type either rock, paper or scissors");
            string input = Console.ReadLine()??String.Empty;


            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be empty. Please enter Rock, Paper, or Scissors.");
                return string.Empty ;
            }
            input = input.Trim().ToLower();
            if (input != "rock" && input != "paper" && input != "scissors")
            {
                Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors.");
                return string.Empty;
            }
            // Process valid input
            Console.WriteLine($"You chose: {input}");

            return input;

        }
        public void HandleOutput(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(input);
               
            }
        }
    }
}
