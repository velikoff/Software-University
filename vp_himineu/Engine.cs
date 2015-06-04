using System;
using Comandos;
using VehiclePark.Interfaces;

namespace VehicleParkSystem2
{
    class Engine : IEngine
    {
        private exec ex;
        Engine(exec ex)
        {
            this.ex = ex;
        }

        public Engine() : this(new exec())
        {
        }
        public void Run()
        {
            while( true)
            {
               string commandLine = Console. ReadLine();
                if (commandLine == null)
                {
                    break;
                }
                commandLine.Trim();
                if (string.IsNullOrEmpty( commandLine))
                {
                    try
                    {
                       // varcomando = new exec. Command(commandLine);
                      //  string commandResult = ex.execução(exec.Command);
                       // Console.WriteLine(commandResult);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}