﻿string kursAdi =".NET ile C# Programlama Dili";

var karakterSayisi = kursAdi.Length;
 Console.WriteLine("Kaç karakterden olusuyor? " + karakterSayisi);
 
 var kucukHarf = kursAdi.ToLower();
Console.WriteLine(kucukHarf);

var baslama = kursAdi.StartsWith(".");
Console.WriteLine(" . ile basliyor mu? " + baslama);

var iceriyor = kursAdi.Contains("C#");
Console.WriteLine("içeriyor mu? " + iceriyor);

var replace = kursAdi.Replace("Dili", "Dersleri");
Console.WriteLine(replace);

var konum = kursAdi.IndexOf("C#");
Console.WriteLine("C# bilgisi hangi konumda? " + konum);
