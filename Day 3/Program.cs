// Advent of Code Day 3

string exampleInput = @".242......276....234............682.......................958..695..742................714......574..............833.........159....297.686.
.............*............................612*......304..*..........*.......@175...#...*...........*890...........*.............*..*........
..........346......................997........923......*..253..........698........122.746.....-832..........766.432..229.....674....415.....";

// Take exampleInput and convert it to a 2D array
string[] exampleInputLines = exampleInput.Split("\n");


// Rules:
// "." does not count as a symbol.
// Any number, no matter how many digits, if is adjacent to a symbol, even diagonally counts as a "part" number.
// Example:
// 467..114..
// ...*......
// ..35..633.
// 
// 467 counts as 1 part number, 114 does not count as a part number, 35 counts as 1 part number, 633 does not count as a part number.

// Create a list of symbols
List<char> symbols = new() { '*', '@', '#', '-', '%', '/', '\\', '=', '-', '$', '+', '&' };

// Take exampleInputLines and convert it to a 2D array of chars
char[,] exampleInputChars = new char[exampleInputLines.Length, exampleInputLines[0].Length];
for (int i = 0; i < exampleInputLines.Length; i++)
{
    for (int j = 0; j < exampleInputLines[i].Length; j++)
    {
        exampleInputChars[i, j] = exampleInputLines[i][j];
    }
}

// Print exampleInputChars
for (int i = 0; i < exampleInputChars.GetLength(0); i++)
{
    for (int j = 0; j < exampleInputChars.GetLength(1); j++)
    {
        Write(exampleInputChars[i, j]);
    }
    WriteLine();
}

// create a list of ints to store the part numbers
List<int> partNumbers = new List<int>();

// Iterate through exampleInputChars and find the part numbers
for (int i = 0; i < exampleInputChars.GetLength(0); i++)
{
    for (int j = 0; j < exampleInputChars.GetLength(1); j++)
    {
        // Check to see if the current char is a symbol. Use the symbols list to check.
        if (symbols.Contains(exampleInputChars[i, j]))
        {
            // Check to see if the char is above a number.
            
        }
    }

}


