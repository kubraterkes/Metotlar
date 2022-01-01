// See https://aka.ms/new-console-template for more information
string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya elması";

string[] meyveler = new string[] { };
YoutubeMetotlar.YoutubeUrun
urun1 = new YoutubeMetotlar.YoutubeUrun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

YoutubeMetotlar.YoutubeUrun
urun2 = new YoutubeMetotlar.YoutubeUrun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

YoutubeMetotlar.YoutubeUrun[] urunler = new YoutubeMetotlar.YoutubeUrun[] { urun1, urun2 };

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("........... ");
}

Console.WriteLine(".............Metotlar..........");

var youtubeSepetManager = new YoutubeMetotlar.YoutubeSepetManager();
youtubeSepetManager.Ekle(urun1);
youtubeSepetManager.Ekle(urun2);

youtubeSepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
youtubeSepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
youtubeSepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu" ,12, 8);





