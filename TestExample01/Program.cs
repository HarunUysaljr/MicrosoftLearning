Random rnd = new Random();

int daysUntilExpiration = rnd.Next(12);
int discountPercentage = 0;

// ##Bu kodun 0 - 11 değerine sahip rastgele bir sayı oluşturacağını göreceksiniz. Rastgele sayı adlı daysUntilExpirationbir 
//tamsayı değişkenine atanır. olarak başlatılan 0adlı discountPercentage başka bir tamsayı değişkeniniz var.

if(daysUntilExpiration == 0 ){
    System.Console.WriteLine($"{daysUntilExpiration}Aboneliğinizin süresi dolmuştur");
}
else if(daysUntilExpiration == 1){
    System.Console.WriteLine("Aboneliğiniz süresi 1 gün sonra doluyor paketi yenileyin.");
    discountPercentage = 10;
}
else if(daysUntilExpiration == 5){
    System.Console.WriteLine($"{daysUntilExpiration} aboneliğiniz süresi dolacak şimdi yenile");
    discountPercentage = 25;
}


else if(daysUntilExpiration <= 10){
    System.Console.WriteLine($"{daysUntilExpiration} aboneliğiniz süresi dolacak şimdi yenile");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}