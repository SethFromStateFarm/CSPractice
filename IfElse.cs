Console.WriteLine("Give me a number, any number!");
double a = Console.ReadLine();

Console.WriteLine($"Alright we got {a}, now give me another!");
double b = Console.ReadLine();

double sum = a + b;
Console.WriteLine($"And the grand total is... {sum}!!!");

if(a < b) {
  Console.WriteLine($"{b} is greater than {a}!") 
} else if(a > b) {
  Console.WriteLine($"{a} is greater than {b}!"); 
} else {
  Console.WriteLine($"{a} and {b} are equal!"); 
}
