Console.Clear();
Console.Write("saat: ");
var saat=Convert.ToDouble(Console.ReadLine());
var dastmozd=saat* 3.5;
var maliate=dastmozd* 5 /100;
var dastmozdkhles=dastmozd-maliate;
Console.WriteLine($"Dastmozd:{dastmozd} and Maliate{maliate} and dastmozdkhales{dastmozdkhles}");
