﻿using System.Globalization;
using System.Text;
class Program{
    static void Main(){
        var CultureInfo = new CultureInfo("ru-RU");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = enc1251;
        Console.WriteLine("Выберите режим:\n1-PvP\n2-с ботом\n3-с ботом для детей");
        int choice = int.Parse(Console.ReadLine()!);
        switch (choice){
            case 1:
            GOIDA.SVO();
            break;
            case 2:
            GOAL.ZOV();
            break;
            case 3:
            GOALchild.ZOV4ik();
            break;
        }
        while(choice > 4 || choice < 1) {
                Console.WriteLine("От 1 до 3!");
                choice = int.Parse(Console.ReadLine()!);
                }
    }
}

