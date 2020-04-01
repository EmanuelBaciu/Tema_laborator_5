using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    
    public enum Grup
    {
        Prieteni=0,
        Serviciu=1,
        Familie=2,
    }
    /// <summary>
    /// Persoanele de contact din agenda
    /// </summary>
    /// clasa persoanecontact cu parametri auto-implemented
   public class PersoaneContact
    {
        
        public const int MARE = 1;
        public const int EGAL = 0;
        public const int MIC = 1;

        public Grup grup;
        public Grup Grup { get { return grup; } set { grup = value; } }
        
        public string nume { set; get; } 
        public string prenume { set; get; }
        public string numarTelefon { set; get; }
        public string adresaEmail { set; get; }

        public DateTime DataNasterii { set; get; }
        public string NumeleComplet { get { return nume + "-" + prenume; } }


        public PersoaneContact()
        {
            nume = string.Empty;
            prenume = string.Empty;
            numarTelefon = string.Empty;
            adresaEmail = string.Empty;
            

            

        }
        /// <summary>
        /// Constructor cu parametri
        /// </summary>
        /// <param name="numePersoana"></param>
        /// <param name="nrTel"></param>
        /// <param name="e_mail"></param>
        public PersoaneContact(string numePersoana, string prenumePers, string nrTel, string e_mail, Grup _grup)
       {
            nume = numePersoana;
            prenume = prenumePers;
          numarTelefon = nrTel;
            adresaEmail = e_mail;
            grup =(Grup) _grup;
            

            

        }
        /// <summary>
        /// Constructor care primeste un sir de caractere
        /// </summary>
        /// <param name="pers1"></param>
        public PersoaneContact(string pers1)
        {
            string[] buff = pers1.Split();
            nume = buff[0];
            prenume = buff[1];
            numarTelefon = buff[2];
            adresaEmail = buff[3];
            grup = (Grup)Convert.ToInt32(buff[4]);
            Enum.TryParse(buff[5], out grup);

        }
        

        public static int optGrup()
        {
            Console.WriteLine("Alege o optiune: ");
            Console.WriteLine("0. Prieteni\n"+
                              "2. Serviciu\n"+
                              "3. Familie");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;
        }

        // Afisare date despre contact
        public string ConversieLaSir()
        {
            string buff = "";
            buff +=  "Persoana de contact are numele " + nume + "-" + prenume + " cu numarul de telefon: " + numarTelefon + "  adresa de e-mail: " + adresaEmail + " din grupul " + grup;
            return buff;
        }
        public string nastere()
        {
            return "Data nasterii: " + DataNasterii;
            
        }
        public int Compara(PersoaneContact _persCon)
        {
            return this.NumeleComplet.CompareTo(_persCon.NumeleComplet);
        }
        
        public string ToString()
        {
            return nume + " " + prenume + " face parte din grupul: " + Grup;
        }


    }
}
