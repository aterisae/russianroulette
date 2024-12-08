public class GOIDA {
    public static void SVO () {

        DLS.Greet();
        DLS.Converter(out double money);
        
        Console.WriteLine("Введите имя игрока №1: ");
        string player1 = Console.ReadLine()!;
        Console.WriteLine("Введите имя игрока №2: ");
        string player2 = Console.ReadLine()!;
        
        var downs = new List<string> {player1, player2};
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
            
            Console.WriteLine("Выберите действие:\n 1-Выстрел \n 2-Прокрут барабана \n 3-Съебаться в ужасе (бояться) \n 4-Выстрелить в оппонента (ты боишься?)");
            int choice = int.Parse(Console.ReadLine()!);
             while(choice > 4 || choice < 1) {
                Console.WriteLine("Тупорылый аутист выбери норм число");
                choice = int.Parse(Console.ReadLine()!);
            };
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
                            if (loser == player1) {
                                winner = player2;
                            } else {
                                winner = player1;
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
                            if (loser == player1) {
                                winner = player2;
                            } else {
                                winner = player1;
                            }
                            Console.WriteLine($"{player} был застрелен в спину из карманного Fokker-Leimberger");
                            StillAlive = false;
                            Console.WriteLine($"{winner} одержал победу над {player} и получает выигрыш в размере {money - (money * 14.88/100):f2} руб.");
                        } else 
                            Console.WriteLine($"{player} успешно сбежал и проебал деньги");          
                }
                void KillBastard() {
                    if (Bullet != Shoot) {
                        StillAlive = false;
                        Console.WriteLine(".....вам раскрошили еблище");
                        if (loser == player1) {
                                winner = player2;
                            } else {
                                winner = player1;
                            }
                        Console.WriteLine($"{winner} одержал победу над {player} и получает выигрыш в размере {money - (money * 14.88/100):f2} руб.");
                    } else {
                        Console.WriteLine($"Успех! {player} убил оппонента и теперь ему запрещен вход в данное заведение! У него конфисковали все деньги! Даун!");
                        StillAlive = false;
                    }
                }
            }
        }
    }
}
    