using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchEngine.BL;

namespace search_engine_project_gon
{
    class UiPrinter
    {
        /// <summary>
        /// user menu printer,get user inputs & starts searching
        /// </summary>
        public void MenuPrinter()
        {

            SearchManager searchManager = new SearchManager();

            /*/*//************************connecting the BL FileResults event, to the UI resultPrinter *************//*/*/

            searchManager.FileResults += resultPrinter;

            /*/*//**************************************************************************************************//*/*/


            string choice;
            string searchQuery;
            string rootDirectory;

            do
            {
                Console.WriteLine(" 1-Enter file name to Search:");
                Console.WriteLine(" 2-Enter file name + folder name to search in:");
                Console.WriteLine(" 3-Exit");

                choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter File name: ");
                        searchQuery = "*" + Console.ReadLine() + "*";
                        rootDirectory = @"c:\";
                        searchManager.SearchEngine(searchQuery, rootDirectory);
                        searchManager.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Enter File name: ");
                        searchQuery = "*" + Console.ReadLine() + "*";
                        Console.WriteLine("Enter root directory: ");
                        rootDirectory = @Console.ReadLine();
                        searchManager.SearchEngine(searchQuery, rootDirectory);
                        searchManager.Clear();
                        break;
                    

                }
            } while (choice != "3");
        }
        /// <summary>
        /// printing the searching result
        /// </summary>
        /// <param name="results"></param>
        public static void resultPrinter(string results)
        {
            
            Console.WriteLine(results);

        }
    }
}

