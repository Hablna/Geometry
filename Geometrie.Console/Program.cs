
using Geometrie.BLL;

var p1 = new Point(4, 5);
var p2 = new Point(5, 8);

Console.WriteLine("cool");
var MonTriangle = new Triangle(p1, p2, new Point(6, 7));

//for (int i = 0; i < poly.Count; i++)
//{
//    Console.WriteLine(poly[i].X+" " + poly[i].Y);
//}
Console.WriteLine(MonTriangle.CalculerSurface());