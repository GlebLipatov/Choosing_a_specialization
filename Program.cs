string[] words = { "hello", "2", "world", ":-)" };
string[] result;
const int MAXLENGTH = 3;

result = GetWords(words, MAXLENGTH).Split(" ");

string GetWords(string[] words, int maxLength)
{
    string strings = string.Empty;
    foreach (string word in words)
    {
        if (word.Length <= maxLength) strings += $"{word} ";
    }
    return strings;
}