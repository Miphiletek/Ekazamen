using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Регистрационный номер ТС в формате х111хх01 или х111хх101");

            string reg = Console.ReadLine();

            if (reg.Length == 8)
            {
                var res = reg.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                string resq = new string(res);


                int[] regon = { 01, 02, 102, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 113, 14, 15, 16, 116, 716, 17, 18, 19, 21, 121, 22, 23, 93, 123, 193, 24, 124, 25, 125, 26, 126, 27, 28, 29, 30, 31, 32, 33, 34, 134, 35, 36, 136, 37, 38, 138, 39, 40, 42, 142, 43, 44, 45, 46, 47, 147, 48, 49, 50, 90, 150, 190, 750, 51, 152, 53, 54, 154, 55, 56, 156, 57, 58, 59, 159, 60, 61, 161, 761, 6263, 163, 763, 64, 164, 65, 66, 96, 196, 67, 68, 69, 70, 71, 72, 73, 17374, 174, 75, 76, 77, 97, 99, 177, 197, 199, 777, 797, 799, 78, 98, 178, 19879, 82, 83, 86, 186, 87, 89, 92, 95, };

                int k = 0;
                for (int i = 0; i < resq.Length; i++)
                {

                    if (resq[i] == 'а' || resq[i] == 'в' || resq[i] == 'е' || resq[i] == 'к' || resq[i] == 'м' || resq[i] == 'н' || resq[i] == 'о' || resq[i] == 'в' || resq[i] == 'р' || resq[i] == 'с' || resq[i] == 'т' || resq[i] == 'у')
                    {
                        k++;

                    }

                }




                if (k == 3)
                {
                    char[] arr, gar, nar;
                    arr = reg.ToCharArray(1, 3);
                    string kyt = new string(arr);
                    int perk = Convert.ToInt32(kyt);
                    if (perk != 000)
                    {

                        gar = reg.ToCharArray(6, 2);
                        string rupka = new string(gar);
                        int kek = Convert.ToInt32(rupka);



                        int index = Array.IndexOf(regon, kek);

                        if ((index > 0) || (index == 0))
                        {
                            Console.WriteLine("Такой номер есть");


                            nar = new char[] { 'а', 'в', 'е', 'к', 'м', 'н', 'о', 'р', 'с', 'т', 'у', 'х' };
                            Random rand = new Random();
                            int nomer = rand.Next(001, 999);
                            if (nomer < 100)
                            {
                                nomer += 100;
                            }
                            int axu = rand.Next(0, nar.Length);

                            Console.WriteLine("Новый номер  " + nar[rand.Next(0, 11)] + nomer + nar[rand.Next(0, 11)] + nar[rand.Next(0, 11)] + "1" + kek);

                            if (perk % 111 == 0)
                            {
                                Console.WriteLine("Номер красивый");
                            }
                            else
                            {
                                Console.WriteLine("номер не красивый");
                            }
                        }
                    }
                }






                else
                {
                    Console.WriteLine("Xyuna");
                }

            }
            if (reg.Length == 9)
            {
                var res = reg.ToCharArray().Where(n => !char.IsDigit(n)).ToArray();
                string resq = new string(res);
                Console.WriteLine(resq);

                int[] regon = { 01, 02, 102, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 113, 14, 15, 16, 116, 716, 17, 18, 19, 21, 121, 22, 23, 93, 123, 193, 24, 124, 25, 125, 26, 126, 27, 28, 29, 30, 31, 32, 33, 34, 134, 35, 36, 136, 37, 38, 138, 39, 40, 42, 142, 43, 44, 45, 46, 47, 147, 48, 49, 50, 90, 150, 190, 750, 51, 152, 53, 54, 154, 55, 56, 156, 57, 58, 59, 159, 60, 61, 161, 761, 6263, 163, 763, 64, 164, 65, 66, 96, 196, 67, 68, 69, 70, 71, 72, 73, 17374, 174, 75, 76, 77, 97, 99, 177, 197, 199, 777, 797, 799, 78, 98, 178, 19879, 82, 83, 86, 186, 87, 89, 92, 95, };

                int k = 0;
                for (int i = 0; i < resq.Length; i++)
                {

                    if (resq[i] == 'а' || resq[i] == 'в' || resq[i] == 'е' || resq[i] == 'к' || resq[i] == 'м' || resq[i] == 'н' || resq[i] == 'о' || resq[i] == 'в' || resq[i] == 'р' || resq[i] == 'с' || resq[i] == 'т' || resq[i] == 'у')
                    {
                        k++;

                    }

                }




                if (k == 3)
                {
                    char[] arr, gar, nar;
                    arr = reg.ToCharArray(1, 3);
                    string kyt = new string(arr);
                    int perk = Convert.ToInt32(kyt);
                    if (perk != 000)
                    {

                        gar = reg.ToCharArray(7, 2);
                        string rupka = new string(gar);
                        int kek = Convert.ToInt32(rupka);



                        int index = Array.IndexOf(regon, kek);

                        if ((index > 0) || (index == 0))
                        {
                            Console.WriteLine("Такой номер есть");


                            nar = new char[] { 'а', 'в', 'е', 'к', 'м', 'н', 'о', 'р', 'с', 'т', 'у', 'х' };
                            Random rand = new Random();
                            int nomer = rand.Next(001, 999);
                            if (nomer < 100)
                            {
                                nomer = +100;
                            }
                            int axu = rand.Next(0, nar.Length);
                            Console.WriteLine("Новый номер  " + nar[rand.Next(0, 11)] + nomer + nar[rand.Next(0, 11)] + nar[rand.Next(0, 11)] + "7" + kek);
                            int kras = Convert.ToInt32(kyt);
                            if (kras % 111 == 0)
                            {
                                Console.WriteLine("Номер красивый");
                            }
                        }
                    }
                }






                else
                {
                    Console.WriteLine("Xyuna");
                }

            }














            else if (reg.Length < 8 || reg.Length > 9)
            {


                Console.WriteLine("неправильный формат или строка не является номером");
            }


        }

    }
}

