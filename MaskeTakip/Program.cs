using Business.Concrete;
using Entities.Concrete;

namespace MaskeTakip
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.Write("Adınız:");
            person1.Name = Console.ReadLine();
            Console.Write("Soyadınız:");
            person1.SurName = Console.ReadLine();
            Console.Write("Doğum Yılınız:");
            person1.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tc Kimlik Numaranız:");
            person1.TcIdentityNo = Convert.ToInt64(Console.ReadLine());


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

        }

         
    }
   
}
