using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace jemsunlucky
{
    public class Expreader
    {
        

            public StreamReader Reader { get; set; }

            private Expreader()
            {
            }

            public Expreader(StreamReader reader)
            {
                Reader = reader;
            }

        public string Read()
        {
            string token = null;
            token = Reader.Read();
            List<string> clist = new List<string>();
            List<string> en = new List<string>();
         while(token!=null)
         {
                if (token == "\r\n")
                {


                }
                else
                if (token == "\t")
                {
                    if (clist.Count != 0)
                    {
                        token = string.Join("", clist);
                        return token;
                    }
                    token.Trim('\t');
                    return token;
                }
                else
                if (token == "+" || token == "-" || token == "*" || token == "/")
                {
                    if (clist.Count != 0)
                    {
                        en.Add(token);
                        token = string.Join("", clist);
                        return token;
                    } 
                    return token;
                }
                else
                if (clist.Count != 0)
                {
                    token = string.Join("", clist);
                    //return token;
                }
                return token;

            }
            clist.Add(token);
            token = string.Join("", clist);
            return token;

        }
    }
}
