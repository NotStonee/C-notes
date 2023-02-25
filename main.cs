      using System;
/* int - stores integers (whole numbers), without decimals, such as 123 or -123 same as long but holds less info
double - stores floating point numbers, with decimals, such as 19.99 or -19.99 same as float but holds less info
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false
*/

/* Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char

changes data type example:

int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
<------------------------------------------------------------------>
double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
*/
//The Math.Max(x,y) method can be used to find the highest value of x and y
//The Math.Min(x,y) method can be used to find the lowest value of of x and y
//Math.Round() rounds a number to the nearest whole number
class Program {
  public static void Main (string[] args) {
    //code goes in this block
    const int num = 10; //const keeps value constant 
    int x = 2, b = 2, c = 11; //can declare multiple with ,
    double num2 = 10.121;
    num2 = 50.21; //redeclare just like js
    char letter = 'a';
    string words = "hello";
    bool which = false;    
    Console.WriteLine ("Hello World");
    Console.Write (num); //write keeps it on the same line
    Console.WriteLine (num2);
    Console.WriteLine (num + num2); //math logic works like js
    Console.WriteLine (x / b * c);
    Console.WriteLine (letter);
    string txt = "Hello World";
    Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD" makes text all uper
    Console.WriteLine(txt.ToLower());   // Outputs "hello world" makes text all lower
    Console.WriteLine (words);
    Console.WriteLine (which);
    Console.WriteLine ("say something");
    //Console.ReadLine(); gets user info
    string user = Console.ReadLine();
    Console.WriteLine ("You said " + user);
  }
} 