
namespace RockPaperScissors
{

    public enum WeaponType

    {   Unknown=0,
        Rock = 1,
        Paper = 2,
        Scissors = 3
     
    }
    public class Weapon
    {
        public WeaponType FromInt(int i)
        {
            if (i < 1 || i > 3)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "Weapon type must be between 1 and 3.");
            }
            return (WeaponType)Enum.ToObject(typeof(WeaponType), i);
        }

        public WeaponType FromString(string stringWeapon)
        {
            if (string.IsNullOrWhiteSpace(stringWeapon))
            {
                throw new ArgumentException("Weapon cannot be null or empty.", nameof(stringWeapon));
            }
            stringWeapon = stringWeapon.Trim().ToLower();
            return stringWeapon switch
            {
                "rock" => FromInt((int)WeaponType.Rock),
                "paper" => FromInt((int)WeaponType.Paper),
                "scissors" => FromInt((int)WeaponType.Scissors),
                _ => WeaponType.Unknown
            };
        }
    }
}
