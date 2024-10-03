Console.Write("Lütfen bir sayi giriniz.");
string num = Console.ReadLine();
bool isnum = int.TryParse(num, out int num2);

if (isnum)
{


if (num2 > 10)
{
    if (num2 % 2 == 0)
    {
        Console.WriteLine("girilen sayı 10'dan büyüktür.");
        Console.WriteLine("girilen sayı çifttir.");
    }

    else
    {
        Console.WriteLine("girilen sayı 10'dan büyüktür.");
        Console.WriteLine("girilen sayı tektir..");
    }
}

else if (num2 == 10)
{
    Console.WriteLine("girilen sayı 10'dur");
    Console.WriteLine("girilen sayı çifttir.");
}

else
{
    if (num2 % 2 == 0)
    {
        Console.WriteLine("girilen sayı 10'dan küçüktür..");
        Console.WriteLine("girilen sayı çifttir.");
    }

    else
    {
        Console.WriteLine("girilen sayı 10'dan küçüktür.");
        Console.WriteLine("girilen sayı tektir..");
    }
}



}

else
{
    Console.WriteLine("lütfen sayı giriniz.");
}
