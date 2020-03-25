using System;

namespace projeeeeee
{
	class Program
	{
        //yorum satırı

		void kitap_ekleme();
		void kitap_listeleme();
		void kitap_silme();
		int koltuk_islemleri();
		int standartsap(int a[100], int t, int w);

		struct ogrenci
		{
			char isim;
			char soyisim;
			int no;
		};


		int main()
		{
			int[] dizi = new int[100];
			int top = 0;
			int sec, abc, z, y = 0, x, kadir, abcd;
			int secim, tus;
			int i = 0, a, n = 1, k, l = 0;
			Console.WriteLine("*******Kutuphane Otomasyonuna Hos Geldiniz*******\n");
			Console.WriteLine("\n\n\n\n\n");
			Console.WriteLine("Lutfen Size Verilen Adimlari Dikkatlice Okuyarak Gerekli İslemleri Seciniz\n");


			Console.WriteLine("Robot Olmadiginizi Belirtmek Icin Lutfen 1e Basiniz...\n");

			abcd = Convert.ToInt32(Console.ReadLine());

			switch (abcd)
			{
				case 1:

					do
					{
						Console.WriteLine("MENU");
						Console.WriteLine("\n\n\n\n");
						Console.WriteLine("1-Koltuk Islemleri\n");
						/*printf("2-Kitap Listeleme\n");*/
						/*printf("3-Kitap Silme\n");*/
						Console.WriteLine("2-Kitap Islemleri\n");

						Console.WriteLine("\n");
						Console.WriteLine("Yapmak Istediginiz Secimi Giriniz\n");
						secim = Convert.ToInt32(Console.ReadLine());


						switch (secim)
						{
							case 1:



								Console.WriteLine("Koltuk Secimi  Icin 1 e\nCikis Islemi Icin 3 e\nIzin icin 7 ye basiniz.");
								sec = Convert.ToInt32(Console.ReadLine());
								if (sec == 1)
								{
									abc = 1;
									while (k != 2 && abc != 3)
									{



										Console.WriteLine("%d. Degeri girin=  ", i + 1);
										a = Convert.ToInt32(Console.ReadLine());
										while (a >= 100)

										{

											Console.WriteLine("Lutfen 1 ile 100 arasinda bir deger giriniz:\n");
											a = Convert.ToInt32(Console.ReadLine());
										}

										dizi[i] = a;
										Console.WriteLine("Koltuga yerlestiniz\n");



										Console.WriteLine("\n");




										Console.WriteLine("\n");



										standartsap(dizi, n, i);
										n++;
										y++;


										Console.WriteLine("Durdurmak Icin 2ye Basiniz\n");
										k = Convert.ToInt32(Console.ReadLine());

										Console.WriteLine("3 e Basarsan Silmeyegider\n");
										abc = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("\nAna Menuye Donmek Icin 0 a Basiniz.");
										kadir = Convert.ToInt32(Console.ReadLine());
										if (kadir == 0)
										{
											i++;
											break;

										}

										if (k != 2)
											i++;
										if (abc == 3)
										{

											for (i = 0; i < y; i++)
												Console.WriteLine("\nYerlesme Sirasi:%d Koltuk Numarasi: %d", i + 1, dizi[i]);
											Console.WriteLine("\n Yerlesme Siranizi Giriniz : ");

											z = Convert.ToInt32(Console.ReadLine()); z--;

											for (i = 0; i < y; i++)
											{

												if (i >= z)
												{
													dizi[i] = dizi[i + 1];
												}
											}

											for (i = 0; i < y - 1; i++)
											{

												if (dizi[i] != 0)
												{
													Console.WriteLine("\n Koltuk Numaralari:"); Console.WriteLine("%d", dizi[i]);
												}



											}
											y--;
											n--;

										}




									}
								}
								else if (sec == 3)
								{

									for (i = 0; i < n - 1; i++)
										Console.WriteLine("\nYerlesme Sirasi:%d Koltuk Numarasi: %d", i + 1, dizi[i]);

									Console.WriteLine("\nDizinin Kacinci Elemanini Cikartacaksin : ");
									z = Convert.ToInt32(Console.ReadLine()); z--;

									for (i = 0; i < n - 1; i++)
									{

										if (i >= z)
										{
											dizi[i] = dizi[i + 1];
										}
									}

									n--;
									y--;
									i--;

									for (i = 0; i < n - 1; i++)
									{


										Console.WriteLine("\n Dizi Elemanlari :"); Console.WriteLine("%d", dizi[i]);







									}


								}

								else if (sec == 7)
								{
									Console.WriteLine("\nizin verildi  .\n\n Uzun sure disarida kalmaniz durumunda koltugunuz bosa cikarilacaktir.\n");

								}


								break;
							case 2: koltuk_islemleri(); break;
							/*case 3: printf("adf") ; break;
							case 4: printf("sdfsf"); break;
							case 5: printf("adaf") ; break;
							case 6: printf("dsfsdf") ; break; */

							default: Console.WriteLine("Lutfen  1-6 arasi sayi giriniz \n\n"); break;

						}
						Console.WriteLine("\nCikmak Icin 8 Gir Menuye Donmek Icin Bir Sayi Giririniz\n\n");
						tus = Convert.ToInt32(Console.ReadLine());
					} while (tus != 8);

					break;
			}

			return 0;
		}


		int standartsap(int[100] a, int t, int w)
		{
			int p = 0;


			for (p = 0; p < t; p++)
			{
				Console.WriteLine("%d.Koltuk= %d\n", p + 1, a[p]);

			}

			int v, r;


			for (v = 0; v < t; v++)
			{
				for (r = 0; r < t; r++)
				{
					if (v != r + 1)
					{

						if (a[v] == a[r + 1] || a[0] == a[r + 1])
						{
							if (t != 4)
							{

								Console.WriteLine("Bu Koltuk Doludur Baska Koltuk Seciniz:");
								a[p - 1] = Convert.ToInt32(Console.ReadLine());
								w--;
								t = t - 2;
							}


						}

					}

				}
			}

			Console.WriteLine("\n\n");

			return a[100];


		}





	}
}
