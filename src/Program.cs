using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace Data_Feeds_and_Technology
{
    class Program
    {
        static Excel.Workbook workbook;
        static Excel.Application app;

        static void Main(string[] args)
        {
            app = new Excel.Application
            {
                Visible = true,
                WindowState = Excel.XlWindowState.xlMaximized
            };
            try
            {
                workbook = app.Workbooks.Open("property_pricing.xlsx", ReadOnly: false);
            }
            catch
            {
                SetUp();
            }
            var input = "";
            while (input != "x")
            {
                PrintMenu();
                input = Console.ReadLine();
                try
                {
                    var option = int.Parse(input);
                    switch (option)
                    {
                        case 1:
                            try
                            {
                                Console.Write("Enter the size: ");
                                var size = float.Parse(Console.ReadLine());
                                Console.Write("Enter the suburb: ");
                                var suburb = Console.ReadLine();
                                Console.Write("Enter the city: ");
                                var city = Console.ReadLine();
                                Console.Write("Enter the market value: ");
                                var value = float.Parse(Console.ReadLine());

                                AddPropertyToWorksheet(size, suburb, city, value);
                            }
                            catch
                            {
                                Console.WriteLine("Error: couldn't parse input");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Mean price: " + CalculateMean());
                            break;
                        case 3:
                            Console.WriteLine("Price variance: " + CalculateVariance());
                            break;
                        case 4:
                            Console.WriteLine("Minimum price: " + CalculateMinimum());
                            break;
                        case 5:
                            Console.WriteLine("Maximum price: " + CalculateMaximum());
                            break;
                        default:
                            break;
                    }
                } catch { }
            }

            // save before exiting
            try
            {
                workbook.Save();
                workbook.Close();
            }
            catch { }
            app.Quit();
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select an option (1, 2, 3, 4, 5) " +
                              "or enter 'x' to quit...");
            Console.WriteLine("1: Add Property");
            Console.WriteLine("2: Calculate Mean");
            Console.WriteLine("3: Calculate Variance");
            Console.WriteLine("4: Calculate Minimum");
            Console.WriteLine("5: Calculate Maximum");
            Console.WriteLine();
        }

        static void SetUp()
        {
            // add a workbook and set it as active
            app.Workbooks.Add();
            workbook = app.ActiveWorkbook;

            // set current worksheet
            Excel._Worksheet currentSheet = workbook.Worksheets[1];

            // set sheet name
            currentSheet.Name = "Properties";

            // set columns names
            currentSheet.Cells[1, "A"] = "Size (sf)";
            currentSheet.Cells[1, "B"] = "Suburb";
            currentSheet.Cells[1, "C"] = "City";
            currentSheet.Cells[1, "D"] = "Value";
            currentSheet.Cells[1, "E"] = 0;

            // save workbook
            workbook.SaveAs("property_pricing.xlsx");
        }

        static void AddPropertyToWorksheet(float size, string suburb, string city, float value)
        {
            // set current worksheet
            Excel.Worksheet currentSheet = workbook.Worksheets[1];
            
            var nrows = currentSheet.Cells[1, "E"].value;
            nrows += 2; // need to increment since nrows above is the last FILLED row

            // add property data to the table 
            currentSheet.Cells[nrows, "A"] = size;
            currentSheet.Cells[nrows, "B"] = suburb;
            currentSheet.Cells[nrows, "C"] = city;
            currentSheet.Cells[nrows, "D"] = value;
            currentSheet.Cells[1, "E"] = nrows - 1;
        }

        static float CalculateMean()
        {
            // TODO: Implement this method
            return 0.0f;
        }

        static float CalculateVariance()
        {
            // TODO: Implement this method
            return 0.0f;
        }

        static float CalculateMinimum()
        {
            // TODO: Implement this method
            return 0.0f;
        }

        static float CalculateMaximum()
        {
            // TODO: Implement this method
            return 0.0f;
        }
    }
}
