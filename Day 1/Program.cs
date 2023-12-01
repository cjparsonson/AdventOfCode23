// Advent of Code Day 1 Puzzle

using System.Text.RegularExpressions;

// Read input.txt line by line
TextReader tr = new StreamReader("input.txt");
string line;
int total_sum = 0;
int line_count = 0;

while ((line = tr.ReadLine()!) != null)
{
    string converted_line = ReplaceNumberWordsWithDigits(line); // To solve part one, string converted_line = line;
    // Remove non-digits from string
    converted_line = Regex.Replace(converted_line, "[^0-9]", "");
    List<char> digits = new List<char>();
    WriteLine($"{line} >>> {converted_line}");
    foreach (char c in converted_line)
    {
        // If char is digit, parse and add to digits list
        if (Char.IsDigit(c))
        {
            digits.Add(c);
        }
    }
    // Join the first and last digits of the list into a new number
    // Allow for one item lists
    int newNumber;
    if (digits.Count == 1)
    {
        string first_and_last = $"{digits[0]}{digits[0]}";
        newNumber = int.Parse(first_and_last);
        WriteLine($"New Number: {first_and_last} becomes {newNumber}");
    }
    else
    {
        string first_and_last = $"{digits[0]}{digits[digits.Count - 1]}";
        newNumber = int.Parse(first_and_last);
        WriteLine($"New Number: {first_and_last} becomes {newNumber}");
    }
    // Add the new number to the total sum
    total_sum = total_sum + newNumber;
    line_count++;
    WriteLine($"Line {line_count} sum: {total_sum}");
} 

// Print the total sum
WriteLine($"Total Sum: {total_sum}");


// Function to convert words to numbers
static string ReplaceNumberWordsWithDigits(string input)
{
    string[] numberWords = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    string[] numberDigits = { "o1e", "t2o", "t3ree", "f4ur", "f5ve", "s6x", "s7ven", "e8ght", "n9ne" };
    foreach (string numberWord in numberWords)
    {
        if (input.Contains(numberWord))
        {
            input = input.Replace(numberWord, numberDigits[Array.IndexOf(numberWords, numberWord)]);
        }
    }
    return input;
}



