using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    class Program
    {
        /*
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
            
        }*/
        
        

        static void Main(string[] args)
        {
            PersoaneContact[] per = new PersoaneContact[10];
            int numarPersoane = 0;

          
            
            while (true)
            {
                Console.WriteLine("\n~~~~~Aplicatie_Agenda~~~~~~\n" +
                                  "F - Afisare persoana Grup cu parametri\n" +
                                  "C - Citeste persoana de la tastatura\n" +
                                  "A - Afisare persoane\n" +
                                  "B - Compara doua persoane\n" +
                                  "Z - Cauta persoana Contact\n"+
                                  "Y - Afiseaza Grupuri persoane\n"+
                                  "R - Modifica persoana Contact\n"+
                                  "I - Info Administrator lista\n" +
                                  "X - EXIT!");
                string opt = Console.ReadLine();
                switch (opt.ToUpper())
                {
                    case "F":
                        // Initializarea unui obiect de tip persoana cu parametri 
                        PersoaneContact p0 = new PersoaneContact("Baciu", "Emanuel", 0743307248, "emy_baciu@yahoo.com", 1);
                        per[numarPersoane++] = p0;
                        Console.WriteLine(p0.ConversieLaSir());
                        Console.WriteLine(p0.DataNasterii = new DateTime(1999, 01, 03));

                        Console.ReadKey();

                        //Intantierea unui obiect de tip Persoana cu parametrii intr-un sir de caractere
                        PersoaneContact p1 = new PersoaneContact("Baciu", "Ionut Emanuel", 0756818340, "ionut@yahoo.com", 2);
                        per[numarPersoane++] = p1;
                        Console.WriteLine(p1.ConversieLaSir());
                        Console.WriteLine(p1.DataNasterii = new DateTime(1999, 07, 31));
                        break;

                    case "C":
                        //Instantierea unui obiect de tip Persoana cu parametrii introdusi de la tastatura
                        Console.WriteLine("\nIntroduceti Numele: ");
                        string num = Console.ReadLine();
                        Console.WriteLine("\nIntroduceti Prenumele: ");
                        string prenum = Console.ReadLine();
                        Console.WriteLine("\nIntroduceti Numarul de Telefon: ");
                        double nrTEl = Convert.ToDouble(Console.ReadLine());
                        while (true)
                        {
                            if (nrTEl.ToString().Length == 10)
                            {
                                Console.WriteLine("Ati introdus un numar valid!");
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Ati introdus un numar gresit!\n" +
                                                  "Aveti doar " + nrTEl.ToString().Length + " Cifre.\n" +
                                                  "Reintroduceti cu atentie 10 cifre:07__________: ");
                                nrTEl = Convert.ToDouble(Console.ReadLine());
                            }

                        }
                        Console.WriteLine("Introduceti Adresa de e-mail: ");
                        string em = Console.ReadLine();
                        Console.WriteLine("Introduceti Grupul din care face parte:\n" +
                                          "1 - Familie\n" +
                                          "2 - Prieteni\n" +
                                          "3 - Serviciu\n" +
                                          "4 - Necunoscut");
                        string gr = Console.ReadLine();
                        while (Convert.ToInt32(gr) < 1 || Convert.ToInt32(gr) > 4)
                        {
                            Console.WriteLine("Reintroduceti grupul din care face parte [1,4]:");
                            gr = Console.ReadLine();
                        }
                        int gru = Convert.ToInt32(gr);

                        per[numarPersoane++] = new PersoaneContact(num, prenum, nrTEl, em, gru);
                        //PersoaneContact p2 = new PersoaneContact(num, prenum, nrTEl, em, gru);

                        Console.WriteLine("\nIntroduceti data nasterii in ordine: anul,luna,ziua:YYYY-XZ-HH");
                        DateTime dataN = Convert.ToDateTime(Console.ReadLine());

                        //Console.WriteLine(dataN.nastere());


                        break;

                    case "A":
                        Console.WriteLine("Aveti un numar de " + numarPersoane + " in agenda.");
                        for (int i = 0; i < numarPersoane; i++)
                        {
                            Console.WriteLine(per[i].ConversieLaSir());
                        }
                        break;

                    case "B":
                        Console.WriteLine("Introduceti id-ul persoanei pentru comparare:");
                        string ID = Console.ReadLine();
                        while(Convert.ToInt32(ID) < numarPersoane || Convert.ToInt32(ID) > (numarPersoane + 1)) //&& Convert.ToInt32(ID) == numarPersoane)
                        {
                            Console.WriteLine("Reintroduceti id- ul persoanei nu mai mare de " + numarPersoane);
                            ID = Console.ReadLine();
                        }
                        int id = Convert.ToInt32(ID);
                        bool ok = false;
                        for (int i = 0; i < numarPersoane; i++)
                        {
                            if (per[id-1].Compara(per[i]))
                            {
                                Console.WriteLine("Persoana: " + per[i+1].NumeleComplet + " are numele mai lung decat " + per[i].NumeleComplet);
                                ok = true;
                            }
                            
                            
                        }
                        break;

                    case "Z":
                        Console.WriteLine("Introdu numele persoanei cautate:");
                        string nump = Console.ReadLine();
                        Console.WriteLine("Introdu prenumele persoanei cautate:");
                        string pnump = Console.ReadLine();
                        for(int i = 0; i < numarPersoane;i++)
                        {
                            if(per[i].NumeleComplet == nump + " " + pnump)
                            {
                                Console.WriteLine("Presoana cautata:");
                                Console.WriteLine(per[i].ConversieLaSir());
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Nu s-a gasit pesoana introdusa de dumneavoastra!");
                            }
                        }
                        
                        break;

                    case "Y":
                        bool k = false;
                        Console.WriteLine("Ce grup doriti sa afisati:\n" +
                                          "1 - Familie\n" +
                                          "2 - Prieteni\n" +
                                          "3 - Serviciu\n" +
                                          "4 - Necunoscut");
                        string gru1 = Console.ReadLine();
                        while (Convert.ToInt32(gru1) < 1 || Convert.ToInt32(gru1) > 4)
                        {
                            Console.WriteLine("Reintroduceti grupul cautat [1,4]:");
                            gru1 = Console.ReadLine();
                        }
                        int gru2 = Convert.ToInt32(gru1);

                        for ( int i = 0; i < numarPersoane; i++)
                        {
                            if(per[i].GRUP == (Grup)gru2)
                            {
                                Console.WriteLine(per[i].ConversieLaSir());
                                k = true;
                            }

                        }
                        if( k == false)
                        {
                            Console.WriteLine("Grupul ales nu contine nici o persoana.");
                        }
                        break;

                    case "R":
                        bool altaPers = true;
                        Console.WriteLine("Introduceti ID- ul persoanei pe care doriti sa o modificati: ");
                        int idd = Convert.ToInt32(Console.ReadLine()) -1;
                        while (altaPers)
                        {
                            Console.WriteLine("1 - Nume\n" +
                                              "2 - Prenume\n" +
                                              "3 - Numar Telefon\n" +
                                              "4 - Adresa e-mail\n" +
                                              "5 - Grupul");
                            int optiune = Convert.ToInt32(Console.ReadLine());

                            if (optiune == 1)
                            {
                                Console.WriteLine("Reintroduceti numele:");
                                per[idd].Nume = Console.ReadLine();
                            }
                            if(optiune == 2)
                            {
                                Console.WriteLine("Reintroduceti prenume:");
                                per[idd].Prenume = Console.ReadLine();
                            }
                            if(optiune == 3)
                            {
                                Console.WriteLine("Reintroduceti Numar de telefon:");
                                per[idd].NumarTelefon =Convert.ToDouble( Console.ReadLine());
                            }
                            if(optiune == 4)
                            {
                                Console.WriteLine("Reintroduceti adresa de e-mail:");
                                per[idd].AdresaEmail = Console.ReadLine();
                            }
                            if(optiune == 5)
                            {
                                Console.WriteLine("Reintroduceti grupul:\n" +
                                                  "1 - Familie\n" +
                                                  "2 - Prieteni\n" +
                                                  "3 - Serviciu\n" +
                                                  "4 - Necunoscut");
                               int GRUP = Convert.ToInt32(Console.ReadLine());
                                per[idd].GRUP = (Grup)GRUP;
                            }
                            Console.WriteLine("Doriti alte modificari? ~ Y/N ~");
                            string danu = Console.ReadLine().ToUpper();
                            if(danu == "Y")
                            {
                                altaPers = true;
                            }
                            else
                            {
                                altaPers = false;
                                per[idd] = per[idd];
                            }
                        }

                        break;

                    case "I":
                        Console.WriteLine("~~~~~Baciu Emanuel-Ionut~~~~~");
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiune inexistenta:");
                        break;

                }
            }
        }
    }
}
