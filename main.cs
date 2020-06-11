using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("Enter a name of an item");
  string item = Console.ReadLine();
  Console.WriteLine("Item is: " + item);
  Console.WriteLine("Enter a price");
  string price = Console.ReadLine();
  Console.WriteLine("Price is: " + price);
  Console.WriteLine("Enter a quantity");
  string quantity  = Console.ReadLine();
  Console.WriteLine("Quantity is: " + quantity);
  double price1 = Convert.ToDouble(price);
  int quantity1 = Convert.ToInt32(quantity);
  Console.WriteLine("Total Price is: " + price1*quantity1);
 
  


  
  




  }
}