using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DNP3.Models;
using Models;

namespace DNP3.Persistence
{
    public class FileContext
    {
        public IList<Family> Families { get; set; }
        public IList<Adult> Adults { get; set; }
        public IList<User> Users { get; set; }

        private string usersFile = "users.json";
        private string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";
        
        public FileContext()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
            foreach (var user in Users)
            {
                Console.WriteLine(user.UserName);
            }
            
        }
        
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        
    }
}