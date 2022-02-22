using ClassMetotDemo;

int id = 0;
Musteri m1 = new Musteri();
m1.Ad = "Tuğba";
m1.Soyad = "Karaman";
m1.Yas = 23;
m1.Adres = "İstanbul";
id++;
m1.Id=id;

Musteri m2 = new Musteri();
m2.Ad = "Kübra";
m2.Soyad = "Karaman";
m2.Yas = 16;
m2.Adres = "İstanbul";
id++;
m2.Id = id;

Musteri m3 = new Musteri();
m3.Ad = "Nur";
m3.Soyad = "Karaman";
m3.Yas = 12;
m3.Adres = "İstanbul";
id++;
m3.Id = id;

Musteri m4 = new Musteri();
m4.Ad = "Ecrin Miray";
m4.Soyad = "Karaman";
m4.Yas = 5;
m4.Adres = "İstanbul";
id++;
m4.Id = id;

Musteri m5 = new Musteri();
m5.Ad = "Sofia Muazzez";
m5.Soyad = "Genç";
m5.Yas = 5;
m5.Adres = "İstanbul";
id++;
m5.Id = id;

Musteri m6 = new Musteri();
m6.Ad = "Esila";
m6.Soyad = "Karaman";
m6.Yas = 6;
m6.Adres = "İstanbul";
id++;
m6.Id = id;

Musteri m7 = new Musteri();
m7.Ad = "Seyithan";
m7.Soyad = "Genç";
m7.Yas =7;
m7.Adres = "İstanbul";
id++;
m7.Id = id;


MusteriManager musteriManager = new MusteriManager();
Console.WriteLine("Yeni Eklenen Müşteriler\n");
musteriManager.MusteriEkle(m1);
musteriManager.MusteriEkle(m2);
musteriManager.MusteriEkle(m3);
musteriManager.MusteriEkle(m4);
musteriManager.MusteriEkle(m5);
musteriManager.MusteriEkle(m6);
musteriManager.MusteriEkle(m7);
Console.WriteLine("\n-----------------------");


Musteri[] musteriList = new Musteri[] { m1, m2, m3, m4, m5, m6,m7 };
musteriManager.MusteriListele(musteriList);

