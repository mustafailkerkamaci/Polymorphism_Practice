//HER CLASSTAN BIRER ORNEK NESNE GOSTERIMI  

using Polymorphism_Practice.Models;

Dikdortgen dikdortgen = new Dikdortgen(5, 10);
Kare kare = new Kare(8);
DikUcgen dikUcgen = new DikUcgen(6, 8);


Console.WriteLine($"Karenin Alani: {kare.AlanHesapla()}");
Console.WriteLine($"Dikdortgenin Alani : {dikdortgen.AlanHesapla()}");
Console.WriteLine($"Dikucgenin Alani : {dikUcgen.AlanHesapla()}");