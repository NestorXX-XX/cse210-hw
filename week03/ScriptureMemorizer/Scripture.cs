using System.IO;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();

    public Scripture()
    {
        
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        char[] sep = { ' ', ',', ';', '.', '!', '?', '(', ')', '-', ':', '"' };
        string[] parts = text.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in parts)
        {
            _words.Add(new Word(w));
        }

    }
    public void HideRandomWords()
    {
        int index = Random.Shared.Next(_words.Count);
        while (_words[index].isHidden() == true)
        {
            index = Random.Shared.Next(_words.Count);
        }
        _words[index].Hide();
    } 
    public string GetDisplayText()
    {
        string wordsText = "";
        foreach (Word w in _words)
        {
            wordsText += w.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {wordsText}";
    } 
    public bool isCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.isHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    
    public Scripture LoadScripture(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        int index = Random.Shared.Next(lines.Length);
        string line = lines[index];

        string[] parts = line.Split(",");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int verse = int.Parse(parts[2]);
        int endVerse = int.Parse(parts[3]);
        string text = parts[4];

        if (endVerse != 0)
        {
            return new Scripture(new Reference(book, chapter, verse, endVerse), text);
        }
        else
        {
            return new Scripture(new Reference(book, chapter, verse), text);
        }
    }
}