using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Task_4
{
    public class Money
    {
        private int grivny;
        private int kop;

        public int Grivny
        {
            get
            {
                return grivny;
            }
            set
            {
                if (value > 0)
                {
                    grivny = value;
                }
                else
                {
                    grivny = 0;
                }
            }
        }

        public int Kop
        {
            get
            {
                return kop;
            }
            set
            {
                if (value > 0)
                {
                    kop = value;
                }
                else
                {
                    kop = 0;
                }
            }
        }

        public void Kopp()// переводить в копійки
        {
            kop = grivny * 100;
            Console.WriteLine("Ваша сума в копійках: "+ kop);
        }
        public void Grikopp()//переводить в гривні
        {
            if (kop < 100)
            {
                grivny = 0;
                Console.WriteLine("Навіть до гривні не дотягнуло");
            }               
            else
            {
                grivny = kop / 100;
                Console.WriteLine("Ваша сума в гривнях: " + grivny);
            }
        }
  
    }
    public class Funcs
    {
        int val1;
        int val2;

        public int Val1
        {
            get
            {
                return val1;
            }
            set
            {
                if (value > 0)
                {
                    val1 = value;
                }
                else
                {
                    val1 = 0;
                }
            }
        }

        public int Val2
        {
            get
            {
                return val2;
            }
            set
            {
                if (value > 0)
                {
                    val2 = value;
                }
                else
                {
                    val2 = 0;
                }
            }

        }
        public void Minusplus(int a, int b)
        {
            Console.WriteLine("Якщо хочете додати ці суми натисніть клавішу Q.\nЯкщо хочете отримати різницю цих сум натисніть Y");
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    if (a > b)
                        Console.WriteLine("Різниця сум: " + (a - b));
                    else if (b > a)
                        Console.WriteLine("Різниця сум: " + (b - a));
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("Сума сум: " + (a + b));
                    break;
            }
        }
    }
    class Program
    {
        private static void Readin()
        {
            int mayu=0;
            string path_x = @"files\money.txt";
            string file_data = File.ReadAllText(path_x);
            try
            {
                int massi = Convert.ToInt32(file_data);
                mayu += massi;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Щось не так з даними.");
                Environment.Exit(0);
            }
            Console.WriteLine($"\n     Ваша сума: {mayu}");
            Money newtry = new Money();
            Console.WriteLine("Якщо у файлі були гривні, натисніть клавішу Y.\nЯкщо копійки, натисніть клавішу Q.");
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у копійки?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                newtry.Kopp();
                                Console.WriteLine("\nХочете перевести назад у гривні?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                {
                                    case ConsoleKey.Enter:
                                        newtry.Grikopp();
                                        break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                break;
                        }
                        break;
                    }
                    break;
                case ConsoleKey.Q:
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у гривні?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                newtry.Grikopp();
                                Console.WriteLine("\nХочете перевести назад у копійки?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                {
                                    case ConsoleKey.Enter:
                                        newtry.Kopp();
                                        break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                break;
                        }
                        break;
                    }
                    break;
            }
        }

        static void Money_only()
        {
            Money try1 = new Money();
            Console.WriteLine("Якщо хочете ввести гривні, натисніть клавішу Y.\nЯкщо хочете ввести копійки, натисніть клавішу Q.");
            var input = Console.ReadKey();
            Console.WriteLine("\nТепер можете вводити");
            switch (input.Key)
            {
                case ConsoleKey.Y:
                    while (true)
                    {
                        try
                        {
                            string gri = Console.ReadLine();
                            try1.Grivny = Convert.ToInt32(gri);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                        }
                    }
                    Console.WriteLine($"\nВаша сума: {try1.Grivny} грн.");
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у копійки?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                try1.Kopp();
                                Console.WriteLine("\nХочете перевести назад у гривні?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                {
                                    case ConsoleKey.Enter:
                                        try1.Grikopp();
                                        break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                break;
                        }
                        break;
                    }
                    break;
                case ConsoleKey.Q:
                    while (true)
                    {
                        try
                        {
                            string ko = Console.ReadLine();
                            try1.Kop = Convert.ToInt32(ko);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                        }
                    }
                    Console.WriteLine($"\nВаша сума:  {try1.Kop} коп.");
                    while (true)
                    {
                        Console.WriteLine("\nХочете перевести у гривні?\n Так - натисніть Enter.\n Ні - натисніть Escape.");
                        var input_1 = Console.ReadKey();
                        switch (input_1.Key)
                        {
                            case ConsoleKey.Enter:
                                try1.Grikopp();
                                Console.WriteLine("\nХочете перевести назад у копійки?\nТак - натисніть Enter.\n Ні - натисніть Escape.");
                                var input_2 = Console.ReadKey();
                                switch (input_2.Key)
                                {
                                    case ConsoleKey.Enter:
                                        try1.Kopp();
                                        break;
                                    case ConsoleKey.Escape:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                break;
                        }
                        break;
                    }
                    break;
            }
        }
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Починаємо\n");

            Console.WriteLine("Якщо хочете ввести суму самі, натисніть клавішу A.\nЯкщо хочете загрузити з файлу, натисніть клавішу B.");
            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.A:
                    Money_only();
                    break;
                case ConsoleKey.B:
                    Readin();

                    break;
            }


            Funcs letsstart = new Funcs();
            Console.WriteLine("\nВведіть дві суми для обрахунків.");
            while (true){
                try
                {
                    string vall = Console.ReadLine();
                    letsstart.Val1 = Convert.ToInt32(vall);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                }
            }
            while (true) {
                try
                {
                    string valll = Console.ReadLine();
                    letsstart.Val2 = Convert.ToInt32(valll);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Щось пішло не так. Введіть ще раз.");
                }
            }

            letsstart.Minusplus(letsstart.Val1, letsstart.Val2);

            Console.ReadKey();
        }
    }
}
