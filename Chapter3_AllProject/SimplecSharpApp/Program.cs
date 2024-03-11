//*************CHAPTER 3***************

//Topic 1: Breaking Down a Simple C# Program (Updated C# 10)

//Unlike some other programming languages, it is not possible in C# to create global points of data.
//All program logic is contained within a type definition {class, interface, structure, enumeration, delegate}.
//Prior to C# 10 -
/*
using System;
namespace SimpleCSharpApp
{
    class Program
    {
        //Main() method is the entry point of the program which accepts an array of strings(Command line arguments)
        static void Main(string[] args) - .
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/

//Now - Console.WriteLine("Hello World!");

//Topic 2: Top Level Statements - eliminates the need to wrap program in a class.

//Topic 3: Specifying an Application Error Code (Updated 9.0)

// While a vast majority of your Main() methods (or top-level statements) will return void as the return value,
// the ability to return an int (or Task<int>) keeps C# consistent with other C-based languages.
/*
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
Console.ReadLine();
// Return an arbitrary error code.
return -1;
*/

//Topic 4: processing command line arguments

//to add a CLA in visual studio 2022 -> right click on folder -> properties -> debug 
/*
//generally processed using a loop.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Arg: {0}", args[i]);
}

//by using GetCommandLineArgs() method.
string[] theArgs = Environment.GetCommandLineArgs();
foreach(string arg in theArgs)
{
Console.WriteLine("Arg: {0}", arg);
}
Console.ReadLine();
*/

//Topic 5: Members of the System.Environment Class

//System.Envitonment class helps get useful details about the environment:
/*
ShowEnvironmentDetails();

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}",
    Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}",
    Environment.Version);
    Console.WriteLine($"Is 64bit?: {Environment.Is64BitOperatingSystem}");
    Console.WriteLine($"Machine name: {Environment.MachineName}");
    Console.WriteLine($"UserName: {Environment.UserName}");
}
*/

//Topic 6: Members of the System.Console Class
//Console class encapsulates input, output, and error-stream manipulations for console - based applications.
/*
Console.WriteLine("I am WriteLine method.");
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Blue;
Console.Beep();
*/

//Topic 7: Performing input and output with the console class.
/*
GetUserData();
static void GetUserData()
{
    // Get name and age.
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string userAge = Console.ReadLine();
    // Change echo color, just for fun.
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    // Echo to the console.
    Console.WriteLine("Hello {0}! You are {1} years old.",
    userName, userAge);
    // Restore previous color.
    Console.ForegroundColor = prevColor;
}
*/

//Topic 8: Formatting Console Output
//Displaying data using placeholders.
//Console.WriteLine("{0}, {1}, {1}", "First", "Second", "Third");

//Topic 9: Formatting Numerical Data
/*
FormatNumericalData();
Console.WriteLine($"{1234:c}");
static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");
    Console.WriteLine("c format: {0:c}", 99999);
    Console.WriteLine("d9 format: {0:d9}", 99999);
    Console.WriteLine("f3 format: {0:f3}", 99999);
    Console.WriteLine("n format: {0:n}", 99999);
    // Notice that upper- or lowercasing for hex
    // determines if letters are upper- or lowercase.
    Console.WriteLine("E format: {0:E}", 99999);
    Console.WriteLine("e format: {0:e}", 99999);
    Console.WriteLine("X format: {0:X}", 99999);
    Console.WriteLine("x format: {0:x}", 99999);
}
// Using String.Format();
string userMessage = string.Format($"100000 in hex is {100000:x}");
*/

//Topic 10: Data types and corresponding keywords.
//CLS - Common Language Specification - It defines a set of rules and restrictions that every language must follow which runs under the .NET framework.
//See table - page 126

//Topic 11: Variable declarations

//dataType variableName = variableValue;
/*
System.Int32 myInt = 100;
int anotherInt = 200;
int iOne = 1, iTwo = 2, iThree = 3;
Console.WriteLine(myInt);
*/

//Topic 12: Default declarations.
// see page 129 for list of default values
/*
int myInt = default;
Console.WriteLine(myInt);
Console.WriteLine("=> Using new to create variables:");
bool b = new(); // Set to false.
int i = new(); // Set to 0.
double d = new(); // Set to 0.
DateTime dt = new(); // Set to 1/1/0001 12:00:00 AM

Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
Console.WriteLine();
*/

