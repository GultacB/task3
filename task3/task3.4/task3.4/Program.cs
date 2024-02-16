Console.WriteLine("emanetin manatla meblegini daxil edin:");
int amount=int.Parse(Console.ReadLine());
Console.WriteLine("illik faizi daxil edin:");
int pursent=int.Parse(Console.ReadLine());
int income = (amount * pursent) / 100;
int ResultAmount = (amount / 12)+income;
Console.WriteLine("ayliq pul meblegi:"+ ResultAmount);