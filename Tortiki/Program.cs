using static Tortiki.Menu;

namespace tortiki
{

    internal class Program
    {
        static public ConsoleKeyInfo clavisha;
        static public string tort;
        static public int cena;
        static public int position = 3;

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в магазин тортов \"Шоколадный Заяц\"!");
            Console.WriteLine("Соберите свой торт: \n");
            Console.Write("  1)Форма торта  \n  2)Размер торта  \n  3)Вкус \n  4)Количество коржей  \n  5)Глазурь  \n  6)Декор  \n  7)Конец заказа \n");
            Console.Write("\n Цена:" + cena + "\n  Ваш торт:" + tort);
            Strelki();
            Perecl();
        }
        static void Strelki()
        {
            position = 3;
            do
            {
                string del = new string(' ', 2);
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                }
                Console.Write("\r" + del);
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (clavisha.Key != ConsoleKey.Enter);
        }
        static void Perecl()
        {
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Esc\nВыберите пункт из меню\n");
            if (clavisha.Key == ConsoleKey.Enter)
            {
                switch (position)
                {
                    case 3:
                        FormaTorta formatorta = new FormaTorta();
                        Console.WriteLine("  " + formatorta.pryamougolnik);
                        Console.WriteLine("  " + formatorta.serdce);
                        Console.WriteLine("  " + formatorta.ponchik);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + formatorta.cena_pryamougalnuk;
                                    tort = tort + formatorta.pryamougolnik;
                                    break;
                                case 4:
                                    cena = cena + formatorta.cena_serdce;
                                    tort = tort + formatorta.serdce;
                                    break;
                                case 5:
                                    cena = cena + formatorta.cena_ponchik;
                                    tort = tort + formatorta.ponchik;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 4:
                        RazmerTorta razmertorta = new RazmerTorta();
                        Console.WriteLine("  " + "Большой - "+ razmertorta.cena_bolshoy);
                        Console.WriteLine("  " + "Средний - " + razmertorta.cena_sredniy);
                        Console.WriteLine("  " + "Маленький - " + razmertorta.cena_malenkiy);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + razmertorta.cena_bolshoy;
                                    tort = tort + razmertorta.bolshoy;
                                    break;
                                case 4:
                                    cena = cena + razmertorta.cena_sredniy;
                                    tort = tort + razmertorta.sredniy;
                                    break;
                                case 5:
                                    cena = cena + razmertorta.cena_malenkiy;
                                    tort = tort + razmertorta.malenkiy;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 5:
                        VkusTorta vkustorta = new VkusTorta();
                        Console.WriteLine("  " + "Клюквенный - " + vkustorta.cena_klukva);
                        Console.WriteLine("  " + "Банановый - " + vkustorta.cena_chocolate);
                        Console.WriteLine("  " + "Шоколадный - " + vkustorta.cena_bananoviy);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + vkustorta.cena_klukva;
                                    tort = tort + vkustorta.klukva;
                                    break;
                                case 4:
                                    cena = cena + vkustorta.cena_chocolate;
                                    tort = tort + vkustorta.chocolate;
                                    break;
                                case 5:
                                    cena = cena + vkustorta.cena_bananoviy;
                                    tort = tort + vkustorta.bananoviy;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 6:
                        position = 3;
                        KolichestvoKorshey kolichestvokorshey = new KolichestvoKorshey();
                        Console.WriteLine("  " + "1 корж - " + kolichestvokorshey.cena_odinkorsh);
                        Console.WriteLine("  " + "2 коржа - " + kolichestvokorshey.cena_dvakorsha);
                        Console.WriteLine("  " + "3 коржа - " + kolichestvokorshey.cena_trikorsha);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + kolichestvokorshey.cena_odinkorsh;
                                    tort = tort + kolichestvokorshey.odinkorsh;
                                    break;
                                case 4:
                                    cena = cena + kolichestvokorshey.cena_dvakorsha;
                                    tort = tort + kolichestvokorshey.dvakorsha;
                                    break;
                                case 5:
                                    cena = cena + kolichestvokorshey.cena_trikorsha;
                                    tort = tort + kolichestvokorshey.trikorsha;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 7:
                        position = 3;
                        GlazurTorta glazurtorta = new GlazurTorta();
                        Console.WriteLine("  " + "Ванильная - " + glazurtorta.cena_vanil);
                        Console.WriteLine("  " + "Посыпка - " + glazurtorta.cena_posipka);
                        Console.WriteLine("  " + "Шоколадная стружка - " + glazurtorta.cena_chokoladnayastruska);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + glazurtorta.cena_vanil;
                                    tort = tort + glazurtorta.vanil;
                                    break;
                                case 4:
                                    cena = cena + glazurtorta.cena_posipka;
                                    tort = tort + glazurtorta.posipka;
                                    break;
                                case 5:
                                    cena = cena + glazurtorta.cena_chokoladnayastruska;
                                    tort = tort + glazurtorta.chokoladnayastruska;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 8:
                        position = 3;
                        DecorTorta decortorta = new DecorTorta();
                        Console.WriteLine("  " + "Мастика - " + decortorta.cena_mastika);
                        Console.WriteLine("  " + "Свечи - " + decortorta.cena_svechi);
                        Console.WriteLine("  " + "Фото - " + decortorta.cena_photo);
                        position = 3;
                        Strelki();
                        if (clavisha.Key == ConsoleKey.Enter)
                        {
                            switch (position)
                            {
                                case 3:
                                    cena = cena + decortorta.cena_mastika;
                                    tort = tort + decortorta.mastika;
                                    break;
                                case 4:
                                    cena = cena + decortorta.cena_svechi;
                                    tort = tort + decortorta.svechi;
                                    break;
                                case 5:
                                    cena = cena + decortorta.cena_photo;
                                    tort = tort + decortorta.photo;
                                    break;
                            }
                        }
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            Menu();
                            return;
                        }
                        Menu();
                        return;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Благодарим за заказ! Чтобы сделать еще один нажмите Esc");
                        string data = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        File.AppendAllText("C:\\Users\\mrpor\\Desktop\\Заказ.txt", "Текущая дата: " + data + "\n" + "Ваш заказ: " + tort + "\n" + "Цена: " + cena + "\n");
                        clavisha = Console.ReadKey();
                        if (clavisha.Key == ConsoleKey.Escape)
                        {
                            cena = 0;
                            tort = " ";
                            Menu();
                            return;
                        }
                        return;
                }
            }
        }
    }
}
