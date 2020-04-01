using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    class Program
    {
        public static PersoaneContact citestePersoana()
        {
            string num, pren, numarTel, Email, grup1;
            Grup grup;
            Console.WriteLine("Citeste numele persoanei: ");
            num = Console.ReadLine();
            Console.WriteLine("Citeste prenumele persoanei: ");
            pren = Console.ReadLine();
            Console.WriteLine("Citeste numarul de telefon al persoanei: ");
            numarTel = Console.ReadLine();
            Console.WriteLine("Citeste emai-ul persoanei: ");
            Email = Console.ReadLine();
            Console.WriteLine("Citeste grupul persoanei: ");
            grup1 = Console.ReadLine();
            Enum.TryParse(grup1, out grup);

            return new PersoaneContact(num, pren, numarTel, Email,grup);
            
        }
        
        

        static void Main(string[] args)
        {
            // Initializarea unui obiect de tip persoana cu parametri 
            PersoaneContact p0 = new PersoaneContact("Baciu","Emanuel","0743307248","emy_baciu@yahoo.com",Grup.Familie);
            Console.WriteLine(p0.ConversieLaSir());
            Console.WriteLine(p0.DataNasterii = new DateTime(1999,01,03)) ;

            Console.ReadKey();

            //Intantierea unui obiect de tip Persoana cu parametrii intr-un sir de caractere
            PersoaneContact p1 = new PersoaneContact("Donici","Andreea","0756818340","andreea@yahoo.com",Grup.Familie);
            Console.WriteLine(p1.ConversieLaSir());
            Console.WriteLine(p1.DataNasterii = new DateTime(1999, 07, 31));

            //Instantierea unui obiect de tip Persoana cu parametrii introdusi de la tastatura
            Console.WriteLine("\nIntroduceti numele, prenumele, numarul de telefon, adresa de e-mail a persoanei de contact! ");
            PersoaneContact p2 = new PersoaneContact(Console.ReadLine(),Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Grup.Familie);

            Console.WriteLine("\nIntroduceti data nasterii in ordine: anul,luna,ziua:YYYY-XZ-HH");
            p2.DataNasterii = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(p2.ConversieLaSir());
            Console.WriteLine( p2.nastere());

            if (p1.Compara(p2) == PersoaneContact.MARE)
            {
                Console.WriteLine(p1.NumeleComplet + " Sunt egale " + p2.NumeleComplet);
            }
            else if(p1.Compara(p2) == PersoaneContact.EGAL)
            {
                Console.WriteLine(p1.NumeleComplet + " este mai mare decat " + p2.NumeleComplet);
            }
            else
            {
                Console.WriteLine(p2.NumeleComplet +" este mai mare decat " +p1.NumeleComplet);
            }
         
            PersoaneContact persoanaCititaTas = citestePersoana();
            Console.WriteLine(persoanaCititaTas);

            Console.ReadKey();
        }
    }
}
