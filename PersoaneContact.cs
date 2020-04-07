using System;

namespace AplicatieTipAgenda
{


    /// <summary>
    /// Persoanele de contact din agenda
    /// </summary>
    /// clasa persoanecontact cu parametri auto-implemented
    public class PersoaneContact
    {
        public Grup GRUP { get; set; }
        public string Nume { set; get; } 
        public string Prenume { set; get; }
        public double NumarTelefon { set; get; }
        public string AdresaEmail { set; get; }

        public DateTime DataNasterii { set; get; }
        public string NumeleComplet { get { return Nume + " " + Prenume; } }
        
        
        public PersoaneContact()
        {
            Nume = string.Empty;
            Prenume = string.Empty;
            NumarTelefon = 0;
            AdresaEmail = string.Empty;
            GRUP = Grup.NonGrup;
            

            

        }
        /// <summary>
        /// Constructor cu parametri
        /// </summary>
        /// <param name="numePersoana"></param>
        /// <param name="nrTel"></param>
        /// <param name="e_mail"></param>
        public PersoaneContact(string numePersoana, string prenumePers, double nrTel, string e_mail, int _grup)
       {
            this.Nume = numePersoana;
            this.Prenume = prenumePers;
          this.NumarTelefon = nrTel;
            this.AdresaEmail = e_mail;
            this.GRUP = (Grup)_grup;
            

            

        }
        /// <summary>
        /// Constructor care primeste un sir de caractere
        /// </summary>
        /// <param name="pers1"></param>
        public PersoaneContact(string pers1)
        {
            string[] buff = pers1.Split();
            Nume = buff[0];
            Prenume = buff[1];
            NumarTelefon =Convert.ToInt32( buff[2]);
            AdresaEmail = buff[3];
            GRUP = (Grup)Convert.ToInt32(buff[4]);
            //Enum.TryParse(buff[5], out GRUP);

        }
        

       


        // Afisare date despre contact
        public string ConversieLaSir()
        {
            
           return string.Format("Persoana de contact are numele " + Nume + " " + Prenume + " cu numarul de telefon: " + NumarTelefon + "  adresa de e-mail: " + AdresaEmail + " din grupul " + GRUP);
          
        }
        public string nastere()
        {
            return "Data nasterii: " + DataNasterii;
            
        }
       public bool Compara(PersoaneContact c)
        {
            if(this.NumeleComplet.Length > c.NumeleComplet.Length)
            {
                return true;
            }
            return false;
                
        }
        
        public string ToString()
        {
            return Nume + " " + Prenume + " face parte din grupul: " + GRUP;
        }


    }
}
