
using System.Collections.Generic;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        public bool Validate(string xml)
        {
            double open = xml.Split('<').Length - 1;
            double openClose = xml.Split('/').Length - 1;
            double close = xml.Split('>').Length - 1;

            if (open/2 == openClose && open == close)
            {
                List<string> cut = new List<string>();

                while (xml.Length > 0)
                {
                    int openBeginning = xml.IndexOf("<");
                    int closeIndex = xml.IndexOf(">");
                    int openCloseIndex = xml.IndexOf("</");

                    string temp = "";

                    if (openBeginning != -1 && openBeginning == 0)
                    {
                        temp = xml.Substring(openBeginning, closeIndex + 1);
                        xml = xml.Remove(openBeginning, closeIndex + 1);
                    }
                    else if (openBeginning != -1 && openBeginning != 0)
                    {
                        temp = xml.Substring(0, openBeginning);
                        xml = xml.Remove(0, openBeginning);
                    }
                    else if (openBeginning != -1 && openCloseIndex != 0)
                    {
                        temp = xml.Substring(0, openCloseIndex);
                        xml = xml.Remove(0, openCloseIndex + 1);
                    }
                    else if (openBeginning != -1 && openCloseIndex == 0)
                    {
                        temp = xml.Substring(openCloseIndex, closeIndex + 1);
                        xml = xml.Remove(openCloseIndex, closeIndex);
                    }
                    cut.Add(temp);
                }

                int openInt = 0;
                string open1 = "";
                string open2 = "";

                foreach (string a in cut)
                {
                    
                    if (a.IndexOf("<") != -1)
                    {
                        openInt++;

                        if(a.IndexOf(" ") != -1)
                        {
                            return false;
                        }

                        if (openInt == 1)
                        {
                            open1 = a;
                        }
                        else if (openInt == 2)
                        {
                            open2 = a;
                        }
                        else if (openInt == 3)
                        {
                            if (a.Remove(1, 1).Equals(open2))
                            {
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (openInt == 4)
                        {
                            if (a.Remove(1, 1).Equals(open1))
                            {
                            }
                            else
                            {
                                return false;
                            }
                        }

                    }
                }
                return true;
            }
            return false;
        }
    }
}


