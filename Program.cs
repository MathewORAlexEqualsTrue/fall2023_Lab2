//FALL 2023 MIS LAB 2
//Author: Alex Collins


//INITIALIZING VARIABLES

int weightOfApples, weightOfOranges; 
double orderCost;
string appleType, orangeType;
char favoriteLetter = 'ñ';  //When declaring characters you must use '. using " will tell the compiler this is a string.
bool amIPrograming = true;


const double fruitCost = .75; //This value cannot be changed elsewhere.




//INTEGER MANIPULATION

System.Console.WriteLine("Enter the weight of Apples in pounds: "); //Giving context for user input (displaying a message).
weightOfApples = int.Parse(System.Console.ReadLine()); //System waits for user input.

System.Console.WriteLine("Enter the weight of Oranges in pounds: ");
weightOfOranges = int.Parse(Console.ReadLine());

System.Console.WriteLine("Total weight: " + (weightOfApples + weightOfOranges) + "lbs"); 


orderCost = fruitCost * (weightOfApples + weightOfOranges); //Determining the cost of fruit.

System.Console.WriteLine("Balance: $" + orderCost);



System.Console.WriteLine("\n\n\n");





//STRING MANIPULATION

System.Console.WriteLine("What type of apples do you sell?: ");
appleType = Console.ReadLine();

System.Console.WriteLine("What type of oranges do you sell?: ");
orangeType = Console.ReadLine();

Console.Clear(); //Start fresh once again! (Clear all text from console)

System.Console.Write("1: We sell " + appleType + " apples. ");  //Line 51 and 52 will appear on the same line.
System.Console.Write("We sell " + orangeType + " oranges.");  //This will be due to the 'Console.Write' instead of 'Console.WriteLine'.

System.Console.WriteLine("\n"); //this special character acts as if the "enter" key was pressed.

System.Console.Write("2: We sell " + orangeType + " oranges.\n");  //These will appear on deferent lines because we have used \n.
System.Console.Write("We sell " + appleType + " apples.\n");  //The same thing could be accomplished using 'Console.WriteLine'.

System.Console.WriteLine(""); //We can also add a gap with an empty

System.Console.WriteLine($"3: We sell {orangeType} oranges.\nWe sell {appleType} apples.\n"); //using a "$" before the quotes allows us to enter variables in brackets rather than using +