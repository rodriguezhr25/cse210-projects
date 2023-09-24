using System.Text.Json;
using System.Text.Json.Serialization;
// A code template for the category of things known as Journal. 
// Stores a list of journal entries
public class Journal
{

   public List<Entry> _entries = new List<Entry>();

   // A method that add an entry to the journal
   public void AddEntry(Entry entryData)
   {
      _entries.Add(entryData);
   }
   // A method that display all the journal entries
   public void DisplayAll()
   {
      foreach (Entry e in _entries)
      {
         e.Display();
      }

   }
   // A method that save the information in the json file
   public void SaveToFile(string file)
   {
      // Enable support to include fields instead of properties
      var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };

      // Create JSON file and set "options"
      var json = JsonSerializer.Serialize(_entries, options);
      //Save file
      File.WriteAllText(file + ".json", json);
      Console.WriteLine("File Saved Successfully!");

   }
   // A method that load the journal from a given json file
   public void LoadFromFile(string file)
   {
      string json = File.ReadAllText(file + ".json");
      // Enable support to include fields instead of properties
      var options = new JsonSerializerOptions { IncludeFields = true };
      //Get the save items
      var savedEntries = JsonSerializer.Deserialize<List<Entry>>(json,options);
      //Add items to list
      foreach(var s in savedEntries)
      {
          AddEntry(s);
      }
      Console.WriteLine("File Loaded Successfully!");

   }


}