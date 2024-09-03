 /* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

*/

/*
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");
*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

*/

// Binlerdeki her bir ürün miktarını içeren bir dizi başlatıyoruz
int[] inventory = { 200, 450, 700, 175, 250 };

// Toplam ürün miktarını saklamak için bir değişken başlatıyoruz
int totalItems = 0;

// Binlerin numarasını takip etmek için bir değişken başlatıyoruz
int binNumber = 2;

// inventory dizisindeki her bir ürün miktarını döngüyle işliyoruz
foreach (int items in inventory)
{
    // Mevcut binin ürün miktarını toplam ürüne ekliyoruz
    totalItems += items;
    
    // Bin numarasını bir artırıyoruz
    binNumber++;
    
    // Şu anki binin ürün miktarını ve güncel toplamı ekrana yazdırıyoruz
    Console.WriteLine($"Bin {binNumber} = {items} items (Running total: {totalItems})");
}

// Döngü tamamlandıktan sonra toplam ürün miktarını ekrana yazdırıyoruz
Console.WriteLine($"We have {totalItems} items in inventory.");
