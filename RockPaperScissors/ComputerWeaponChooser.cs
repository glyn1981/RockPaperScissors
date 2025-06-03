namespace RockPaperScissors
{
    public class ComputerWeaponChooser : IComputerWeaponChooser
    {
        /// <summary>
        /// Randomly chooses a weapon for the computer player.
        /// </summary>
        /// <returns>Weapon</returns>
        public WeaponType ChooseWeapon()
        {
            Random random = new Random();
            int choice = random.Next(1, 4); // Generates a number between 1 and 3 inclusive
            return (WeaponType)Enum.ToObject(typeof(WeaponType), choice);
        }
    }

}
