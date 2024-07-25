using System;

public static class UserMenu
{
    public static void Display()
    {
        Console.WriteLine("User Management");
        Console.WriteLine("1. Add User");
        Console.WriteLine("2. Delete User");
        Console.WriteLine("3. View Users");
        Console.WriteLine("4. Return to Main Menu");
        Console.Write("Choose an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                AddUser();
                break;
            case "2":
                DeleteUser();
                break;
            case "3":
                ViewUsers();
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }

    private static void AddUser()
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();
        UserManager.AddUser(username, password);
        Console.WriteLine("User added.");
    }

    private static void DeleteUser()
    {
        Console.WriteLine("Enter username to delete:");
        string username = Console.ReadLine();
        UserManager.DeleteUser(username);
        Console.WriteLine("User deleted.");
    }

    private static void ViewUsers()
    {
        foreach (var user in UserManager.GetUsers())
        {
            Console.WriteLine(user);
        }
    }
}
