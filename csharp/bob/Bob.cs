using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bob
{
    static public string Hey(string phrase)
    {
        phrase = phrase.Trim();
        bool isShouting = phrase == phrase.ToUpper();
        bool hasLetters = phrase.Any(Char.IsLetter);
        bool isQuestion = phrase.EndsWith("?", StringComparison.Ordinal);

        if (phrase == "")
            return "Fine. Be that way!";
        else if (isShouting && hasLetters)
            return "Whoa, chill out!";
        else if (isQuestion)
            return "Sure.";
        else
            return "Whatever.";
    }
    /*
    public static string Hey(string say)
    {
        string reply = string.Empty;
        say = say.Trim();

        if (say.Length == 0)
        {
            reply = "Fine. Be that way!";  //Saying nothing
        }
        else if (IsAllUpper(say))
        {
            reply = "Whoa, chill out!"; // Yell All Upper Case
        }
        else if (say.Substring(say.Length - 1, 1) == "?") // y.Substring(y.Length-1, 1);
        {
            reply = "Sure.";
        }
        else
        {
            reply = "Whatever.";
        }

        return reply;
    }
    
    private static bool IsAllUpper(string input)
    {
        bool allUpper = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLetter(input[i]) && Char.IsLower(input[i]))
                return false;
        }

        if (!input.Any(c => Char.IsUpper(c)) && !input.Any(c => Char.IsLower(c)))
        {
            allUpper = false;
        }
        return allUpper;
    }
    */
}