//Topic 13: Understanding the Data Type Class Hierarchy
//types at the top of a class hierarchy provide some default behaviors that are granted to the derived types - see page 130
//each type ultimately derives from System.Object, which defines a set of methods (e.g.,ToString(), Equals(), GetHashCode()) common to all types in the .NET Core base class libraries
/*
//Methods of value type
Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
Console.WriteLine("12.ToString() = {0}", 12.ToString());
Console.WriteLine("12.GetType() = {0}", 12.GetType());
*/

//Topic 14: Numerical Data types
/*
Console.WriteLine("=> Data type Functionality:");
Console.WriteLine("Max of int: {0}", int.MaxValue);
Console.WriteLine("Min of int: {0}", int.MinValue);
Console.WriteLine("Max of double: {0}", double.MaxValue);
Console.WriteLine("Min of double: {0}", double.MinValue);
Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
Console.WriteLine("double.PositiveInfinity: {0}",
double.PositiveInfinity);
Console.WriteLine("double.NegativeInfinity: {0}",
double.NegativeInfinity);
*/

//Topic 15: Boolean Data types
/*
Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
*/

//Topic 16: Char data types
//Single character inside '' brackets.
//Using the static methods of System.Char, you are able to determine whether a given character is numerical, alphabetical, a point of punctuation, or whatnot
/*
Console.WriteLine("=> char type Functionality:");
char myChar = 'a';
Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
char.IsWhiteSpace("Hello There", 5));
Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
char.IsWhiteSpace("Hello There", 6));
Console.WriteLine("char.IsPunctuation('?'): {0}",
char.IsPunctuation('?'));
Console.WriteLine();
*/

//Topic 17: Parsing values from string data
//This technique is helpful when you want to convert some user input data into a numerical value.
/*
Console.WriteLine("=> Data type parsing:");
bool b = bool.Parse("True");
Console.WriteLine("Value of b: {0}", b);
double d = double.Parse("99.884");
Console.WriteLine("Value of d: {0}", d);
int i = int.Parse("8");
Console.WriteLine("Value of i: {0}", i);
char c = Char.Parse("w");
Console.WriteLine("Value of c: {0}", c);
Console.WriteLine();
*/

//Topic 18: Using TryParse to Parse Values from String Data
/*
Console.WriteLine("=> Data type parsing with TryParse:");
if (bool.TryParse("True", out bool b))
{
    Console.WriteLine("Value of b: {0}", b);
}
else
{
Console.WriteLine("Default value of b: {0}", b);
}

string value = "Hello";
if (double.TryParse(value, out double d))
{
    Console.WriteLine("Value of d: {0}", d);
}
else
{
    Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value , d);
}
Console.WriteLine();
*/

//Topic 19: System.DateTime and System.TimeSpan
//The DateTime type contains data that represents a specific date (month, day, year) and time value, both
//of which may be formatted in a variety of ways using the supplied members.The TimeSpan structure allows
//you to easily define and transform units of time using various members.

/*
Console.WriteLine("=> Dates and Times:");
// This constructor takes (year, month, day).
DateTime dt = new DateTime(2015, 10, 17);
// What day of the month is this?
Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
// Month is now December.
dt = dt.AddMonths(2);
Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
// This constructor takes (hours, minutes, seconds).
TimeSpan ts = new TimeSpan(4, 30, 0);
Console.WriteLine(ts);
// Subtract 15 minutes from the current TimeSpan and
// print the result.
Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
*/

//DateOnly and TimeOnly were added in C# 10.
/*
DateOnly d = new DateOnly(2021, 07, 21);
Console.WriteLine(d);
TimeOnly t = new TimeOnly(13, 30, 0, 0);
Console.WriteLine(t);
*/

//Topic 20: System.Numerics Namespace
//The System.Numerics namespace defines a structure named BigInteger. As its name implies, the using System.Numerics;
//BigInteger data type can be used when you need to represent humongous numerical values, which are not constrained by a fixed upper or lower limit.

/*
using System.Numerics;

BigInteger biggy =
BigInteger.Parse("9999999999999999999999999999999999999999999999");
Console.WriteLine(biggy);
*/


//Checked and unchecked keywords:
//When you use the checked keyword, arithmetic overflow checking is enforced, and if an overflow occurs, an OverflowException is thrown.
//This is the safer option as it ensures that overflows are caught and handled appropriately.
/*
int a = int.MaxValue; // a is set to the maximum value of int
int b = 1;
checked
{
    int result = a + b; // This will cause an OverflowException
    Console.WriteLine(result);
}*/


