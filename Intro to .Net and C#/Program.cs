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
string songNowPlaying = "";

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
    if (songQueue.TryPeek(out string? result1))
    {
        songNowPlaying = songQueue.Dequeue();
    }
    else
    {
        Console.WriteLine("No more songs left in queue");
    }
    Console.WriteLine($"Now playing: '{songNowPlaying}'");
    Console.WriteLine("Next song: '{0}'", songQueue.TryPeek(out string? result2) ? songQueue.Peek() : "none queued");
    Console.WriteLine();
}
void handleCase3()
{
    string secondSongName = "";
    if (songQueue.TryPeek(out string? result1))
    {
        secondSongName = songQueue.Dequeue();
    }
    else
    {
        Console.WriteLine("No more songs left to skip");
    }
    Console.WriteLine("Skipped the song '{0}'", secondSongName.Length > 0 ? secondSongName : "none");
    Console.WriteLine($"Now playing: '{songNowPlaying}'");
    Console.WriteLine("Next song: '{0}'", songQueue.TryPeek(out string? result2) ? songQueue.Peek() : "none queued");
    Console.WriteLine();
}
void handleCase4()
{
    Console.WriteLine($"Rewound the song '{songNowPlaying}'");
    Console.WriteLine($"Now playing: '{songNowPlaying}'");
    Console.WriteLine("Next song: '{0}'", songQueue.TryPeek(out string? result) ? songQueue.Peek() : "none queued");
    Console.WriteLine();
}
void handleCase5()
{
    appActive = false;
}

/*
 * List<string> words
 * HashSet<char> Characters
 * store as a string the amount of times a character appears in a sentence
 * "Banana", "apple" -> "a: 4", "b: 1", etc.
 * The result strings should be stored in another list: 
 * List<string> charCount
 */