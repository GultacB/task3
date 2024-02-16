Console.WriteLine("dordreqemli ededi daxil edin:");
int number =int.Parse(Console.ReadLine());
int index3 = number / 1000;
int index2 = (number / 100) % 10;
int index1 = (number / 10) % 10;
int index0=number % 10;
Console.WriteLine("Netice:");
Console.WriteLine("cem:" + (index3 + index1));
Console.WriteLine("ferq:" + (index2-index0));
