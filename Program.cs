using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ю1
{
    
         interface Parent
        {
            string Info();//інф. про об'єкт
            void Method();//Обчислює дохід
        }
        class Child1 : Parent//загальний вагон
        {
            private double pole1;//ціна квитка
            private int pole2;//кількість місць
            private double pole3;//дохід від вагона
                                 //конструктор
            public Child1(double pole1, int pole2)
            {
                this.pole1 = pole1;
                this.pole1 = pole2;
            }
            //інтерфейс
            public string Info()
            {
                return $"Загальний вагон: Цiна квитка: {pole1}, " + $"Кiлькiсть квиткiв: {pole2}, Дохiд: {pole3}";
            }
            public void Method()//дохід
            {
                pole3 = pole1 * pole2;
            }
        }
        class Child2 : Parent //плацкарт
        {
            private double pole1;//ціна квитка
            private int pole2;//кількість місць
            private double pole3;//дохід від вагона
            private double pole4; //вартість додаткових послуг
                                  //конструктор
            public Child2(double pole1, int pole2, double pole4)
            {
                this.pole1 = pole1;
                this.pole2 = pole2;
                this.pole4 = pole4;
            }
            public string Info()
            {
                return $"Плацкартний вагон: Цiна квитка: {pole1}," + $"Кiлькiсть квиткiв: {pole2}, Додатковi послуги: {pole4}, Дохiд: {pole3}";
            }
            public void Method()//дохід
            {
                pole3 = pole1 * pole2 + pole2 * pole4 * 0.5;
            }
        }
        class Child3 : Parent //плацкарт
        {
            private double pole1;//ціна квитка
            private int pole2;//кількість місць
            private double pole3;//дохід від вагона
            private double pole5; //вартість додаткових послуг
                                  //конструктор
            public Child3(double pole1, int pole2, double pole5)
            {
                this.pole1 = pole1;
                this.pole2 = pole2;
                this.pole5 = pole5;
            }
            public string Info()
            {
                return $"Купейний вагон: Цiна квитка: {pole1}, " + $"Кiлькiсть квиткiв: {pole2}, Додатковi послуги: {pole5}, Дохiд: {pole3}";
            }
            public void Method()
            {
                pole3 = pole2 * (pole1 + pole5);
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Parent k;
                Random o = new Random();
                for (int i = 1; i <= 5; i++)
                {
                    int type = o.Next(1, 3);
                    if (type == 1)
                    {
                        double pay = o.Next(100, 150);
                        int z = o.Next(1, 54);
                        k = new Child1(pay, z);
                        Console.WriteLine(k.Info());
                    }
                    if (type == 2)
                    {
                        double dopus = o.Next(60, 200);
                        int z = o.Next(1, 81);
                        double pay = o.Next(50, 100);
                        k = new Child2(pay, z, dopus);
                        Console.WriteLine(k.Info());
                    }
                    if (type == 3)
                    {
                        double dopus = o.Next(60, 300);
                        int z = o.Next(1, 36);
                        double pay = o.Next(150, 190);
                        k = new Child3(pay, z, dopus);

                        Console.WriteLine(k.Info());
                    }
                }
            }
        }
    }


    

