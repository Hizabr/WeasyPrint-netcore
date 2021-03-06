using System;
using System.IO;
using Xunit;

namespace Balbarak.WeasyPrint.Test
{
    public class WeasyPrintClientTest
    {
        [Fact]
        public void GeneratePdfTest()
        {
            var html = File.ReadAllText("index.html");

            using (WeasyPrintClient client = new WeasyPrintClient())
            {
                var result = client.GeneratePdf(html);
                
                File.WriteAllBytes($"{Directory.GetCurrentDirectory()}\\output.pdf", result);
            }
        }

        [Fact]
        public void GeneratePdfOutputTest()
        {
            var html = File.ReadAllText("index.html");

            var input = @"C:\Repos\WeasyPrint-netcore\src\Balbarak.WeasyPrint.Test\index.html";
            var ouput = @"C:\Users\balbarak\Desktop\output\test.pdf";

            using (WeasyPrintClient client = new WeasyPrintClient())
            {
                client.GeneratePdf(input, ouput);
            }
        }
    }
}
