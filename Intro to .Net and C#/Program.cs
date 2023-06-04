void showOptions()
{
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");
}

while (true)
{
    showOptions();

    if (Int32.TryParse(Console.ReadLine(), out var value))
    {

    }

    int response = Int32.Parse(Console.ReadLine());

    switch (response)
    {
        case 1:
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine();
            break;
    }
}
