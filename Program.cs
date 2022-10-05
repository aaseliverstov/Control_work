﻿//Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Пример:
//["hello","2","world",":-)"] -> ["2",":-)"]
//["1234","1567","-2","computer science"] -> ["-2"]
//["Russia","Denmark","Kazan"] -> []

string[] SearchElementInArrayString(string[] array)
{
    string[] result = new string[0];
    int numberElementArrayResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[numberElementArrayResult] = array[i];
            numberElementArrayResult++;
        }
    }
    return result;
}

string[] AddQuoteInArray(string[] array)
{
    string[] result = new string[array.Length];
    string n = "";
    for (int i = 0; i < array.Length; i++)
    {
        n = array[i];
        result[i] = String.Format($"\"{n}\"", array);
    }
    return result;
}

string[] ArrayString = {"hello", "2", "world", ":-)"};

string[] firstArrayWithQuote = AddQuoteInArray(ArrayString);
string[] resultArrayWithQuote = AddQuoteInArray(SearchElementInArrayString(ArrayString));
Console.WriteLine($"[{String.Join(",", firstArrayWithQuote)}] -> [{String.Join(",", resultArrayWithQuote)}]");
