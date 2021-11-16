using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace kcalc
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

        List<char> clist = new List<char>();
        List<char> en = new List<char>();
        public string Read()
        {
            string token = null;
            //List<char> clist = new List<char>();
            //List<char> en = new List<char>();
            char c = (char)Reader.Read();
            while ((char)Reader.Read() != '\n')
            {
                //char c = (char)Reader.Read();
            
            
            //List<char> clist = new List<char>();
            //List<char> en = new List<char>();
            //clist.Add(c);

            
                //if (en!=null)
                //{
                //    token = string.Join("", en);
                //    return token;
                //}
                //else
                if (c == '\r')
                {
                    token = c.ToString();
                    return token;

                }
                else if (c == '\t')
                {
                    if (clist.Count != 0)
                    {
                        token = string.Join("", clist);
                        return token;
                    }
                    else
                        token = c.ToString();
                    return token;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (clist.Count != 0)
                    {
                        en.Add(c);
                        token = string.Join("", clist);
                        return token;
                    }
                    else
                        token = c.ToString();
                    return token;
                }
                else
                if (clist.Count != 0)
                {
                    clist.Add(c);
                    token = string.Join("", clist);
                   
                    //token = string.Join("", clist);
                    return token;
                }
                
                    clist.Add(c);
                
            }
            clist.Add(c);
            return token;
        }
   }
}
