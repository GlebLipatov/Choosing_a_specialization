string[] words = {"hello", "2000", "world", ":0-)"};
string strings = string.Empty;
string[] result;

foreach(string word in words)
{
    if (word.Length <= 3) strings += $"{word} ";
}

result = strings.Split(" ");