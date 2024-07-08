
// See https://aka.ms/new-console-template for more information

using System;

Console.Write("Hello,");
Console.WriteLine("World!");

/* ********************************************************* */

string message = "Hello World!";
// Printing Variable
Console.Write(message);
// Printing Literal
Console.WriteLine("Lets learn C#!");
Console.WriteLine(100);

string firstName = "King";
string lastName = "Kochhar";
Console.WriteLine(firstName + ' ' + lastName);
Console.WriteLine("Hello, " + firstName + ' ' + lastName + "!");
Console.WriteLine("Hello, {0} {1}!", firstName, lastName);

/* ********************************************************* */

// See https://aka.ms/new-console-template for more information

using System;

Console.Write("Please Enter Your Name : ");
string? name = Console.ReadLine();   // Reading a line of text input

Console.Write("Enter Your Age: ");
int age = Convert.ToInt32(Console.ReadLine());
/*int age = int.Parse(Console.ReadLine());*/

Console.Write("Enter Your Registeration Amount : ");
decimal amount = Convert.ToDecimal(Console.ReadLine());
/*decimal amount = decimal.Parse(Console.ReadLine());*/

Console.Write("Enter Your Birth Date (yyyy-MM-dd) Format : ");
DateTime birthDate;
if (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out birthDate))
    Console.WriteLine("Invalid Date Input Format.");

Console.Write("Is your email verified?(true/false) : ");
/*bool isVerified = Convert.ToBoolean(Console.ReadLine());*/
bool isVerified;
if (bool.TryParse(Console.ReadLine(), out isVerified))
    Console.WriteLine(isVerified ? "Your Email is Verified." : "Your Email is not verified.");
else
    Console.WriteLine("Invalid Input!");

Console.WriteLine();

Console.WriteLine("Hello, " + name);
Console.WriteLine("Your age is " + age);
Console.WriteLine("Your Reg Amount is " + amount);
Console.WriteLine("You Blow your candles on " + birthDate);
Console.WriteLine(isVerified ? "Your Email is Verified." : "Your Email is not verified.");

// Using String Interpolation for Output
Console.WriteLine($"Name: {name}, Age: {age}, Registration Amount : {amount}");
Console.WriteLine(isVerified ? "Your Email is Verified." : "Your Email is not verified.");

Console.ReadKey();

/* ********************************************************* */

// Integer Data Types
byte age = 200;
short priceRange = 20000;
int contactNumber = 1234567899;
Console.WriteLine($"Age: {age}, Price Range: {priceRange}, Contact Number: {contactNumber}");

// Floating Point Data Types
float temperature = 25.4f;  // Float needs 'f' suffix
double pi = 3.141592;
decimal salary = 65789.50m; // Decimal needs 'm' suffix
Console.WriteLine($"Temperature : {temperature}, PI: {pi}, Salary: {salary}");

// Character Data Type:
char grade = 'A';
Console.WriteLine($"Grade: {grade}");

// String Data Type: 
string name = "King Kochhar";
Console.WriteLine($"Name: {name}");

// Variable Scopes:
int number = 100;
Console.WriteLine("Outer: " + number);
{
    int anotherNumber = 200;
    Console.WriteLine("Inner(number): " + number);
    number = 300;
    Console.WriteLine("Inner(number): " + number);
    Console.WriteLine("Inner(anotherNumber): " + anotherNumber);
}
Console.WriteLine("Inner(number): " + number);
// anotherNumber is not in current context.
// Console.WriteLine("Inner(anotherNumber): " + anotherNumber);

// Constants
const double gravity = 7.61;
Console.WriteLine("Gravity Constant: " + gravity);
// gravity = 7.81;  // Error: Const variables can't be reasinged.


// Implicit Typing
Console.Write("Yours Work Experience : ");
var experience = Console.ReadLine();
Console.WriteLine($"Your overall work experience is {experience}");

// Nullable Types
int? nullableInt = null;
Console.WriteLine($"Nullable Int: {nullableInt}");

Console.ReadKey();

/* ********************************************************* */

// See https://aka.ms/new-console-template for more information

// Implicit Type Casting

int numInt = 100;
double numDouble = numInt; // Widening: Implicit Type Casting
Console.WriteLine($"numInt : {numInt}, {numInt.GetType()}");
Console.WriteLine($"numDouble : {numDouble}, {numDouble.GetType()}");

