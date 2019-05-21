using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {// Tim Hansen//
        static void Main(string[] args)//
        { //Didnt do enough Classes so i put it in something i knew//
            Console.WriteLine("Your salary is set at 80000 per year");
            // dont know why its not reading this line//
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Plesae enter the how many weeks you work");
            double week = double.Parse(Console.ReadLine());
            // dont understand why this wont run



            //This will Write what the total of your salary a week is//
            Console.WriteLine($"Your salary a week is" + Total(money, week));
            Console.ReadLine(); 
        }
        static double Total(double money, double week) {


            //this returns the method
            return money / week;

        }

    

     







    

  




