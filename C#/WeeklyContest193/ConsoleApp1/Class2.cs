using System;
using System.Collections.Generic;
using System.Linq;

class UniqueFolderName
{
    public string[] GetFolderNames(string[] names)
    {
        var folderNames = new List<string>();
        var folderNamesDict = new Dictionary<string, int>();
        foreach (string name in names)
        {
            if (folderNames.Contains(name))
            {
                int nextNumber = folderNamesDict.GetValueOrDefault(name, 0) + 1;
                bool isUnique = false;
                while (!isUnique)
                {
                    string newName = name + "(" + nextNumber + ")";
                    if (folderNames.Contains(newName))
                    {
                        nextNumber++;
                    }
                    else
                    {
                        isUnique = true;
                        folderNames.Add(newName);
                        folderNamesDict[name] = nextNumber;
                        folderNamesDict[newName] = 1;
                    }
                }
            }
            else
            {
                folderNames.Add(name);
                folderNamesDict[name] = 0;
            }
        }
        return folderNames.ToArray();
    }

    public static void Main()
    {
        var ob = new UniqueFolderName();
        foreach (string s in ob.GetFolderNames(new string[] { "kaido", "kaido(1)", "kaido", "kaido(1)" }))
            Console.WriteLine(s);
    }
}
