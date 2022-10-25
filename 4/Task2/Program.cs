/*
привет = (120) + (117) + (110) + (108) + (109) + (119)
Привет = (90) + (117) + (110) + (108) + (109) + (119)
Номера кодировок в UTF-8 условное.

*/

string[] array = new string[5];
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "]");
for (int i = 0; i < 4; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < 5; j++)
    {
        if (array[j].Length < array[MinIndex].Length)
            MinIndex = j;
    }
    string temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");