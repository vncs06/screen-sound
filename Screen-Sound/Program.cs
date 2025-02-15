//List<string> BandList = new List<string> {"U2", "The Beatles", "Queen", "Calcinha Preta"};
Dictionary<string, List<int>> BandList = new Dictionary<string, List<int>>();
BandList.Add("Link Park", new List<int> { 10, 8, 5 });
BandList.Add("Calypso", new List<int>());

// Screen Sound Porject(temp name)
void ShowWelcomeMessage()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

    Console.WriteLine("\nBem vindo ao Screen Sound!\n");
    

}
ShowWelcomeMessage();

//Menu Options
void ShowOptions()
{
    
    Console.WriteLine("Type 1 to register a band");
    Console.WriteLine("Type 2 to view the registered bands");
    Console.WriteLine("Digite 3 para excluir um artista");

    Console.Write("\nWrite the chosen option: ");
    string chosenOption = Console.ReadLine()!;
    int convertChosenOption = int.Parse(chosenOption);
    switch (convertChosenOption)
    {
        case 1: RegisterBand();
            break;
        case 2: ViewRegisteredBands();
            break;
        case 3: RateBand();
            break;

    }

}

//Register band function
void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Register your bands");
    Console.Write("Type the name of the band that you want to register: ");
    string Band = Console.ReadLine()!;
    BandList.Add(Band, new List<int>());
    Console.WriteLine($"The band {Band} was successfully registered");
    Thread.Sleep(2000);
    Console.Clear();
    ShowWelcomeMessage();
    ShowOptions();

}

//View registered function
void ViewRegisteredBands()
{
    Console.Clear();
    ShowOptionTitle("View registered bands\n");
    foreach (string i in BandList.Keys)
    {
        Console.WriteLine($"Band: {i}");

    }

    Console.WriteLine("\nType any key to back option...");
    Console.ReadKey();
    Console.Clear();
    ShowWelcomeMessage();
    ShowOptions();

}

//Rate a band(if it exist)
void RateBand()
{
    Console.Clear();
    ShowOptionTitle("Rate a band");
    Console.Write("What band do you want to rate? ");
    string BandRateChosen = Console.ReadLine()!;
    if (BandList.ContainsKey(BandRateChosen))
    {
        Console.Write($"What grade does the band {BandRateChosen} deserve? ");
        int grade = int.Parse(Console.ReadLine()!);
        BandList[BandRateChosen].Add(grade);
        Console.WriteLine($"\nThe grade {grade} has been successfuly added...");
        Thread.Sleep(2000);
        Console.Clear();
        ShowWelcomeMessage();
        ShowOptions();

    }
    else
    {
        Console.WriteLine("\nYour band not exist in our system. Type any key to back option...");
        Console.ReadKey();
        Console.Clear();
        ShowWelcomeMessage();
        ShowOptions();
        
    }

}

void ShowOptionTitle(string title)
{
    int TitleLetters = title.Length;
    string asteriscos = string.Empty.PadLeft(title.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(title);
    Console.WriteLine($"{asteriscos}\n");

}

ShowOptions();