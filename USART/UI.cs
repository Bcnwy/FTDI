//**************************************/
// Version: v1.2
// Author: Benjamin Conway
//
//*************************************/
using System;

namespace Usart
{
    partial class Program
    {
        class UI
        {
            private bool bSave;
            public UI()
            {
            }

            public bool BSave { get => bSave; set => bSave = value; }

            public int StartPage()
            {
                Console.WriteLine("             ******************************************");
                Console.WriteLine("             *       Direct Access Usart Interface    *");
                Console.WriteLine("             *       FTDI Only compatible             *");
                Console.WriteLine("             *       version v1.1                     *");
                Console.WriteLine("             ******************************************\n");
                return 0;
            }

            public int UserToSave(Save myFile)
            {
                // Get file location to bSave to
                //Save myFile = nulln;
                Console.Write("Do you wish to Save to file? (Y/N) ");

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    bSave = true;
                    string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
                    Console.Write("\nLocation to Save file:\n" + directory);
                    string filePath = (directory + Console.ReadLine() + ".csv");
                    Console.WriteLine("\nSave file set as:");
                    Console.WriteLine(filePath);
                    // Create our file to Save data
                    myFile = new Save(filePath);
                }
                return 0;
            }
        }
    }
}
           
