using System;

namespace MethodAbstraction {
    class Program {
        static void Main(string[] args) {
            var parameter = new Parameter(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            while (parameter.ParamOne < parameter.ParamTen) {
                if (parameter.ParamOne==1) {
                    Console.WriteLine("I'm in first if");
                    IncreaseAllParams(parameter);
                }
                else if (parameter.ParamTwo==3) {
                    Console.WriteLine("I'm in second if");
                    IncreaseAllParams(parameter);
                }
                else if (parameter.ParamFour == 6) {
                    Console.WriteLine("I'm in three if");
                    IncreaseAllParams(parameter);
                }
                else {
                    Console.WriteLine($"{parameter.ToString()}, because we are still working with the same object");
                    IncreaseAllParams(parameter);
                }
            }
            //The next hascode is different because it created a new object
            Console.WriteLine($"{new Parameter(1, 2, 3, 4, 5, 6, 7, 8, 9, 10).ToString()}, because we are working on a different object now");

            Console.WriteLine("We don finish ooooo!");
            Console.ReadLine();
        }

        static void IncreaseAllParams(Parameter parameter) {
            parameter.ParamOne++;
            parameter.ParamTwo++;
            parameter.ParamThree++;
            parameter.ParamFour++;
            parameter.ParamFive++;
            parameter.ParamSix++;
            parameter.ParamSeven++;
            parameter.ParamEigth++;
            parameter.ParamNine++;
            Console.WriteLine("Performing some magical logic!\n");
        }
    }
}
