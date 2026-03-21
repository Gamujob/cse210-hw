using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }
  public void DisplayAll()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }
  public void SaveToFile(string file)
  {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}, {entry._promptText}, {entry._entryText}");
      }
    }
  }
  public void LoadFromFile(string file)
  {
    
  }
}