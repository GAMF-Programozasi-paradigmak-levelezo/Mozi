# Mozi

Készítsen egy C# konzol alkalmazást .NET 8.0 keretrendszerre, amely egy moziterem heti vetítési rendjét modellezi. Készítsen egy öt elemû tömböt Filmcímek névvel, ami az adott héten vetített filmek címeit tartalmazza.  

Készítsen egy kétdimenziós tömböt *VetítésiRend* névvel az egyes napokon vetített filmek sorszámainak tárolására (a tömb sorai a napokat azonosítják be, míg az oszlopai a vetítési sávokat) feltételezve, hogy filmvetítés csak páros órában kezdõdik, az elsõ filmet 10:00-tól vetítik, az utolsót 20:00-tól). Nincs minden nap minden sávban vetítés. A tömböt töltse fel véletlenszerûen kiválasztott film sorszámokkal illetve -1 értékekkel ott, ahol nincs vetítés.

Számolja ki, hogy hány vetítés van összesen, határozza meg, hogy melyik napon van a legkevesebb és  a legtöbb vetítés, valamint készítse el a transzponált mátrixot, amely megmutatja, hogy egy adott idõpontban (pl. 18:00) mely napokon van vetítés. 

Írja ki a program az eredeti és a transzponált vetítési rendet, valamint a statisztikákat a vetítések számáról.

Definiáljon egy struktúrát *Vetítés* névvel. A struktúra legyen képes tárolni egy film sorszámát, egy idõsáv sorszámát, és az adott vetítésre eladott jegyek számát. Hozzon létre egy fûrészfogas tömböt *Vetítések*, amiben a sorok a napokat azonosítják, és az adott sor elemeinek száma jelzi, hogy azon a napon hány vetítés  van. A tömb minden eleme *Vetítés* struktúra típusú legyen. 

Másolja át az adatokat a *VetítésiRend* tömbbõl a *Vetítések* tömbbe és adjon 5 és 100 közötti véletlen értéket minden vetítésnél az eladott jegyek számának.

Keresse ki, hogy melyik vetítés hozta a legkevesebb és melyik a legtöbb bevételt.  
