using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prática
{
    internal class Program
    {
        static void Main(string[] args)
            //Primeiro porjeto em C# - Microsoft Leans//
        {
            int totalProvas = 5;

            decimal sophia;
            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            decimal nicolas;
            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            decimal zahira;
            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            decimal jeong;
            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            sophia = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / (decimal)totalProvas;
            nicolas = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / (decimal)totalProvas;
            zahira = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / (decimal)totalProvas;
            jeong = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / (decimal)totalProvas;

            Console.WriteLine($"Aluno\t Média \tNota");
            Console.WriteLine("_______________________");
            Console.WriteLine($"Sophia\t {sophia} \tA");
            Console.WriteLine($"Nicolas\t {nicolas} \tB");
            Console.WriteLine($"Zahirt\t {zahira} \tB");
            Console.WriteLine($"Jeong\t {jeong} \tA");




        }
    }
}
