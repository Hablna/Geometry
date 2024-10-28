////ergr
////variable
//using System.Diagnostics;

//int a = 3;
////interference de type
//var d = new InvalidCastException();

////type anonyme
//var voiture = new { marque = "Renault", modele = "4X4" };

////type nullable
//int? f = null;
//string c = null;

////tableau
//int[] tab = new int[5];
//tab[0] = 1;
////syntaxe rapide 
//int[] tab2 = {1,2,3,4,5};

////tab multidimensionnel
//int[,] tab3 = new int[2, 3];

////liste
//List<int> list = new List<int>();
//list.Add(5);

////syntaxe rapide d'affectation
//List<int> liste2 = new List<int> { 1, 2, 3, 4, 5 };

using rappel_syntaxe;

var maphrase = "j'apprends le c#";
Console.WriteLine(maphrase.MajAuDebDesMots());

//LINQ
//Language Integrated Query
// c'est un ensemble de methodes d'extension sur IEnumerable<T>
var listeDentier = new List<int>() { 1, 6, 9, -2, -1, -7 };
//on veut les entiers positifs
//var lesPositifs = new List<int>();
var lespositifs = listeDentier.Where(x => x > 0).ToList();

var uneAutreListe = new List<int>() { 2, -3, -2}    ;