using System;
using System.Collections.Generic;

class Program
{
    static List<User> Users = new List<User>
    {
        new User { Username = "İbrahim", Password = "sifre123", Role = "admin" },
        new User { Username = "Ahmet", Password = "sifre234", Role = "user" },
        new User { Username = "Ali", Password = "sifte345", Role = "user" }
    };

    static void Main()
    {
        Console.WriteLine("Hoş Geldiniz!");

        User authenticatedUser = AuthenticateUser();

        if (authenticatedUser != null)
        {
            Console.WriteLine("Giriş başarılı!");

            if (IsAdmin(authenticatedUser))
            {
                Console.WriteLine("Admin yetkisine sahipsiniz. Özel işlemleri gerçekleştirebilirsiniz.");
            }
            else
            {
                Console.WriteLine("Standart kullanıcı yetkilerinizle sınırlı işlemleri gerçekleştirebilirsiniz.");
            }
        }
        else
        {
            Console.WriteLine("Giriş başarısız. Program sonlandırılıyor.");
        }
    }

    static User AuthenticateUser()
    {
        Console.Write("Kullanıcı Adı: ");
        string username = Console.ReadLine();

        Console.Write("Şifre: ");
        string password = Console.ReadLine();

        foreach (User user in Users)
        {
            if (user.Username == username && user.Password == password)
            {
                return user; 
            }
        }

        return null; 
    }

    static bool IsAdmin(User user)
    {
        return user.Role == "admin";
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}
