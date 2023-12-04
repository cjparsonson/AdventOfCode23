// Advent of Code 2023 Day 2 Puzzle

//string example =
    //"Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

// Read input.txt line by line and process
TextReader tr = new StreamReader("input.txt");
string line;
int total_sum = 0;
while ((line = tr.ReadLine()!) != null)
{
    // Split into games and cubes
    List<Tuple<string, int>> cubeTuples = SplitIntoGamesAndCubes(line);
    // Test for invalid games
    List<int> validGame = TestForvalidGame(cubeTuples);
    // if the list of invalid games is empty, then all games are valid
    if (validGame.Count == 0)
    {
        WriteLine("Game is invalid");
        
    }
    else
    {
        WriteLine($"Game is valid");
        total_sum = total_sum + validGame[0];
    }
}

// Print the total sum
WriteLine($"Total Sum: {total_sum}");



// Function to split into games and cubes
static List<Tuple<string, int>> SplitIntoGamesAndCubes(string input)
{
    // Definite cubeTuple list
    List<Tuple<string, int>> cubeTuples = new List<Tuple<string, int>>();

    // Split into game and cube components
    string[] gamesAndColours = input.Split(":");
    // Create game tuple
    Tuple<string, int> gameTuple = new Tuple<string, int>(gamesAndColours[0], int.Parse(gamesAndColours[0].Split(" ")[1]));
    cubeTuples.Add(gameTuple);
    // Split into games
    string[] games = gamesAndColours[1].Split(";");
    // Split into colour cubes
    foreach (string game in games)
    {
        string[] cubes = game.Split(",");
        foreach (string item in cubes)
        {
            // Trim leading and trailing spaces
            string trimmedItem = item.Trim();
            // Split into colour and number
            string[] colourAndNumber = trimmedItem.Split(" ");
            // Create cube tuple
            Tuple<string, int> cubeTuple = new Tuple<string, int>(colourAndNumber[1], int.Parse(colourAndNumber[0]));
            cubeTuples.Add(cubeTuple);
        }
    }
    return cubeTuples;
}


// Function to test if colours and numbers go over those in the control set
// Returns a list of game numbers that are invalid
static List<int> TestForvalidGame(List<Tuple<string, int>> cubeTuples)
{
    List<int> validGames = new();
    bool validGame = true;
    // Iterate through the cube tuples, skip the first one as it is the game number
    for (int i = 1; i < cubeTuples.Count; i++)
    {
        // Check the colour and number against the control set
        // If the number is greater than the control set break out of the loop
        if (cubeTuples[i].Item1 == "red" && cubeTuples[i].Item2 > (int)ControlSet.red)
        {
            validGame = false;
            break;
        }
        else if (cubeTuples[i].Item1 == "green" && cubeTuples[i].Item2 > (int)ControlSet.green)
        {
            validGame = false;
            break;
        }
        else if (cubeTuples[i].Item1 == "blue" && cubeTuples[i].Item2 > (int)ControlSet.blue)
        {
            validGame = false;
            break;
        }
    }
    // If the game is valid, add the game number to the list
    if (validGame)
    {
        validGames.Add(cubeTuples[0].Item2);
    }
    return validGames;
}
    


public enum ControlSet 
{
    red = 12,
    green = 13,
    blue = 14,
}