/*
//Disable checking causes unexpected results
int a = int.MaxValue; // a is set to the maximum value of int
int b = 1;
unchecked
{
    int result = a + b; // result will be a very large negative number
    Console.WriteLine(result);
}
*/

//Topic 21: Using Digit Separators
/*
Console.Write("Integer:");
int newInt = 123_456_789;
Console.WriteLine(newInt);
*/

//Topic 22: Using Binary Literals
/*
Console.WriteLine("=> Use Binary Literals:");
Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
*/

//Topic 23: Performing basic string manipulation.
//See page 138.
/*
Console.WriteLine("=> Basic String functionality:");
string firstName = "Freddy";
Console.WriteLine("Value of firstName: {0}", firstName);
Console.WriteLine("firstName has {0} characters.", firstName.Length);
Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
Console.WriteLine("firstName contains the letter y?: {0}",
firstName.Contains("y"));
Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
Console.WriteLine();
*/

//Topic 24: Performing string concatenation.
/*
//Using += or +
Console.WriteLine("=> String concatenation:");
string s1 = "Programming the ";
string s2 = "PsychoDrill (PTP)";
string s3 = s1 + s2;
Console.WriteLine(s3);

//using string.concat();
Console.WriteLine("=> String concatenation:");
string p1 = "Programming the ";
string p2 = "PsychoDrill (PTP)";
string p3 = String.Concat(p1, p2);
Console.WriteLine(p3);
Console.WriteLine();
*/

//Topic 25: Using Escape Characters
//See page 140 for table.
/*
Console.WriteLine("=> Escape characters:");
string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
Console.WriteLine(strWithTabs);
Console.WriteLine("Everyone loves \"Hello World\" ");
Console.WriteLine("C:\\MyApp\\bin\\Debug ");
// Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
Console.WriteLine("All finished.\n\n\n ");
*/

//Topic 26: Performing string interpolation
/*
Console.WriteLine("=> String interpolation:\a");
// Some local variables we will plug into our larger string
int age = 4;
string name = "Soren";
// Using curly-bracket syntax.
string greeting = string.Format("Hello {0} you are {1} years old.", name, age);
Console.WriteLine(greeting);
// Using string interpolation
string greeting2 = $"Hello {name} you are {age} years old.";
Console.WriteLine(greeting2);
*/


//Topic 27: Defining Verbatim Strings (Updated 8.0)
//created by prefixing with @. The string is read as is(escape characters are not read)
/*
string myLongString = @"This is a very
              very
       very
long string";
Console.WriteLine(myLongString);
Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
string interp = "interpolation";
string myLongString2 = $@"This is a very
very
long string with {interp}";
Console.WriteLine(myLongString2) ;
*/

//Note: The position of $@ doesnot matter. both $@ and @$ will work.

//Topic 28: String Equality
/*
when you perform a test for equality on reference types (via the C# == and != operators), you will be returned true if the references are 
pointing to the same object in memory. However, even though the string data type is indeed a reference type, the equality operators have
been redefined to compare the values of string objects, not the object in memory to which they refer.
*/
/*
Console.WriteLine("=> String equality:");
string s1 = "Hello!";
string s2 = "Yo!";
Console.WriteLine("s1 = {0}", s1);
Console.WriteLine("s2 = {0}", s2);
Console.WriteLine();
// Test these strings for equality.
Console.WriteLine("s1 == s2: {0}", s1 == s2);
Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
Console.WriteLine();
*/

//Topic 29: Modifying string comparision behaviour.

//firstString.ToUpper() == secondString.ToUpper()) - common way but can cause performation issues(copy of string is created)
//Alternative can be StringComparision Methods. - see page 145
/*
Console.WriteLine("=> String equality (Case Insensitive:");
string s1 = "Hello!";
string s2 = "HELLO!";
Console.WriteLine("s1 = {0}", s1);
Console.WriteLine("s2 = {0}", s2);
Console.WriteLine();
// Check the results of changing the default compare rules.
Console.WriteLine("Default rules: s1={0},s2={1} s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2,s1.IndexOf("E"));
Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
*/

