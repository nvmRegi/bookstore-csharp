Console.WriteLine("BENVENUTI IN QUESTO PROGRAMMA!");
Console.WriteLine("\nAttività del giorno: \n0 - Leggere il libro del giorno.\n1 - Inserire un nuovo libro.");

int risposta = Convert.ToInt32(Console.ReadLine());

Console.Clear();
//Dichiarazioni variabili
string titolo;
string autore;
double isbn;
int nPagine;
double pesoLibro;
double larghezza;
double lunghezza;
double profondita;
double valutazionMedia;
int nValutazioni;
string vKindle;
string vFlessibile;


switch (risposta)
{
    case 0:

        titolo = "Clean Code";
        autore = "Robert C. Martin";
        isbn = 9780132350884;
        nPagine = 431;
        pesoLibro = 0.660;
        larghezza = 17.91;
        lunghezza = 23.5;
        profondita = 2.54;
        valutazionMedia = 4.7;
        nValutazioni = 3308;
        vKindle = "Si";
        vFlessibile = "Si";

        Console.WriteLine("——— IL LIBRO DI OGGI: " + titolo + " di " + autore + "——————-");
        Console.WriteLine("Informazioni generetiche: ");
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Numero delle pagine: " + nPagine + " pagine");
        Console.WriteLine("Peso del libro: " + pesoLibro + " kg");
        Console.WriteLine("Dimenioni del libro: " + larghezza + "cm x " + lunghezza + "cm x " + profondita + "cm");

        Console.WriteLine("Inforzioni Amazon: ");
        Console.WriteLine("Numero di recensioni: " + nValutazioni + " recensioni");
        Console.WriteLine("Valutazione media: " + valutazionMedia + " stelline");
        Console.WriteLine("Kindle disponibile: " + vKindle);
        Console.WriteLine("Copertina flessibile disponibile: " + vFlessibile);
        break;
    case 1:
        Console.WriteLine("Inserisci il titolo: ");
        titolo = Console.ReadLine();
        Console.WriteLine("Inserisci l'autore: ");
        autore = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Inserisci l'ISBN: ");
        isbn = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il numero delle pagine: ");
        nPagine = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci Inserisci il peso del libro: ");
        pesoLibro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la larghezza del libro: ");
        larghezza = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la lunghezza del libro: ");
        lunghezza = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci lo spessore del libro: ");
        profondita = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci la valutazione media del libro: ");
        valutazionMedia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il numero di recensioni del libro: ");
        nValutazioni = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("E' disponibile la versione Kindle?" );
        vKindle = Console.ReadLine();
        Console.WriteLine("E' disponibile la versione flessibile?" );
        vFlessibile = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("——— IL LIBRO DI OGGI: " + titolo + " di " + autore + "——————-");
        Console.WriteLine("Informazioni generetiche: ");
        Console.WriteLine("ISBN: " + isbn);
        Console.WriteLine("Numero delle pagine: " + nPagine + " pagine");
        Console.WriteLine("Peso del libro: " + pesoLibro + " kg");
        Console.WriteLine("Dimenioni del libro: " + larghezza + "cm x " + lunghezza + "cm x " + profondita + "cm");

        Console.WriteLine("Inforzioni Amazon: ");
        Console.WriteLine("Numero di recensioni: " + nValutazioni + " recensioni");
        Console.WriteLine("Valutazione media: " + valutazionMedia + " stelline");
        Console.WriteLine("Kindle disponibile: " + vKindle);
        Console.WriteLine("Copertina flessibile disponibile: " + vFlessibile);
        break;
    default:
        Console.WriteLine("Opzione non valida.");
        break;
}