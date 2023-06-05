void showOptions()
{
    Console.WriteLine("1. Add a song to your playlist");
    Console.WriteLine("2. Play the next song in your playlist");
    Console.WriteLine("3. Skip the next song");
    Console.WriteLine("4. Rewind one song");
    Console.WriteLine("5. Exit");
}

Queue<string> songQueue = new Queue<string>();
bool appActive = true;

while (appActive)
{
    showOptions();

    string response = Console.ReadLine();
    Console.Clear();

    while (!Int32.TryParse(response, out int value) || Int32.Parse(response) <= 0 || Int32.Parse(response) > 5)
    {
        Console.Clear();
        showOptions();
        Console.WriteLine();
        Console.WriteLine("Please input a number that matches one of the options!");
        response = Console.ReadLine();
    }

    int selectedOption = Int32.Parse(response);

    switch (selectedOption)
    {
        case 1:
            handleCase1();
            break;
        case 2:
            handleCase2();
            break;
        case 3:
            handleCase3();
            break;
        case 4:
            handleCase4();
            break;
        case 5:
            handleCase5();
            break;
    }
}

void handleCase1()
{
    Console.Write("Enter song name: ");
    string newSongName = Console.ReadLine();
    songQueue.Enqueue(newSongName);
    Console.WriteLine($"'{newSongName}' added to your playlist.");
    Console.WriteLine($"Next song: '{songQueue.Peek()}'");
    Console.WriteLine();
}
void handleCase2()
{
    Console.WriteLine($"Now playing: '{songQueue.Peek()}'");
    songQueue.Dequeue();
    Console.WriteLine("Next song: '{0}'", songQueue.TryPeek(out string? result) ? songQueue.Peek() : "none queued");
    Console.WriteLine();
}
void handleCase3()
{
    string secondSongName = "";
    while (songQueue.Count >= 2)
    {
        Queue<string> tempQueue = new Queue<string>();

        string firstItem = songQueue.Dequeue();
        tempQueue.Enqueue(firstItem);

        secondSongName = songQueue.Peek();

        if (tempQueue.Count > 1)
        {
            secondSongName = songQueue.Dequeue();
        }

        while (tempQueue.Count > 0)
        {
            string item = tempQueue.Dequeue();
            songQueue.Enqueue(item);
        }
    }
    Console.WriteLine($"Skipped the song '{secondSongName}'");
    Console.WriteLine("Now playing: ''");
    Console.WriteLine("Next song: ''");
    Console.WriteLine();
}
void handleCase4()
{
    Console.WriteLine("Rewound the song ''");
    Console.WriteLine("Now playing: ''");
    Console.WriteLine("Next song: ''");
    Console.WriteLine();
}
void handleCase5()
{
    appActive = false;
}