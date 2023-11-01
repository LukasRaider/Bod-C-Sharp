/*
 Bod (samostatné)

Pozor: nesplést s cvičením Point (a Shape), proto raději nechávám v češtině.

Procvičí se zde rozdíl mezi metodou instance a statickou. Dále zapouzdření. 
A getter, setter a Property Vytvořte třídu Bod s datovými složkami x,y a 
tedy i konstruktorem udávajícím souřadnici x a y typu double. Vytvořte tři metody, 
které různým způsobem budou vypočítávat vzdálenost bodu od počátku. Souřadnice x, y jsou 
vlastně odvěsnami pravoúhlého trojúhelníka, vzdálenost je přeponou. Řešíme Pythagorovou větou.
Metody budou výsledek zobrazovat pomocí WriteLine, jaký tedy bude jejich návratový typ? ??? Začneme 
nejprve nejjednodušší verzí, tedy metodou vzdXY(), která nevyužívá objekt bod, předává jako parametr 
číselné hodnoty x a y. Bude metoda statická? ??? Potom vytvoříme další metodu vzdBod(), té se však bude 
jako parametr předávat objekt typu bod. Bude metoda statická? ???. A jako poslední vytvoříme metodu bez 
parametru, tedy vzd(). Bude metoda statická? ???. Metodu Main umístěte do téže třídy. V metodě Main(): 
Nejprve vytvořte Bod b1se souřadnicemi 3,4 Potom zavolejte (pro jaký objekt či třídu?) metodu vzdXY(3,4). 
Pak zavolejte (pro jaký objekt či třídu?) metodu vzdBod(b1). Do třetice zavolejte (pro jaký objekt či třídu?) 
metodu vzd(). Některé z těchto tří metod se volají pro třídu, tedy před tečkou je Bod. Ověřte, 
zda je nutné Bod před tečku uvádět. ??? Tatáž otázka na nutnost uvést před tečku b1. ??? 
Ověřte, že ve všech třech případech dostanete stejnou vzdálenost. Změňte datové složky na privátní. 
Bude to mít nějaký vliv na program? ??? Která (které) metoda lze zavolat ještě před vytvořením první instance bodu (ověřte) ??? Vypište na konci metody Main nějakou privátní datovou složku přímo pomocí WriteLine. Jde to? ???

1. Pod třídu Bod do stejného souboru umístěte třídu TestBod, do které přesuňte metodu Main. Bylo nutno metodu Main po přesunu nějak upravit? ??? Projevilo se nyní nějak to, že jsou datové složky třídy Bod privátní? ??? Vypište nějakou privátní datovou složku přímo pomocí WriteLine. Jde to? ???

2. Místo getteru a setteru naprogramujte vlastnost (property). Zajistěte navíc, aby souřadnice nemohla být záporná (představme si, že se jedná o souřadnice bodu obrazovky), a to ani při přiřazení ani v konstruktoru.

3. V rámci tréningu vytvořte ještě instanční metodu vzdKBodu se dvěma číselnými parametry a její přetíženou variantu, kdy parametrem bude instance bodu. Odzkoušejte v metodě Main. Pro kontrolu: pokud by jeden z bodů měl souřadnice (0,0), pak by tato metoda dávala stejný výsledek jako metoda vzdBod. Pozn.: statickou metodu, kde by v závorce byly dva body, vytvářet nebudeme. V objektově orientovaném programování se statické metody používají jen zřídka. Jen když to jinak nejde. Tedy jen když pracují se statickými datovými složkami.
  */
class Program {
    public static void Main(string[] args)
    {
        Bod.TestBod.Mainx();
    }
}
