using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Birthdate = 5;
            int BirthMonth = 9;
            int BirthYear = 1995;

            int Currentdate = 01;
            int Currentmonth = 2;
            int CurrentYear = 2024;

            int[] arrdays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            int i = 0, j = 0, s = 0;

            s = arrdays[BirthMonth - 1] - Birthdate;
            
            for(i = BirthYear ; i <= CurrentYear; i++)
            {
                if ((i % 4 == 0 && i % 400 == 0) || i % 4 == 0 && i % 100 != 0)
                {
                        s++;
                }

                for(j = BirthMonth + 1 ;j <= 12 ; j++)
                {
                    if (i == CurrentYear && j == 2)
                        s--;
                    if (i == CurrentYear && j == Currentmonth )
                    {
                        s += Currentdate;
                        break;
                    }
                    else
                    {
                        s += arrdays[j - 1];
                    }
                    BirthMonth = 0;
                }
            }
            Console.WriteLine("TotalDays   =   " +s);
            int ageInYears = s / 365;
            int remainingDays = s % 365;
            int months = remainingDays / 30; 
            int days = remainingDays % 30;

            Console.WriteLine(ageInYears + " years " + months + " months " + (days-6) + " days");
        }
    }
}