Console.WriteLine(" **************************************** ");

float numFloat = 34.54F;
double numDoubleFloat = numFloat; // Implicit Type Casting
Console.WriteLine($"numFloat : {numFloat}, {numFloat.GetType()}");
Console.WriteLine($"numDouble : {numDouble}, {numDouble.GetType()}");

Console.WriteLine(" **************************************** ");

byte byteValue = 100;
int intValue = byteValue;   // Implicit Type Casting
Console.WriteLine($"numFloat : {byteValue}, {byteValue.GetType()}");
Console.WriteLine($"numFloat : {byteValue}, {intValue.GetType()}");

Console.WriteLine(" **************************************** ");

char charValue = 'A';
int intCharValue = charValue;
Console.WriteLine($"charValue : {charValue}, {charValue.GetType()}");
Console.WriteLine($"intCharValue : {intCharValue}, {intCharValue.GetType()}");

Console.ReadKey();

/* ********************************************************* */

// See https://aka.ms/new-console-template for more information

// Explicit Type Casting

double numDouble = 123.45;
int numInt = (int) numDouble; // Narrowing: Explicit Type Casting
Console.WriteLine($"numDouble : {numDouble}, {numDouble.GetType()}");
Console.WriteLine($"numInt : {numInt}, {numInt.GetType()}");

Console.WriteLine(" **************************************** ");

int intValue = 400;
byte byteValue = (byte) intValue;   // Explicit Type Casting Needed
Console.WriteLine($"intValue : {intValue}, {intValue.GetType()}");
Console.WriteLine($"byteValue : {byteValue}, {byteValue.GetType()}");

Console.WriteLine(" **************************************** ");

long longValue = 1000000000;
int intValue1 = (int) longValue;   // Explicit Type Casting Needed
Console.WriteLine($"longValue : {longValue}, {longValue.GetType()}");
Console.WriteLine($"intValue : {intValue}, {intValue.GetType()}");

Console.WriteLine(" **************************************** ");

/*
int num1 = 10;
int num2 = 20;
int num3 = num1 + num2;
Console.WriteLine($"Num1 : {num1}, Num2 : {num2}, Num3: {num3}");
*/

/* byte, short and char gets converted to the int implicity before the calculations.*/

/*
byte num1 = 200;
byte num2 = 100;
int num3 = num1 + num2;
Console.WriteLine($"Num1 : {num1}, Num2 : {num2}, Num3: {num3}");
*/

byte num1 = 10;
byte num2 = 20;
byte num3 = (byte) (num1 + num2);
Console.WriteLine($"Num1 : {num1}, Num2 : {num2}, Num3: {num3}");

short num11 = 10;
short num22 = 20;
short num33 = (short) (num11 + num22);
int num44 = num11 + num22;
Console.WriteLine($"Num1 : {num11}, Num2 : {num22}, Num3: {num33}");

char num111 = 'A';
char num222 = 'B';
char num333 = (char)(num111 + num222);
int num444 = num111 + num222;
Console.WriteLine($"Num1 : {num111}, Num2 : {num222}, Num3: {num333}");

Console.ReadKey();

/* ********************************************************* */

// See https://aka.ms/new-console-template for more information

double priceInEuros = 25.0;
decimal priceInPounds = 35.5m;
float taxRate = 0.08f; // 8% Tax Rate

// Convert Euros to USD (1 Euro = 1.12 USD)
double priceInUSDFromEuros = priceInEuros * 1.12;

// Convert Pounds to USD (1 Pound = 1.36 USD)
double priceInUSDFromPounds = (double)priceInPounds * 1.36;

// Calculate the total cost including tax in USD
double totalCostInUSD = priceInUSDFromEuros + priceInUSDFromPounds;
double totalCostWithTax = totalCostInUSD * (1 + taxRate);

// Display Results:
Console.WriteLine($"Price in Euros: {priceInEuros} Euro(s)");
Console.WriteLine($"Price in USD(Converted): {priceInUSDFromEuros} USD");
Console.WriteLine($"Price in Pounds: {priceInPounds} Pound(s)");
Console.WriteLine($"Price in USD(Converted): {priceInUSDFromPounds} USD");
Console.WriteLine($"Total Cost without Tax in USD: {totalCostInUSD} USD");
Console.WriteLine($"Total Cost with Tax in USD: {totalCostWithTax} USD");

Console.ReadKey();