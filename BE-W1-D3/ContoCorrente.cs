using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_W1_D3
{
    internal class ContoCorrente
    {
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public bool ContoAperto { get; set; } = false;

        
        public void MenuStart() {
            

            if (ContoAperto == false)
            {
                Console.WriteLine("1: Apri un nuovo conto corrente");
                string scelta = Console.ReadLine();

                if (scelta == "1")
                {                
                    AprireConto();
                }

            }
            else
            {
                Console.WriteLine("1:Esegui Versamento");
                
                Console.WriteLine("2: Esegui Prelievo");
                string scelta = Console.ReadLine();

                if (scelta == "1")
                {
                    Versamento();
                }
                else{

                    Prelievo();

                }
            }
         
        }


        public void AprireConto () {

           
                Console.WriteLine("Cognome Proprietario: ");
                Cognome = Console.ReadLine();

                Console.WriteLine("Nome Proprietario: ");
                Nome = Console.ReadLine();

                Saldo = 0;
                ContoAperto = true;
                Console.WriteLine($"Conto corrente nr.00002546 intestato a: {Cognome} {Nome} creato");
                MenuStart();

            

        }


        public void Versamento()
        {
            Console.WriteLine("digita la cifra da Versare");
            double CifraVersata = int.Parse(Console.ReadLine());
            Saldo += CifraVersata;
            Console.WriteLine($"Hai versato {CifraVersata}$, il tuo nuovo saldo è: {Saldo}$");
            MenuStart();
        }

        public void Prelievo()
        {
            Console.WriteLine("digita la cifra da Prelevare");
            double CifraPrelevata = int.Parse(Console.ReadLine());
            if (CifraPrelevata <= Saldo)
            {
                Saldo = Saldo - CifraPrelevata;
                Console.WriteLine($"Hai prelevato {CifraPrelevata}$, il tuo nuovo saldo è: {Saldo}$");
                MenuStart();
            }
            else {
                Console.WriteLine($"Non hai {CifraPrelevata}$ nel tuo conto, ritenta con un altro importo");
                Prelievo();
            }           
            
        }

    }
}
