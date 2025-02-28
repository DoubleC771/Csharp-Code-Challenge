/*Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.*/

int heroHealthPoints = 10;
int monsterHealthPoints = 10;


Random random= new Random();

//loop for damage distribution
do {
    int damageCount = random.Next(1, 11);
    monsterHealthPoints -= damageCount;
    
    Console.WriteLine($"Monster was damaged and lost {damageCount} health and now has {monsterHealthPoints} health");

    if (monsterHealthPoints <= 0) continue;

    damageCount = random.Next(1, 11);
    heroHealthPoints -= damageCount;
    Console.WriteLine($"Hero was damaged and lost {damageCount} health and now has {heroHealthPoints} health");

}while (monsterHealthPoints > 0 && heroHealthPoints > 0);

//boolean condition for winners
Console.WriteLine(heroHealthPoints > monsterHealthPoints ? "Hero wins!" : "Monster Wins!");