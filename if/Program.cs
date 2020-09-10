using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt namn");
            string name = Console.ReadLine();

            Console.WriteLine("Ditt namn är satt som " + name + " tryck ENTER för att fortsätta");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Du går ut ur ditt hus på väg till skolan klockan 07:00, väljer du att ta SJ eller SL? (SJ/SL)");
            string ans1 = Console.ReadLine();
            Console.ReadLine();

            if (ans1 == "SJ")
            {
                Console.Clear();
                Console.WriteLine("du kommer 4 timmar sent eftersom SJ suger. Försök igen.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ans1 == "SL")
            {
                Console.Clear();
                Console.WriteLine("Du valde rätt! SL fungerar till skillnad från SJ. Du är framme i centralen 8:10 men kommer iallafall fram.");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du är en idiot! Skriv något vettigt!");
                Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Efter att du nått centralen måste du dra till skolan, går du till annexet eller Craaford? (Annexet/Craaford)");
            string ans2 = Console.ReadLine();
            Console.ReadLine();
            if (ans2 == "Craaford")
            {
                Console.Clear();
                Console.WriteLine("Du har koll på schemat vilket sparar dig tid.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ans2 == "Annexet")
            {
                Console.Clear();
                Console.WriteLine("Idiot! Det är måndag! Första lektionen är programmering på Craaford, du försenas med 5 minuter. Klockan är nu 8:20");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du är en idiot! Skriv något vettigt!");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("När du når Norra Bantorget går en alkis mot dig och börjar prata, stannar du för att försöka förstå vad han säger? (Ja/Nej)");
            string ans3 = Console.ReadLine();
            Console.ReadLine();
            if (ans3 == "Ja")
            {
                Console.Clear();
                Console.WriteLine("Du förlorar tid eftersom du stannar, du kommer ytterligare 2 minuter sent.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ans3 == "Nej")
            {
                Console.Clear();
                Console.WriteLine("Du inser att det finns bättre saker att göra en att engagera dig i filosofiska diskussioner med alkisar och sparar tid.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du är en idiot! Skriv något vettigt!");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("När du kommer till ingången måste du skriva in koden till entrén, vad är den?");
            string ans4 = Console.ReadLine();
            Console.ReadLine();
            if (ans4 == "1577#")
            {
                Console.Clear();
                Console.WriteLine("Du kom ihåg koden och tar dig till klassrummet.");
                Console.ReadLine();
                Console.Clear();
            }
            else if (ans4 == "1577")
            {
                Console.Clear();
                Console.WriteLine("Du kom (typ) ihåg koden och tar dig till klassrummet.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du förlorar tid eftersom du glömde koden");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("På vägen till skolan valde du att åka med " + ans1 + ". Efter du anlände till centralen gick du mot " + ans2 + ". Du stötte sedan på en alkis i Norra Bantorget och när han ville ställa frågor sa du " + ans3 + ". När du väl var framme och skulle skriv in koden skrev du " + ans4 + ".");
            Console.ReadLine();
        }
    }
}
