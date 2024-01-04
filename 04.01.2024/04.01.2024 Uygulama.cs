
#region// girilen iki sayıdan buyuk olanı bulan program
/*
Console.WriteLine("İki tam sayı giriniz");

int sayi1 = int.Parse(Console.ReadLine());
int sayi2 = int.Parse(Console.ReadLine());

    if (sayi1 > sayi2)
        Console.WriteLine(sayi1 + " büyüktür");

    else if (sayi1 < sayi2)
        Console.WriteLine(sayi2 + " büyüktür");

    else
        Console.WriteLine(sayi1 + " ve " + sayi2 + " eşittir");
*/
#endregion

#region//girilen sayının tek mi çift mi olduğunu bulan console uygulaması
/*
Console.WriteLine("BIR TAM SAYI GIRINIZ");

int sayi = int.Parse(Console.ReadLine());

if (sayi % 2 == 0)
    Console.WriteLine(sayi + " çifttir");
else
    Console.WriteLine(sayi + " tektir");
*/
#endregion

#region//bir mağazadan alınan ürünlerde 100 TL ve üzerinde kargo bedava, 100 TL altında 20 lira kargo ücreti alınmaktadır. Kullanıcıdan alınan toplam ödemeye göre ödenmesi gereken tutarı gösteren console uygulaması
/*
Console.WriteLine("Ürün Tutarını Giriniz");

int tutar = int.Parse(Console.ReadLine());

if (tutar >= 100)
    Console.WriteLine("ödemeniz gereken tutar " + tutar);
else if (tutar < 100)
{
    tutar += 20;
    Console.WriteLine("ödemeniz gereken tutar " + tutar);
}

*/
#endregion
#region// kullanıcı şifreyi doğru girdiğinde " giriş başarılı" , yanlış girdiğinde " girdiğiniz şifre hatalı" yazdıran console uygulaması
/*
Console.WriteLine("Şifrenizi giriniz");

string sifre = "1234";

string parola = Console.ReadLine();

if (parola != sifre)
    Console.WriteLine("Girdiğiniz şifre hatalı");
else
    Console.WriteLine("Giriş başarılı");
*/
#endregion
#region//klavyeden girilen su sıcaklığına göre katı, sıvı yada gaz yazdıran console uygulaması
/*
Console.WriteLine("Suyun Sıcaklık değerini celcius cinsinden giriniz");

int sıcaklık = int.Parse(Console.ReadLine());

if (sıcaklık > 100)
    Console.WriteLine("su gaz halindedir");
else if (sıcaklık < 0)
    Console.WriteLine("su katı haldedir");
else
    Console.WriteLine("su sıvı haldedir");

*/
#endregion

#region//girilen sayının hem 3 e hem 2 ye bölünebiliyor olduğunu yazan program
/*
Console.WriteLine("Bir Sayı Giriniz");

var sayi = int.Parse(Console.ReadLine());

if (sayi % 2 == 0 && sayi % 3 == 0)
    Console.WriteLine("Girilen sayı 2 ve 3 e bölünebilirdir");
else
    Console.WriteLine("Girilen sayı 2 ve 3 e bölünemez");
*/
#endregion

#region
// Girilen sayı 3'e bölünebiliyorsa "3 ün katı", Girilen sayı 5'e bölünebiliyorsa "5'in Katı", Girilen Sayı Hem 3'e Hem'5 bölünebiliyorsa "Hem 3 ün Hem 5 in Katı", Girilen sayı 3 e ve 5 e bölünemiyorsa "3 e ve 5 e bölünemyior" çıktısı veren programı yazınız.
/*
Console.WriteLine("Bir tam sayı giriniz");

var sayi = int.Parse(Console.ReadLine());

if (sayi % 3 == 0 && sayi % 5 == 0)

   Console.WriteLine("Hem 3 ün hem 5 in katı");
        
else if    
    (sayi % 3 == 0)
   Console.WriteLine("girilen sayı 3 ün katı");
        
else if 
    (sayi % 5 == 0)
   Console.WriteLine("girilen sayı 5 in katı");

else
    Console.WriteLine("3 ve 5 e bölünemiyor");
*/

#endregion
#region

// Girilen sayı 3 e ve 5 e bölünemiyorsa "3'e de 5'e de bölünemiyor" çıktısı veren programı yazınız.

Console.WriteLine("Bir tam sayi giriniz");

int sayi = int.Parse(Console.ReadLine());

if (sayi % 3 != 0 && sayi % 5 != 0)
    Console.WriteLine("Girilen sayi 3'e de 5'e de bolunemiyor");
else
    Console.WriteLine("Girilen sayı 3'e veya 5'e bölünebilir");

#endregion