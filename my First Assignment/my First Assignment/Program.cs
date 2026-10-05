int replay;
int Total;
int allTotal = 0;

do
{
    Console.WriteLine(" Product price : ");
    int productPrice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(" Product quantity : ");
    int productQuantity = Convert.ToInt32(Console.ReadLine());

    Total = productPrice * productQuantity;

    Console.WriteLine($" Product priceTotal : {Total}");

    allTotal = allTotal + Total;

    Console.WriteLine(" Add another product? 1 = Yes, 0 = No");

    replay = Convert.ToInt32(Console.ReadLine());

    while (replay != 1 && replay != 0)
    {
        Console.WriteLine("invalid input add 1=yes or 0=No");

        replay = Convert.ToInt32(Console.ReadLine());
    }

} while (replay == 1);

Console.WriteLine($"allTotal = {allTotal}");