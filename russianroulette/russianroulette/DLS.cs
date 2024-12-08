class DLS {
    public static void Greet ()
    {
        bool boishsa = false;
        while(!boishsa) {
            Console.WriteLine("Вы боитесь?");
            string answer = Console.ReadLine()!;
            if (answer == "нет" || answer == "Нет" || answer == "не" || answer == "Не"|| answer == "НЕ"|| answer == "НЕТ") {
                Console.WriteLine("Не ври.");
            } else {
                Console.WriteLine("НЕ БОЙСЯ");
                boishsa = true;
            }
        }
    }
    public static double Converter (out double money) {
            Console.WriteLine("Сколько рублей ставите?");
            money = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Выберите местную валюту: ");
            Console.WriteLine("1 - Рубли\n2 - Монгольские тугрики\n3 - Поганые доллары\n4 - Тенге");
            int valuta = int.Parse(Console.ReadLine()!);
            switch(valuta){
                case 1:
                    Rubles(ref money);
                    break;
                case 2:
                    MongolsTugriks(ref money);
                    break;
                case 3:
                    PendosskiyBaks(ref money);
                    break;
                case 4:
                    Tenge(ref money);
                    break;
                }
            void Rubles(ref double money) {}
            void MongolsTugriks(ref double money) {
                money *= 0.0256;
                }
            void PendosskiyBaks(ref double money) {
                money*=90;
                }
            void Tenge(ref double money) {
                money /= 5;
                }
            return money;
        }
        
        public static double Converter4Child (out double money) {
            Console.WriteLine("Сколько конфет ставите?");
            money = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Выберите какие это конфеты: ");
            Console.WriteLine("1 - Очень вкусные\n2 - Вкусные\n3 - Не очень вкусные\n4 - Очень невкусные");
            int valuta = int.Parse(Console.ReadLine()!);
            switch(valuta){
                case 1:
                    money+=10;
                    break;
                case 2:
                   money*=2;
                    break;
                case 3:
                    money/=2;
                    break;
                case 4:
                    money/=10;
                    break;
                }            
            return money;
        }
}