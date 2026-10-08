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
}
