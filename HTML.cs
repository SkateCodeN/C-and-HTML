using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Create_Website
{
    class HTML
    {
        string[] html_header = new string[] { "html", "head", "title" };
        string ending_Tag = "/";
        StreamWriter sw;
        Stream reader;
        
           
        public HTML (string title, string file_path)
        {

            sw = new StreamWriter(file_path, true);
            CreateHeader(title);
        }
            
        public void CreateHeader(string title)
        {
            // Output to a file with header
            foreach(string header in html_header)
            {
                //First we wrap it around the element <>
               string wrapped = WrapAround(header);
                sw.WriteLine(wrapped);
                if (header == "title")
                {
                    sw.Write(title + WrapAround(endingWrap(header)));
                }
               
            }
            sw.Close();

        }

        public string WrapAround(string tag)
        {
            string wrap = "<" + tag + ">";

            return wrap;
        }


        public string endingWrap (string tag)
        {
            string ending = ending_Tag + tag;

            return ending;
        }

        public void WriteBody(string pic_path)
        {
            

        }
    }
}
