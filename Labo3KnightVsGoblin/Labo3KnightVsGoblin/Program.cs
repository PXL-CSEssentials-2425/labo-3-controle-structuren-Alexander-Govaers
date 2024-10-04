/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */
// alles selecteren (ctrl + A)==> (ctrl + k + f) 
//declareer en initialiseer
using System.ComponentModel.Design;

Console.WriteLine("hoeveel hp heeft je ridder?");
int inputHealth;
//inputHealth = int.Parse(Console.ReadLine());
bool isValidHealth = int.TryParse(Console.ReadLine(), out inputHealth);
//Console.WriteLine($"inputHealth = {inputHealth}");
int knightHealth; // later in de code is knightHealth = inputHealth
int attackKnight;
attackKnight = 10;
int attackGoblin;
attackGoblin = 5;



if (isValidHealth == false || inputHealth < 0 || inputHealth > 100)
{
    knightHealth = 100;
}
else
{
    knightHealth = inputHealth;
}

int goblinHealth;
goblinHealth = 20;

if (knightHealth <= 0)
{
    Console.WriteLine("Je ridder is gestorven");
}
else
{
    //Console.WriteLine("Je ridder heeft " + knightHealth + " levens");
    Console.WriteLine($"je ridder heeft {knightHealth} levens.");
}
if (goblinHealth <= 0)
{
    Console.WriteLine("de Goblin is gestorven!");

}
else
{


}
Console.WriteLine("Kies een actie:");
Console.WriteLine("Actie '1' = Attack");
Console.WriteLine("Actie '2' = Heal");
string action = Console.ReadLine();

switch (action)
{
    case "1":
        Console.WriteLine("de ridder hakt in op de goblin");
    case "2":
        Console.WriteLine("de ridder heelt zichzelf");


}



//if (isValidHealth == false)
//{
//    //Console.WriteLine("Input is foutief");
//    knightHealth = 100;
//}
//else
//{
//    if (inputHealth < 0 || inputHealth > 100)
//    {
//        knightHealth = 100;
//    }
//    else
//    {
//        knightHealth = inputHealth;
//    }
//}



Console.ReadLine();

////int knightHealth = 0;
////declareer 
////int goblinhealth;
//////initialiseerd
////int goblinHealth = 20;

////if (knightHealth <= 0) ;
////{
// //   Console.WriteLine("de ridder is gestorven");
////}


//if (goblinHealth <= 0) ;
//{
//    Console.WriteLine("De Goblin is dood");

//}

//string einde = Console.ReadLine();
//vraagt input
// bufert elk karakter tot ENTER



/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */


//Console.WriteLine("hoeveel levenspunten heeft de ridder?");
//int inputUser1;
//string knighthealth = Console.ReadLine();
//bool convert = int.TryParse(knighthealth, out inputUser1);
//Console.WriteLine($"de ridder heeft {inputUser1} levenspunten");

//if (inputUser1 <= 0)
//{
//    Console.WriteLine("de ridder start aan 100 levenspunten");
//}
//else if (inputUser1 >= 100)
//{
//    Console.WriteLine("de ridder start aan 100 levenspunten");
//}
//Console.WriteLine("hoeveel levenspunten heeft de Goblin?");
//int inputUser2;
//string goblinHealth = Console.ReadLine();
//bool convertGoblin = int.TryParse(goblinHealth, out inputUser2);
//Console.WriteLine($"de Goblin heeft {inputUser2} levenspunten");







/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 *  
 *
 */
// switch code snippet!!
//int attackKnight = 10;
//int attackGoblin = 5;

//Console.WriteLine("kies een optie\n 1 - Attack\n 2 - Heal"); 
//string action = Console.ReadLine();

//switch (action)
//{
//    case "1":
//        goblinhealth -= attackKnight;
//    case "2":
//        knightHealth += 20;
//        break;
//c

//}

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
