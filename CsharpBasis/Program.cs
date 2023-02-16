// See https://aka.ms/new-console-template for more information
using CsharpBasis;

Console.WriteLine("Hello, World!");

int a;

FunksioneMeArray instanca = new FunksioneMeArray();


Console.WriteLine("Ju lutem jepni nje array me int :");

int n;

Console.WriteLine("Sa doni te jete madhesia e array?");
n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];


//array[0]
//..
//..
//array[4]


// vlera e elementit te array = array[i]
// poz i nje elementi ne array i


// kemi nje array me n elemente boshe

// Kemi mbushur arrayn me elemente
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Jepni elementin ne pozicioinin: " + i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}


// kemi nje array te mbushur me elemente



int shuma  = instanca.GjejShumenEArray(array);
int meIMadhi = instanca.GjejMeTeMadhin(array);
int shumaCift = instanca.GjejShumenCift(array);


Console.WriteLine("Shuma: " + shuma);
Console.WriteLine("Me i madhi: " + meIMadhi);
Console.WriteLine("Shuma cift: " + shumaCift);



List<int> listeMeInteger = new List<int>() { 10, 32, 43, -3, 4, -41, 4, 413, -11};
List<string> listeMeString = new List<string>() { "test", "abc", "developer" };


FunksioneMeLista instanceFunksioneMeLista = new FunksioneMeLista();

Console.WriteLine(instanceFunksioneMeLista.GjejMeTeMadhinNeListe(listeMeInteger));
instanceFunksioneMeLista.GjejShumenEListes(listeMeInteger);
instanceFunksioneMeLista.KtheElementetTek(listeMeInteger);
instanceFunksioneMeLista.GjejShumenCiftNeListe(listeMeInteger);
instanceFunksioneMeLista.GjejSasineEElementevePozitiv(listeMeInteger);
instanceFunksioneMeLista.KonvertoUppercase(listeMeString);








