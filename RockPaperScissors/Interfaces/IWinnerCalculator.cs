namespace RockPaperScissors
{
    public interface IWinnerCalculator
    {
        GameResult CalculateWinner(WeaponType userChoice, WeaponType computerChoice);
    }
}