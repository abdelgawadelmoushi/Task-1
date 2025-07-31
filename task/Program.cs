
Console.WriteLine("Islam's Carpet Cleaning Services");
Console.WriteLine("Charges :  \n " +
    "$25 per small \n " +
    "$35 per large \n " +
    "Sales tax rate is : 6 % \n " +
    "Estimates are valid for 30 days");

Console.WriteLine("number of small carpet");
int smallCarpet = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("number of Large carpet");
int largeCarpet = Convert.ToInt32 (Console.ReadLine());
int smallCost = smallCarpet * 25;
int largeCost = largeCarpet * 35;
int cost = smallCost + largeCost;


Console.WriteLine($"price per small carpets : {smallCost:C}");
Console.WriteLine($"price per Large carpets : {largeCost :C}");
Console.WriteLine($"Cost : {cost:C}");
Console.WriteLine("Tax : $6.6 ");
Console.WriteLine("=====================");
Console.WriteLine($"Total estimate : {cost * 6.6 / 100+ cost :C} ");

Console.WriteLine("This estimate is valid for 30 days");


//------------------------------------------------------------------------




// task 2  (Standard Numeric Format Strings)


//int x = 10;
//int y = 20;

//Console.WriteLine($"equation : {x} + {y} = {x + y:C}");

// the output of the equation i= $30.00 ? 
//because we have used C to refer to the currency within the equation after getting the result of 10 + 20 which is x + y 


//double price = 1234.56;

//Console.WriteLine($"the price is  : {price:C}");



//double percentage = 0.85;
//Console.WriteLine(percentage.ToString("P")); // 85.00 %





//int bytes = 1024;
//Console.WriteLine($"Memory used: {bytes.ToString("X")} bytes"); // Memory used: 400 bytes

