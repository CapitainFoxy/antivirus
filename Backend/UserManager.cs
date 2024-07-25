using System;
using System.Collections.Generic;

public static class UserManager
{
    private static readonly Dictionary<string, string> users = new Dictionary<string, string>
    {
        { "admin", "password123" }
    };

    public static bool Authenticate(string username, string password)
    {
        return users.TryGetValue(username, out string storedPassword) && storedPassword == password;
    }
}
