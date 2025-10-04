/*
 Készítsen egy C# konzol alkalmazást .NET 8.0 keretrendszerre, amely egy moziterem heti vetítési rendjét modellezi. Készítsen egy öt elemű tömböt Filmcímek névvel, ami az adott héten vetített filmek címeit tartalmazza.  

Készítsen egy kétdimenziós tömböt VetítésiRend névvel az egyes napokon vetített filmek sorszámainak tárolására (a tömb sorai a napokat azonosítják be, míg az oszlopai a vetítési sávokat) feltételezve, hogy filmvetítés csak páros órában kezdődik, az első filmet 10:00-tól vetítik, az utolsót 20:00-tól). Nincs minden nap minden sávban vetítés. A tömböt töltse fel véletlenszerűen kiválasztott film sorszámokkal illetve -1 értékekkel ott, ahol nincs vetítés.

Számolja ki, hogy hány vetítés van összesen, határozza meg, hogy melyik napon van a legkevesebb és  a legtöbb vetítés, valamint készítse el a transzponált mátrixot, amely megmutatja, hogy egy adott időpontban (pl. 18:00) mely napokon van vetítés. 

Írja ki a program az eredeti és a transzponált vetítési rendet, valamint a statisztikákat a vetítések számáról.

Definiáljon egy struktúrát Vetítés névvel. A struktúra legyen képes tárolni egy film sorszámát, egy idősáv sorszámát, és az adott vetítésre eladott jegyek számát. Hozzon létre egy fűrészfogas tömböt Vetítések, amiben a sorok a napokat azonosítják, és az adott sor elemeinek száma jelzi, hogy azon a napon hány vetítés  van. A tömb minden eleme Vetítés struktúra típusú legyen. 

Másolja át az adatokat a VetítésiRend tömbből a Vetítések tömbbe és adjon 5 és 100 közötti véletlen értéket minden vetítésnél az eladott jegyek számának.

Keresse ki, hogy melyik vetítés hozta a legkevesebb és melyik a legtöbb bevételt.  
 */


namespace Mozi
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Moziterem modellezése");

			// Az adott héten vetített filmek címei (5 film)
			string[] filmek = { "Inception", "The Matrix", "Interstellar", "The Dark Knight", "Star Wars" };

			// A vetítési idősávok, csak páros órákban (10:00-tól 20:00-ig)
			int[] IdőSávok = { 10, 12, 14, 16, 18, 20 };

			// A hét napjai
			string[] Napok = { "Hétfő", "Kedd", "Szerda", "Csütörtök", "Péntek", "Szombat", "Vasárnap" };

			// Kétdimenziós tömb a vetítési rendhez: 7 nap × 6 idősáv
			// Minden elem egy film sorszámát vagy -1-et tartalmaz (ha nincs vetítés)
			int[,] VetítésiRend = new int[7, 6];

			// Véletlenszám-generátor példányosítása
			Random rnd = new Random();

			// A vetítési rend véletlenszerű feltöltése
			for (int i = 0; i < 7; i++) // Napokon iterálunk
			{
				// Kiírjuk az aktuális nap nevét, balra igazítva 10 karakteren
				Console.Write($"{Napok[i],-10} ");

				for (int j = 0; j < 6; j++) // Idősávokon iterálunk
				{
					// Véletlenszerűen kiválasztunk egy film sorszámot (1–6), vagy -1-et (nincs vetítés)
					VetítésiRend[i, j] = rnd.Next(-1, 7);

					// Ha -1, akkor üresen jelenítjük meg, különben kiírjuk a számot
					string s = VetítésiRend[i, j] == -1 ? " " : VetítésiRend[i, j].ToString();

					// Kiírjuk az adott idősáv értékét
					Console.Write($"{s} ");
				}

				// Új sor a következő naphoz
				Console.WriteLine();
			}

			// Tömb a napi vetítések számának tárolására
			int[] NapiVetítések = { 0, 0, 0, 0, 0, 0, 0 };

			// Összes vetítés számláló
			int ÖsszesVetítés = 0;

			// Végigmegyünk a vetítési rend tömbön, és megszámoljuk a vetítéseket
			for (int i = 0; i < 7; i++) // Napokon
				for (int j = 0; j < 6; j++) // Idősávokon
					if (VetítésiRend[i, j] != -1) // Ha van vetítés
					{
						NapiVetítések[i]++; // Napi számláló növelése
						ÖsszesVetítés++;    // Összes számláló növelése
					}

			// Kiírjuk az összes vetítés számát
			Console.WriteLine($"Összes vetítés: {ÖsszesVetítés}");

			// Kiírjuk a napi vetítések számát
			for (int i = 0; i < 7; i++)
				Console.WriteLine($"{Napok[i],-10}: {NapiVetítések[i]} vetítés");

			// A programot a második gyakorlaton fogjuk befejezni.
		}
	}
}
