using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationMVC.Business.Genericos
{
    public enum AccessType
    {
        Adm = 0,
        Student = 1,
        Teacher = 2,
    }

    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; } = string.Empty;
        public AccessType AccessType { get; set; }

        private static long _currentId = 0;
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Name = "Marco Antonio Angelo",
                Nickname = "marco.angelo",
                Email = "marco.angelo@prof.sc.senac.br",
                Password = "Bolinha",
                AccessType = AccessType.Teacher,
            }
        };

        public User()
        {
            Id = ++_currentId;
        }
    }
}
