string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("C"))  //“B” harfiyle başlayıp başlamadığını belirlemek için String.StartsWith() yöntemini kullanın
    {
        Console.WriteLine(orderID);
    }
}
