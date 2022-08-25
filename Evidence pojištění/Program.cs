using Evidence_pojištění;

Evidence evidence = new Evidence();
char volba = '0';
while (volba != '5')
{
    evidence.VypisUvodniObrazovku();
    Console.WriteLine();
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojistného");
    Console.WriteLine("2 - Vypsat všechny pojistné");
    Console.WriteLine("3 - Vyhledat pojistného");
    Console.WriteLine("4 - Vymazat pojistného");
    Console.WriteLine("5 - Konec");
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (volba)
    {
        case '1':
            evidence.PridejZaznam();
            break;
        case '2':
            evidence.VypisZaznamy();
            break;
        case '3':
            evidence.VyhledejZaznamy();
            break;
        case '4':
            evidence.VymazZaznamy();
            break;
        case '5':
            Console.WriteLine("Libovolnou klávesou ukončíte program...");
            break;
        default:
            Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
            break;
    }
    Console.ReadKey();
}
