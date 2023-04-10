// See https://aka.ms/new-console-template for more information

using PudelkoLibrary;

Pudelko p = new Pudelko();
Console.Write($"{p.A},{p.B},{p.C}\n");
Pudelko p1 = new Pudelko(11.0, 2.0,unit: UnitOfMeasure.milimeter);
Console.Write($"Dane wyrazone w {p1.Unit}; {p1.A}; {p1.B}; {p1.C}");