using static System.Console;
Clear();

WriteLine("Введи строки в которых надо искать строку длиной менее 3 символов через ,:");
string startarray = ReadLine()!;
string[] newarray = startarray.Split(",");

for (int i = 0; i < newarray.Length; i++)
{
    if (newarray[i].Length<=3)
    {
        Write($"{newarray[i]} ");
       
    }
}