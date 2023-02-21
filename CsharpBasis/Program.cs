// See https://aka.ms/new-console-template for more information
using CsharpBasis.Helpers;
using CsharpBasis.Models;

//Console.WriteLine("Hello, World!");

//int a;

//FunksioneMeArray instanca = new FunksioneMeArray();


//Console.WriteLine("Ju lutem jepni nje array me int :");

//int n;

//Console.WriteLine("Sa doni te jete madhesia e array?");
//n = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[n];


////array[0]
////..
////..
////array[4]


//// vlera e elementit te array = array[i]
//// poz i nje elementi ne array i


//// kemi nje array me n elemente boshe

//// Kemi mbushur arrayn me elemente
//for(int i = 0; i < n; i++)
//{
//    Console.WriteLine("Jepni elementin ne pozicioinin: " + i);
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}


//// kemi nje array te mbushur me elemente



//int shuma  = instanca.GjejShumenEArray(array);
//int meIMadhi = instanca.GjejMeTeMadhin(array);
//int shumaCift = instanca.GjejShumenCift(array);


//Console.WriteLine("Shuma: " + shuma);
//Console.WriteLine("Me i madhi: " + meIMadhi);
//Console.WriteLine("Shuma cift: " + shumaCift);



//List<int> listeMeInteger = new List<int>() { 10, 32, 43, -3, 4, -41, 4, 413, -11};
//List<int> abc = new List<int>() { 10, 32, 43, -3, 4, -41, 4, 413, -11 };
//List<string> listeMeString = new List<string>() { "test", "abc", "developer" };


//FunksioneMeLista instanceFunksioneMeLista = new FunksioneMeLista();

//int a1 = instanceFunksioneMeLista.GjejMeTeMadhinNeListe(listeMeInteger);
//int a2 = instanceFunksioneMeLista.GjejShumenEListes(listeMeInteger);
//int a3 = instanceFunksioneMeLista.GjejShumenCiftNeListe(listeMeInteger);
//int a4 = instanceFunksioneMeLista.GjejSasineEElementevePozitiv(listeMeInteger);

//Console.WriteLine("Me I madhi ne liste: " + a1);
//Console.WriteLine("Shuma e elemnteve te listes: " + a2);
//Console.WriteLine("Shuma e elementeve cift te listes: " + a3);
//Console.WriteLine("sasia e elemtneve pozitiv: " + a4);


//List<int> elementetTek = instanceFunksioneMeLista.KtheElementetTek(listeMeInteger);

//foreach(int el in elementetTek)
//{
//    Console.WriteLine(el);
//}

//List<string> fjaletUppercase = instanceFunksioneMeLista.KonvertoUppercase(listeMeString);


//foreach(string el in fjaletUppercase)
//{
//    Console.WriteLine(el);
//}



Person p = new Person();

p.Age = 10;
p.Name = "John";
p.Surname = "Doe";
p.Address = "Rr Durresit";
p.Phone = "123456789";


Person p1 = new Person();
p1.Age = 20;
p1.Name = "Johna";
p1.Surname = "Doea";
p1.Address = "Rr Durresita";
p1.Phone = "123456789a";

Person p2 = new Person();
p2.Age = 30;
p2.Name = "Johnb";
p2.Surname = "Doeb";
p2.Address = "Rr Durresitb";
p2.Phone = "123456789b";


PersonHelper helperMethods = new PersonHelper();

List<Person> listOfPersons = new List<Person>();
listOfPersons.Add(p);
listOfPersons.Add(p2);
listOfPersons.Add(p1);

helperMethods.KthePersoninMeTeMadh(listOfPersons);
///person

helperMethods.GjejMoshenMesatare(listOfPersons);
helperMethods.RenditPersonatSipasMoshes(listOfPersons); 