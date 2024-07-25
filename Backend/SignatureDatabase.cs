using System.Collections.Generic;
using System.IO;

public static class SignatureDatabase
{
    private static readonly List<string> virusSignatures = new List<string>
    {
        "exampleSignature1",
        "exampleSignature2"
    };

    public static bool IsInfected(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);
        foreach (var signature in virusSignatures)
        {
            if (fileContent.Contains(signature))
            {
                return true;
            }
        }
        return false;
    }
}
