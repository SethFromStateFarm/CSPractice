class Joker {
 static void Joke() {
  string[] jokes = [
    "Accuse others of stealing your keys",
    "Taking a long drive? Pretend someone poured a cold drink down your back",
    "Take a seat and write down the names of all the people or situations in your life that are causing you angst. Then throw them in the bowl and flush.",
    "If you don't have enough time in the morning to brush your teeth, just add toothpaste to your food",
    "If you don't know where your children are in your house, turn off the internet and watch them appear",
    "Accept who you are. Unless you're a serial killer.",
    "Before you marry someone, make them use a computer with slow internet to see who they really are.",
    "If you swim with a friend, your chances of getting eaten by a shark will Drop by 50%",
    "For $1, you can buy a candy bar from a vending machine. For $2, you can buy a brick, and get all the candy in the vending machine.",
    "Never walk on ice with your hands in your pockets.",
    "Never joke with a kleptomaniac, whey will take it, literally.",
    "Don't give up on your dream, keep on sleeping",
  ]
   Random pick = new Random();
   string joke = jokes[pick.Next(0, jokes.Length-1];
   Console.WriteLine(joke); 
  }
}

class Program {
  static void Main(string[] args) {
    Joker the = new Joker();
      the.joke; 
  }
}

// The expected outcome of the program above is to print a random joke each time the process is ran!
