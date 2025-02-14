List<string> BandList = new List<string> {"U2", "The Beatles", "Queen", "Calcinha Preta"};

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

    }

}

//Register band function
void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Register your bands");
    Console.Write("Type the name of the band that you want to register: ");
    string Band = Console.ReadLine()!;
    BandList.Add(Band);
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
    Console.WriteLine("**********************");
    Console.WriteLine("View registered bands");
    Console.WriteLine("**********************\n");
    foreach (string i in BandList)
    {
        Console.WriteLine($"Band: {i}");

    }

    Console.WriteLine("\nType any key to back option...");
    Console.ReadKey();
    Console.Clear();
    ShowWelcomeMessage();
    ShowOptions();

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