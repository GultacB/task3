Console.WriteLine("ucreqemli ededi daxil edin:");
int number=int.Parse(Console.ReadLine());
int index2 = number / 100;
int index1 =( number / 10)%10;
int index0=number % 10;
Console.WriteLine("netice:");
int ResultNumber = index2 * 10 + index0;
Console.WriteLine("alinan eded:" +  ResultNumber);