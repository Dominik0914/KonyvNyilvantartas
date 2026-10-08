using KonyvNyilvantartas;

List<konyv> konyvek= new List<konyv>();
for (int i=0; i<3;i++)
{
    konyv ujkonyv = new konyv();
    Console.WriteLine($"{i+1}. könyv adatai:");
    Console.Write("\tCím: ");
    ujkonyv.Cim=Console.ReadLine();
    Console.Write("\tSzerző: ");
    ujkonyv.Szerzo = Console.ReadLine();
    Console.Write("\tOldalszám: ");
    ujkonyv.Oldalszam = int.Parse(Console.ReadLine());
    konyvek.Add(ujkonyv);
    Console.WriteLine("");
}

int osszoldal = 0;
Console.WriteLine("Rögzített könyvek listája:");
for (int i=0;i<konyvek.Count;i++)
{
    Console.WriteLine($"\t-{konyvek[i].Cim} ({konyvek[i].Szerzo}) - {konyvek[i].Oldalszam} oldal");
    osszoldal += konyvek[i].Oldalszam;
}
Console.WriteLine("");
Console.WriteLine($"Összesen elolvasandó: {osszoldal}");