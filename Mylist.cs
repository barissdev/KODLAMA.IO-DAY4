using System;
using System.Collections.Generic;

public class MyDictionary<TKey, TValue>
{

    private Dictionary<TKey, TValue> dataStorage;

    public MyDictionary()
    {
        dataStorage = new Dictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        if (!dataStorage.ContainsKey(key))
        {
            dataStorage.Add(key, value);
            Console.WriteLine($"Eklendi: {key} - {value}");
        }
        else
        {
            Console.WriteLine($"Bu anahtar zaten mevcut: {key}");
        }
    }
}

class Program
{
    static void Main()
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

        myDictionary.Add(10, "on");
        myDictionary.Add(20, "yirmi");
        myDictionary.Add(10, "tekrar on");
    }
}
