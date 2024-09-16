namespace Task_Calcolatirce_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciao sono una calcolatrice inserisci due numeri e scegli la tua operazione premi Q per uscire dal programma");
            bool Continuainfinito = true;
            while (Continuainfinito)
            {

                Console.WriteLine("Inserisci il primo numero:");
                int numero1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Inserisci il secondo numero:");
                int numero2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Scegli un'operazione (+, -, *, /):");
                char operazione = Convert.ToChar(Console.ReadLine());


                int risultato = 0;



                switch (operazione)
                {
                    case '+':
                        risultato = numero1 + numero2;

                        break;
                    case '-':
                        risultato = numero1 - numero2;
                        break;
                    case '*':
                        risultato = numero1 * numero2;
                        break;
                    case '/':
                        if (numero2 != 0)
                        {
                            risultato = numero1 / numero2;
                        }
                        else
                        {
                            Console.WriteLine("Errore: Divisione per zero non permessa.");
                            return;
                        }
                        break;
                        case 'Q':
                        Continuainfinito = false;
                        Console.WriteLine("Programma Terminato ");
                        break;

                    default:
                        Console.WriteLine("Operazione non valida.");

                        return; // qui esci

                }


                Console.WriteLine($"Il risultato dell'operazione è: {risultato}");
            }
        }
    }
}
