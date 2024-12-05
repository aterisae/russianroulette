public class GOAL {
    public static void ZOV () {

        DLS.Greet();
        DLS.Converter(out double money);
        
        Console.WriteLine("Введите имя игрока: ");
        string gamer = Console.ReadLine()!;
        if (gamer == "БОТ НИКАНОР") {
            Console.WriteLine("ТАК НЕ ПОЙДЕТ!Будешь дауном.");
            gamer="Даун";
        }
        string bot = "БОТ НИКАНОР";
        
        var downs = new List<string> {gamer, bot};
        Queue<string> players = new Queue<string>(downs);
        Random random = new Random();
        int Bullet = random.Next(1, 6);
        int Shoot = random.Next(1, 6);
        bool StillAlive = true;
        while(StillAlive == true){
            foreach (var player in players) {
                if (!StillAlive) break;

                string loser = player;
                string winner = player;
                Console.WriteLine($"Сейчас очередь {player}");
            int choice=0;
            if (player == "БОТ НИКАНОР") {
                double botchance=random.NextDouble();
                if(botchance<0.97)choice=1;
                if(botchance>=0.97 && botchance<0.98)choice=2;
                if(botchance>=0.98 && botchance<0.99)choice=3;
                if(botchance>=0.99 && botchance<1)choice=4;

            }
            else{
                Console.WriteLine("Выберите действие:\n 1-Выстрел \n 2-Прокрут барабана \n 3-Съебаться в ужасе (бояться) \n 4-Выстрелить в оппонента (ты боишься?)");
                choice = int.Parse(Console.ReadLine()!);
            }
            if(choice > 4 || choice < 1) Console.WriteLine("Тупорылый аутист выбери норм число");
                switch(choice){
                    case 1:
                    Shooting();
                    break;
                    case 2:
                    Prokrut();
                    break;
                    case 3:
                    Exit();
                    break;
                    case 4:
                    KillBastard();
                    break;
                }
                void Shooting() {
                 Console.WriteLine("Ствол у виска.Выстрел!");
                    if (Bullet == Shoot) {
                            StillAlive = false;
                            Console.WriteLine($"{player} застрелился");
                            if (loser == gamer) {
                                winner = bot;
                            } else {
                                winner = gamer;
                            }
                            Console.WriteLine($"{winner} одержал победу над {loser} и получает выигрыш в размере {money - (money * 14.88/100):f2} руб.");
                    } else Console.WriteLine($"{player} остался жив");
                }
                    Shoot++;
                    if (Shoot == 7) Shoot = 1;
                    
                
                void Prokrut() {
                    Random random = new Random();
                    Shoot = random.Next(1, 6);
                    Console.WriteLine("Барабан прокручен.");
                    Shooting();
                }

                void Exit() {

                        StillAlive = false;
                        Console.WriteLine("При попытке побега...");
                        Random rnd = new Random();
                        int chance = rnd.Next(1, 11);
                        if (chance <= 7) {
                            if (loser == gamer) {
                                winner = bot;
                            } else {
                                winner = gamer;
                            }
                            Console.WriteLine($"{loser} был застрелен в спину из карманного Fokker-Leimberger");
                            StillAlive = false;
                            Console.WriteLine($"{winner} одержал победу над {loser} и получает выигрыш в размере {money - (money * 14.88/100):f2} руб.");
                        } else 
                            Console.WriteLine($"{loser} успешно сбежал и проебал деньги");          
                }
                void KillBastard() {
                    if (Bullet != Shoot) {
                        StillAlive = false;
                        Console.WriteLine(".....вам раскрошили еблище");
                        if (loser == gamer) {
                                winner = bot;
                            } else {
                                winner = gamer;
                            }
                        Console.WriteLine($"{winner} одержал победу над {loser} и получает выигрыш в размере {money - (money * 14.88/100):f2} руб.");
                    } else {
                        Console.WriteLine($"Успех! {loser} убил оппонента и теперь ему запрещен вход в данное заведение! У него конфисковали все деньги! Даун!");
                        StillAlive = false;
                    }
                }
            }
        }
    }
}
    