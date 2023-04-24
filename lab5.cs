using System;
class main {
  static void Main() {
      
   string sentence = "Це речення з декількома    прогалинами   та  пробілами.";
int maxSpaces = 0;
int currentSpaces = 0;
foreach (char c in sentence)
{
    if (c == ' ')
    {
        currentSpaces++;
        if (currentSpaces > maxSpaces)
        {
            maxSpaces = currentSpaces;
        }
    }
    else
    {
        currentSpaces = 0;
    }
}
Console.WriteLine("Найбільша кількість пробілів, що розташовані підряд: " + maxSpaces);

  }
}