//Topic 30: Strings are Immutable
//After you assign a string object with its initial value, the character data cannot be changed.
/*
Console.WriteLine("=> Immutable Strings:\a");
// Set initial string value.
string s1 = "This is my string.";
Console.WriteLine("s1 = {0}", s1);
// Uppercase s1?
string upperString = s1.ToUpper();
Console.WriteLine("upperString = {0}", upperString);
// Nope! s1 is in the same format!
Console.WriteLine("s1 = {0}", s1);
*/

//Topic 31: Using the System.Text.StringBuilder Type
//the StringBuilder defines methods that allow you to replace or format segments of the original data. (it does not create copies)
/*
using System.Text;

Console.WriteLine("=> Using the StringBuilder:");
StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
sb.Append("\n");
sb.AppendLine("Half Life");
sb.AppendLine("Morrowind");
sb.AppendLine("Deus Ex" + "2");
sb.AppendLine("System Shock");
Console.WriteLine(sb.ToString());
sb.Replace("2", " Invisible War");
Console.WriteLine(sb.ToString());
Console.WriteLine("sb has {0} chars.", sb.Length);
Console.WriteLine();
*/

//Topic 32: Narrowing and widening data type conversions.

/*
Console.WriteLine("***** Fun with type conversions *****");
// Add two shorts and print the result.
short numb1 = 9, numb2 = 10;
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, Add(numb1, numb2));
Console.ReadLine();
static int Add(int x, int y)
{
    return x + y;
}


//The reason the compiler treats this code as syntactically sound is because there is no possibility for
//loss of data. Given that the maximum value of a short (32,767) is well within the maximum range of an int
//(2,147,483,647), the compiler implicitly widens each short to an int.

//Compiler error
short numb1 = 30000, numb2 = 30000;
short answer = Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, answer);

// Another compiler error!
static void NarrowingAttempt()
{
byte myByte = 0;
int myInt = 200;
myByte = myInt;
Console.WriteLine("Value of myByte: {0}", myByte);
}
Console.WriteLine("***** Fun with type conversions *****");
short numb1 = 30000, numb2 = 30000;
// Explicitly cast the int into a short (and allow loss of data).
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, answer);
NarrowingAttempt();
Console.ReadLine();
static int Add(int x, int y)
{
return x + y;
}
static void NarrowingAttempt()
{
byte myByte = 0;
int myInt = 200;
// Explicitly cast the int into a byte (no loss of data).
myByte = (byte)myInt;
Console.WriteLine("Value of myByte: {0}", myByte);
*/


//Topic 33: Understanding implicitly typed local variables
//The var keyword can be used in place of specifying a specific data type (such as int, bool, or string). When you do
//so, the compiler will automatically infer the underlying data type based on the initial value used to initialize
//the local data point.

/*
using System.Runtime.InteropServices;
var myBool = true;
var myString = "Time, marches on...";
Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
Console.WriteLine("myString is a: {0}", myString.GetType().Name);

var myUInt = 0u;
var myInt = 0;
var myLong = 0L;
var myDouble = 0.5;
var myFloat = 0.5F;
var myDecimal = 0.5M;
// Print out the underlying type.
Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
*/

/*
// Error! var cannot be used as field data!
private var myInt = 10;
// Error! var cannot be used as a return value
// or parameter type!
public var MyMethod(var x, var y){}
// Error! Must assign a value!
var myData;
// Error! Must assign value at exact time of declaration!
var myInt;
myInt = 0;
// Error! Can't assign null as initial value!
var myObj = null;
// OK, if SportsCar is a reference type!
var myCar = new SportsCar();
myCar = null;
// Also OK!
var myInt = 0;
var anotherInt = myInt;
string myString = "Wake up!";
var myData = myString;
*/

//Topic 34: Implicitly typed is strongly typed data.
// The variable cannot hold different types of values over its lifetime.
/*
// The compiler knows "s" is a System.String.
var s = "This variable can only hold string data!";
s = "This is fine...";
// Can invoke any member of the underlying type.
string upper = s.ToUpper();
// Error! Can't assign numerical data to a string!
s = 44;
*/

//Topic 35: Usefullness of implicitly typed local variables
//LINQ technology set makes use of query expressions that can yield dynamically created result sets based on the format of the query itself.
//Overuse of implicit typing(via the var keyword) is considered by most developers to be poor style in production code.

//Topic 35: C# iteration constructs
//for, foreach, while, dowhile

//Topic 36: Scopes

//Topic 37: if/else statements