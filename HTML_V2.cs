using System;

using System.IO;

// For Git hub purposes this is v2 4-24-19
namespace Create_Website
{
    class HTML
    {
        string[] html_header = new string[] {  "html", "head" , "body"};
        string ending_Tag = "/";
        StreamWriter sw;
        StreamReader reader;
        public string dtcTXT;

        // Contructor that takes in 
        //  * title of the webpage
        //  * Path to create it in
        //  * [add] Path of Content File
        public HTML (string title, string file_path, string dtc_file_Path)
        {

            sw = new StreamWriter(file_path, true);
            dtcTXT = dtc_file_Path;
            CreateHeader(title);
            
        }
            
         // This creates the first lines of the typical HTML code
        public void CreateHeader(string title)
        {
            // Output to a file with header
            foreach(string header in html_header)
            {
                //First we wrap it around the element <>
               string wrapped = WrapAround(header);

                sw.WriteLine(wrapped);
                /*
                if (header == "title")
                {
                    sw.Write(title + WrapAround(endingWrap(header)));
                    
                }
                */
               if (header == "body")
                {
                    reader = new StreamReader(dtcTXT);
                    string reader_Content = "";
                    while (!reader.EndOfStream)
                    {
                        reader_Content = reader.ReadLine();
                        sw.Write("<p>" + reader_Content + "</p>" + Environment.NewLine);
                    }

                    reader.Close();
                    
                    continue;
                }


            }

            for (int i = 2; i >= 0; i-- )
            {
                sw.WriteLine(WrapAround(endingWrap(html_header[i])));
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

      
    }
}
