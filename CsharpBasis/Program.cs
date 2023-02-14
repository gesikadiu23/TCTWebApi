// See https://aka.ms/new-console-template for more information
using CsharpBasis;

Console.WriteLine("Hello, World!");

int a;

FunksioneMeArrayDheLista instanca = new FunksioneMeArrayDheLista();


Console.WriteLine("Ju lutem jepni nje array me int :");

int n;

Console.WriteLine("Sa doni te jete madhesia e array?");
n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];



// Kemi mbushur arrayn me elemente
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Jepni elementin ne pozicioinin: " + i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}




int shuma  = instanca.GjejShumenEArray(array);
int meIMadhi = instanca.GjejMeTeMadhin(array);
int shumaCift = instanca.GjejShumenCift(array);


Console.WriteLine("Shuma: " + shuma);
Console.WriteLine("Me i madhi: " + meIMadhi);
Console.WriteLine("Shuma cift: " + shumaCift);



