using BarcodeLib;
using BarcodeLib.BarcodeReader;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace BarcodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //BarcodeGenerator();

            BarcoreReader();

        }

        private static void BarcoreReader()
        {
            string[] BarcodeUPCA = BarcodeReader.read(@"D:\Ariku\Patika\PatikaVisualStudioCsharpPath\BarcodeGen\Barcode.png", BarcodeReader.UPCA);
            Console.WriteLine("UPCA Code:" + ConvertStringArrayToString(BarcodeUPCA));
        }

        static string ConvertStringArrayToString(string[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);

            }
            return builder.ToString();
        }

        private static void BarcodeGenerator()
        {
            //code from
            //https://qawithexperts.com/article/c-sharp/barcode-generator-in-c-and-how-to-read-barcode/266

            // Create an instance of the API
            Barcode barcodLib = new Barcode();


            int imageWidth = 290;  // barcode image width
            int imageHeight = 120; //barcode image height
            Color foreColor = Color.Black; // Color to print barcode
            Color backColor = Color.White; //background color

            //only numbers are allowed in UPCA type
            string NumericString = "038000350216";

            //type upca
            Image barcodeImage = barcodLib.Encode(TYPE.UPCA, NumericString, foreColor, backColor, imageWidth, imageHeight);

            // Store image in some path with the desired format
            //note: you must have permission to save file in the specified path
            barcodeImage.Save(@"D:\Ariku\Patika\PatikaVisualStudioCsharpPath\BarcodeGen\Barcode.png", ImageFormat.Png);
        }
    }
}
