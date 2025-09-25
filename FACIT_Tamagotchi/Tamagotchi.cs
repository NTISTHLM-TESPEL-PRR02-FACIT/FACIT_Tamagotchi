using System;
using System.Collections.Generic;

public class Tamagotchi
{
  private int _hunger;
  private int _boredom;
  private List<string> _words = new List<string>() {"Hewwo"};
  private bool _isAlive;
  
  public string Name;

  public Tamagotchi()
  {
    _isAlive = true;
  }

  public void Feed()
  {
    Console.WriteLine($" [{Name}] eats and becomes less hungry");
    _hunger -= 2;
    if (_hunger < 0)
    {
      _hunger = 0;
    }
  }

  public void Hi()
  {
    int wordNum = Random.Shared.Next(_words.Count);
    Console.WriteLine($" [{Name}] says: {_words[wordNum]}");
    ReduceBoredom();
  }

  public void Teach(string word)
  {
    Console.WriteLine($" [{Name}] learns: {word}");
    _words.Add(word);
    ReduceBoredom();
  }

  public void Tick()
  {
    _hunger++;
    _boredom++;
    if (_hunger > 10 || _boredom > 10)
    {
      _isAlive = false;
    }
  }

  public void PrintStats()
  {
    Console.WriteLine($"Name: {Name} || Hunger: {_hunger} || Boredom: {_boredom} || Vocabulary: {_words.Count} words");
  }

  public bool GetAlive()
  {
    return _isAlive;
  }

  public void ReduceBoredom()
  {
    Console.WriteLine($" [{Name}] is now less bored!");

    _boredom -= 2;
    if (_boredom < 0)
    {
      _boredom = 0;
    }
  }
}