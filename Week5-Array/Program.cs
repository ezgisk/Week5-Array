

int[] array = new int[10];//10 adet tam sayı verisi alacak bir dizi tanımlayınız.

for (int i = 0; i < array.Length; i++)//Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
{
    array[i] = i;
}
foreach (int i in array)
{
    Console.WriteLine(i);
}
Console.Write("Lutfen Arraya eklemek icin bir sayi giriniz.Sayi:");// Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
int sayi = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[array.Length + 1];

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
}
newArray[newArray.Length-1] = sayi;

Array.Sort(newArray); // Diziyi küçükten büyüğe sırala
Array.Reverse(newArray); 

foreach (int i in newArray)
{
    Console.WriteLine(i);
}
Console.ReadLine();