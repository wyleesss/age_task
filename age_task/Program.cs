using System;
using System.Text; // <- підключаємо відповідну бібліотеку для зміни кодування

namespace Main
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // <- встановлюємо кодування UTF8 для розпізнавання української букви 'і'

            bool show_info = false;
            string info = "програма способом перебору вирішує задачу," +
                          "\nв умові якої дано вік трьох сестер." +
                          "\nсума їх віку дорівнює 13, а добуток - 36." +
                          "\nпрограма вираховує скільки років може бути кожній з них" +
                          "\nу різних випадках.\n";

            if (show_info)
                Console.WriteLine(info);

            int solutions_count = 0;

            for (int first_sister_age = 0; first_sister_age <= 11; first_sister_age++)

                for (int second_sister_age = 0; second_sister_age <= 11; second_sister_age++)

                    for (int third_sister_age = 0; third_sister_age <= 11; third_sister_age++)

                        if (first_sister_age + second_sister_age + third_sister_age == 13
                           && first_sister_age * second_sister_age * third_sister_age == 36)
                            Console.WriteLine($"{++solutions_count} випадок:" +

                                              $"\nперша сестра - {first_sister_age} "
                                              + (first_sister_age == 1 ? "рік;"
                                               : first_sister_age == 2 || first_sister_age == 3 ? "роки;" : "років;") +
                                              //                              ^^^
                                  //за допомогою тернарного оператора перевіряємо вік задля правильного відмінювання слова "років"

                                              $"\nдруга сестра - {second_sister_age} "
                                              + (second_sister_age == 1 ? "рік;"
                                               : second_sister_age == 2 || second_sister_age == 3 ? "роки;" : "років;") +

                                              $"\nтретя сестра - {third_sister_age} "
                                              + (third_sister_age == 1 ? "рік;\n"
                                               : third_sister_age == 2 || third_sister_age == 3 ? "роки;\n" : "років;\n"));

            Console.ReadKey();
        }
    }
}