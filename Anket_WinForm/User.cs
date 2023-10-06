using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_WinForm
{
    public class User
    {
        public string? Name { get; set; } = "No Name";
        public string? Surname { get; set; } = "No Surname";
        public int Age { get; set; }
        public string? Speciality { get; set; } = "No Speciality";
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public string? NativeLanguage { get; set; } = "Azerbaijan";


        //public static User GetUser(string? name,string?surname,int age,
        //    string?speciality,DateTime entryDateTime,string?nativeLanguage)
        //{
        //    return new User
        //    {
        //        Name = name,
        //        Surname = surname,
        //        Age = age,
        //        Speciality = speciality,
        //        EntryDate = entryDateTime,
        //        NativeLanguage = nativeLanguage
        //    };
        //}
    }
}
