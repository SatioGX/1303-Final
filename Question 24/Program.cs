using Question_24;

class Program
{
    public static void Main()
    {
        Random random = new Random();
        int playerLevel = 3;
        int diceRoll = random.Next(1, 7); // Random dice roll between 1 and 6

        // Instantiate the weapon objects
        Weapon sword = new Weapon("Sword", 3);
        Weapon arrow = new Weapon("Arrow", 2);
        Weapon crossbow = new Weapon("Crossbow", 2.5);
        Weapon whip = new Weapon("Whip", 1.5);
        Weapon dagger = new Weapon("Dagger", 2);
        Weapon staff = new Weapon("Staff", 1);

        // Calculate and display the damage for each weapon
        Console.WriteLine($"Player Level: {playerLevel}");
        Console.WriteLine($"Dice Roll: {diceRoll}\n");
        Console.WriteLine($"Sword Damage: {sword.CalculateDamage(playerLevel, diceRoll)}");
        Console.WriteLine($"Arrow Damage: {arrow.CalculateDamage(playerLevel, diceRoll)}");
        Console.WriteLine($"Crossbow Damage: {crossbow.CalculateDamage(playerLevel, diceRoll)}");
        Console.WriteLine($"Whip Damage: {whip.CalculateDamage(playerLevel, diceRoll)}");
        Console.WriteLine($"Dagger Damage: {dagger.CalculateDamage(playerLevel, diceRoll)}");
        Console.WriteLine($"Staff Damage: {staff.CalculateDamage(playerLevel, diceRoll)}");
    }
}