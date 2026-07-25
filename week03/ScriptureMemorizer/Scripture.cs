using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Divide el texto en palabras y crea los objetos Word
        string[] splitText = text.Split(' ');
        foreach (string wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Filtra solo las palabras que NO están ocultas
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        // Si hay menos palabras visibles que las que queremos ocultar, ajustamos
        if (visibleWords.Count < numberToHide)
        {
            numberToHide = visibleWords.Count;
        }

        // Oculta palabras aleatorias de las que aún están visibles
        while (hiddenCount < numberToHide)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // La quitamos para no seleccionarla dos veces en el mismo turno
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
