// C# is a strongly typed language meaning when a variable 
// is a certain data type it must stay that data type.


using System.Text;

bool myBoolean = true;
string name = "Chris";
Console.WriteLine(name);
name = name + " Abbondandelo";
Console.WriteLine(name);
name = "This is " + name +". Hello world.";
Console.WriteLine(name);
string boolAsString = myBoolean.ToString();
Console.WriteLine(boolAsString);

Console.WriteLine("--TEST--");
Console.WriteLine("--TEST NEW BRANCH--");


// type |     var name       | Class needs to be instantiated with 'new' keyword
Random randomNumberGenerator = new Random();
int guessNumber = randomNumberGenerator.Next(1, 101);

Console.Write("Pick a number between 1 and 100: ");
string input = Console.ReadLine();
int intInput = int.Parse(input);
bool guessStatus = false;

if (intInput == guessNumber)
{
    guessStatus = true;
};

string correctGuessResponse = $" {guessNumber} That's right";
string incorrectGuessResponse = $"{intInput} was wrong. {guessNumber} is the correct number.";

Console.WriteLine(guessStatus ? correctGuessResponse : incorrectGuessResponse);


DateTime timeStarted = DateTime.Now;

StringBuilder sb = new StringBuilder();
for (int counter =0; counter < 1000000; counter++)
{
    sb.Append(counter);
}

StringBuilder builder;
// ? turns a non-nullable object type into a nullable object type
int? timesWon = null;
bool? verified = null;

if (timesWon > 0)
{

} else if (timesWon == 0)
{

} else if (timesWon == null)
{

} else
{

}

switch (timesWon)
{
    case 0:
        // do some stuff
        break;
    case 1:
        // do some other stuff
        break;
    default:
        break;
}

for (int i = 0; i < 100; i++)
{

}

foreach (char letter in "christopher")
{
    // do something for each character in string
}

bool test = true;
while (test)
{
    //do something
}

DateTime timeEnd = DateTime.Now;

Console.WriteLine($"Time started: {timeStarted}. Time ended: {timeEnd}.");
Console.ReadLine(); 

