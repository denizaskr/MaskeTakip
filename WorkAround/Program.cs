using Business.Concrete;
using Entities.Concrete;
using System;

namespace WorkAround
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            SelamVer("Deniz Aşkar ");
            Person person1 =new Person();
            person1.FirstName = "deniz";
            person1.LastName = "aşkar";
            person1.DateOfBirthYear = 1900;
            person1.NationalIdentity = 1;
            
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
        static void SelamVer(string isim="")
        {
            Console.WriteLine(""+ isim);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
