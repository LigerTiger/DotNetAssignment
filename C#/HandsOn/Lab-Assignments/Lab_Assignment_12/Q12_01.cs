using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.IO;


namespace Lab_Assignment_12
{
    class Q12_01
    {
        static void Main()
        {
            try
            {
                //ACCEPT THE NAME OF THE FILE FROM THE USER.
                Console.Write("Enter the file name: ");
                string textFile = Console.ReadLine();
                using (StreamReader file = new StreamReader(textFile))
                {


                    string line;
                    //read a line from the file
                    while ((line = file.ReadLine()) != null)
                    {
                        //DISPLAY THE LINE
                        Console.WriteLine(line);
                    }
                    //CLOSE THE FILE
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                // HANDLE ALL THE EXCEPTIONS THAT MIGHT OCCUR DURING READING.
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
