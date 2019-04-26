using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Create_Website
{
    class Webpage
    {
        string templateLocation = @"C:\Users\grey\Desktop\Hobbies\PROGRAMMING\Programming\HTML Template.txt";

        StreamReader templateReader;
        StreamWriter writer;

        public Webpage (string writeLocation, string fileName)
        {
            templateReader = new StreamReader(templateLocation);
            writer = new StreamWriter(writeLocation);
            while (!templateReader.EndOfStream)
            {
                string line = templateReader.ReadLine();
                writer.WriteLine(line);
                if (line == "<style>")
                {
                    writer.WriteLine(createCSSStyle());
                    break;
                }
                else if(line == "<body>")
                {
                    writer.WriteLine(createBody());
                    break;
                }
            }
            writer.Close();
            templateReader.Close();
        }

        string createCSSStyle()
        {
            string stylesheet = "";

            return stylesheet;
        }

        string createBody()
        {
            string bodyContent = "";

            return bodyContent;
        }

    }
}
