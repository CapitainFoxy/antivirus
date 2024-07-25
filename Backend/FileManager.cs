using System.IO;

public static class FileManager
{
    public static void CopyFile(string sourcePath, string destPath)
    {
        File.Copy(sourcePath, destPath, overwrite: true);
    }

    public static void DeleteFile(string path)
    {
        File.Delete(path);
    }
}
