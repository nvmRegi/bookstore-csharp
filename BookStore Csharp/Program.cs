//Dichiarazioni variabili
string titolo = "Clean Code";
string autore = "Robert C. Martin";
long isbn = 9780132350884;
int nPagine = 431;
float pesoLibro = 0.660f;
float larghezza = 17.91f;
float lunghezza = 23.5f;
float profondita = 2.54f;
float valutazionMedia = 4.7f;
int nValutazioni = 3308;
string vKindle = "Si";
string vFlessibile = "Si";

//Impaginazione
Console.WriteLine("——— IL LIBRO DI OGGI: " + titolo + " di " + autore +"——————-");
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