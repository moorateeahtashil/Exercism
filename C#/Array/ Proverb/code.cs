using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> termsList = new List<string>();

        for (int i = 0; i < subjects.Length - 1; i++)
        {
            termsList.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }

        if (subjects.Length > 0)
        {
            termsList.Add($"And all for the want of a {subjects[0]}.");
        }

        return termsList.ToArray();
    }
}
