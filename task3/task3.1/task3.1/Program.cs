

Console.WriteLine(" ilk ucreqemli ededi daxil edin:");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(" ikinci ucreqemli ededi daxil edin:");
int number2 = int.Parse(Console.ReadLine());
int Number1Index2 = number1 / 100;
int Number1Index1 = (number1 / 10) % 10;
int Number1Index0 = number1 % 10;
int Number2Index2 = number2 / 100;
int Number2Index1 = (number2 / 10) % 10;
int Number2Index0 = number2 % 10;
int ResultNumber1 = Number1Index2 * 100 + Number2Index1 * 10 + Number1Index0;
int ResultNumber2 = Number2Index2 * 100 + Number1Index1 * 10 + Number2Index0;
Console.WriteLine("netice:");
Console.WriteLine("ilk eded:"+  ResultNumber1);
Console.WriteLine("ikinci eded:"+  ResultNumber2);



