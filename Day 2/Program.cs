// Advent of Code 2023 Day 2 Puzzle

// Definite cubeTuple list
List<(string, int)> cubeTuples = new List<(string, int)>();

string example =
    "Game 1: 1 blue, 2 green, 3 red; 7 red, 8 green; 1 green, 2 red, 1 blue; 2 green, 3 red, 1 blue; 8 green, 1 blue";

// Split into game and cube components
string[] gamesAndColours = example.Split(":");
(string game, int gameNumber) gameTuple = (gamesAndColours[0], int.Parse(gamesAndColours[0].Split(" ")[1]));
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
        WriteLine($"Colour: {colourAndNumber[1]} Number: {colourAndNumber[0]}");
        (string colour, int number) cubeTuple = (colourAndNumber[1], int.Parse(colourAndNumber[0]));
        cubeTuples.Add(cubeTuple);
    }
}

// Print out cubeTuples
foreach (var cubeTuple in cubeTuples)
{
    WriteLine($"Text: {cubeTuple.Item1} Number: {cubeTuple.Item2}");
}







public enum ControlSet
{
    red = 12,
    green = 13,
    blue = 14
}