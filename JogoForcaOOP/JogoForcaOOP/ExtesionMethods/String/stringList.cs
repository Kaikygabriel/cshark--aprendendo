namespace System;

public static class stringList
{
    public static List<char> ToListChar(this string word)
    {
        List<char> List = new List<char>();
        for (int i = 0; i <= word.Length -1 ; i++)
        {
            List.Add(word[i]);
        }
    
        return List;
    }

}