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
    class Q12_02
    {


        private static string parentDirectory = @"C:\Academy";
        private static string backupCopyDirectory = @"D:\Academy";


        //CHENNAI: CHENNAI.TXT
        private static string childDirectoryChennai = @"C:\Academy\Chennai";
        //BANGALORE: BANGALORE.TXT
        private static string childDirectoryBangalore = @"C:\Academy\Bangalore";
        //MUMBAI: MUMBAI.TXT
        private static string childDirectoryMumbai = @"C:\Academy\Mumbai";
        //PUNE: PUNE.TXT
        private static string childDirectoryPune = @"C:\Academy\Pune";


        //PATH TO THE FILE CHENNAI.TXT
        private static string fileChennai = @"C:\Academy\Chennai\Chennai.txt";
        //PATH TO THE FILE BANGALORE.TXT
        private static string fileBangalore = @"C:\Academy\Bangalore\Bangalore.txt";
        //PATH TO THE FILE MUMBAI.TXT
        private static string fileMumbai = @"C:\Academy\Mumbai\Mumbai.txt";
        //PATH TO THE FILE PUNE.TXT
        private static string filePune = @"C:\Academy\Pune\Pune.txt";


        
        public static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("1. Create directory structure and files (if not exists)");
                Console.WriteLine("2. Add batch details");
                Console.WriteLine("3. Create a backup copy of Academy folder in D Drive");
                Console.WriteLine("4. View details of text files");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            CreateDirectoryStructureFiles();
                        }
                        break;
                    case 2:
                        {
                            int choiceSubMenu = 0;
                            while (choiceSubMenu != 5)
                            {
                                Console.WriteLine("1. Add batch details for Chennai");
                                Console.WriteLine("2. Add batch details for Bangalore");
                                Console.WriteLine("3. Add batch details for Mumbai");
                                Console.WriteLine("4. Add batch details for Pune");
                                Console.WriteLine("5. Exit to main menu");
                                Console.Write("Your choice: ");


                                choiceSubMenu = int.Parse(Console.ReadLine());
                                switch (choiceSubMenu)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter the details infromation for Chennai: ");
                                            string detailsInfromation = Console.ReadLine();
                                            SaveBatchDetailsToFile(fileChennai, detailsInfromation);
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Write("Enter the details infromation for Bangalore: ");
                                            string detailsInfromation = Console.ReadLine();
                                            SaveBatchDetailsToFile(fileBangalore, detailsInfromation);
                                        }


                                        break;
                                    case 3:
                                        {
                                            Console.Write("Enter the details infromation for Mumbai: ");
                                            string detailsInfromation = Console.ReadLine();
                                            SaveBatchDetailsToFile(fileMumbai, detailsInfromation);
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.Write("Enter the details infromation for Pune: ");
                                            string detailsInfromation = Console.ReadLine();
                                            SaveBatchDetailsToFile(filePune, detailsInfromation);
                                        }
                                        break;
                                    case 5:
                                        //exit
                                        break;


                                    default:
                                        Console.WriteLine("Wrong menu item. Try again.");
                                        break;
                                }
                            }
                        }


                        break;
                    case 3:
                        {
                            try
                            {
                                CreateBackupCopy(parentDirectory, backupCopyDirectory);
                                Console.WriteLine("\nThe backup copy of Academy folder in D Drive has been created.\n");
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }


                        }
                        break;
                    case 4:
                        {
                            int choiceSubMenu = 0;
                            while (choiceSubMenu != 5)
                            {
                                Console.WriteLine("1. View batch details for Chennai");
                                Console.WriteLine("2. View batch details for Bangalore");
                                Console.WriteLine("3. View batch details for Mumbai");
                                Console.WriteLine("4. View batch details for Pune");
                                Console.WriteLine("5. Exit to main menu");
                                Console.Write("Your choice: ");


                                choiceSubMenu = int.Parse(Console.ReadLine());
                                switch (choiceSubMenu)
                                {
                                    case 1:
                                        {
                                            ViewatchDetails("Chennai", fileChennai);
                                        }
                                        break;
                                    case 2:
                                        {
                                            ViewatchDetails("Bangalore", fileBangalore);
                                        }


                                        break;
                                    case 3:
                                        {
                                            ViewatchDetails("Mumbai", fileMumbai);
                                        }
                                        break;
                                    case 4:
                                        {
                                            ViewatchDetails("Pune", filePune);
                                        }
                                        break;
                                    case 5:
                                        //exit
                                        break;


                                    default:
                                        Console.WriteLine("Wrong menu item. Try again.");
                                        break;
                                }
                            }
                        }
                        break;
                    case 5:
                        //exit
                        break;


                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }


            Console.ReadLine();


        }
        
        private static void ViewatchDetails(string batch, string fileName)
        {
            if (File.Exists(fileName))
            {
                string content = File.ReadAllText(fileName, Encoding.UTF8);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("\nThe batch details for " + batch + " does not exist.\n");
            }
        }
       
        private static void CreateDirectoryStructureFiles()
        {
            // IF DIRECTORY DOES NOT EXIST, CREATE IT
            if (!Directory.Exists(parentDirectory))
            {
                Directory.CreateDirectory(parentDirectory);
            }
            if (Directory.Exists(parentDirectory))
            {
                //CREATE CHILD DIRECTORIES
                CreateDirectory(childDirectoryChennai);
                CreateDirectory(childDirectoryBangalore);
                CreateDirectory(childDirectoryMumbai);
                CreateDirectory(childDirectoryPune);
            }
            //CREATE THE FILES IN THE FOLDERS
            if (Directory.Exists(parentDirectory))
            {


                CreateFile(childDirectoryChennai, fileChennai);
                CreateFile(childDirectoryBangalore, fileBangalore);
                CreateFile(childDirectoryMumbai, fileMumbai);
                CreateFile(childDirectoryPune, filePune);
                Console.WriteLine("\nThe directory structure and files have been created.\n");
            }
        }
        
        private static void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
        
        private static void CreateFile(string directory, string fileName)
        {
            if (Directory.Exists(directory))
            {
                if (!(File.Exists(fileName)))
                {
                    File.CreateText(fileName);
                }
            }
        }
        
        private static void SaveBatchDetailsToFile(string fileName, string batchDetails)
        {
            using (StreamWriter streamWriter = File.AppendText(fileName))
            {
                streamWriter.WriteLine(batchDetails);
            }
        }
       
        private static void CreateBackupCopy(string sourceFolder, string backupCopyFolder)
        {
            if (!Directory.Exists(backupCopyFolder))
                Directory.CreateDirectory(backupCopyFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string backupCopyFile = Path.Combine(backupCopyFolder, fileName);
                if ((File.Exists(backupCopyFile)))
                {
                    File.Delete(backupCopyFile);
                    File.Copy(file, backupCopyFile);
                }
                else
                {
                    File.Copy(file, backupCopyFile);
                }
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string fileName = Path.GetFileName(folder);
                string backupCopyFile = Path.Combine(backupCopyFolder, fileName);
                CreateBackupCopy(folder, backupCopyFile);
            }
        }
    }
}
