using System.IO;
using Newtonsoft.Json;

public static class ConfigManager
{
    private static readonly string configPath = @"C:\Config\config.json";

    public static T LoadConfig<T>()
    {
        if (File.Exists(configPath))
        {
            string json = File.ReadAllText(configPath);
            return JsonConvert.DeserializeObject<T>(json);
        }
        return default;
    }

    public static void SaveConfig<T>(T config)
    {
        string json = JsonConvert.SerializeObject(config, Formatting.Indented);
        File.WriteAllText(configPath, json);
    }
}
