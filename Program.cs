


int sayi;
Console.Write("Lütfen bir sayı girin: ");
sayi = Convert.ToInt32(Console.ReadLine());
int sayac = 0;

while ( sayac <= sayi)
{
    Console.WriteLine("Ben bir Patikalıyım ");
   
    sayac++;
}




int second;
int number = 0;
Console.Write("Lütfen bir sayı girin: ");
second = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patikalıyım ");
    number++;

} while (number <= second);




/* While de kontrolm döngünün başında yapıldı */

/* Do While da ise kontrol döngünün sonunda sağlanıyor.Koşul yanlışsa bile do kısmı bir kere herzaman çalışıyor.
 Mesela kullanıcıdan aldığımız Lütfen bir sayı giriniz değerini int e dönüştürmesek ve kendimiz atasak.
Do kısmı her türlü bir kere çalışır ve ekrana ben bir patikalıyım yazar.Sonrasında while koşulu false olur ve döngü biter.  
 */

