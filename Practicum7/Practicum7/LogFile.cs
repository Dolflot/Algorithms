using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum7
{
    public class LogFile : INawDictionary
    {
        protected LogFileLink Head { get; set; }

        public virtual void Insert(string key, NAW value)
        {
            if (key == null)
            {
                throw new ArgumentNullException();
            }
            LogFileLink temp = new LogFileLink(key, value, Head);
            Head = temp;
        }

        public virtual NAW Find(string key)
        {
            if (key == null)
            {
                return null;
            }
            else
            {
                LogFileLink temp = Head; 
                while (temp != null)
                {
                    if (temp.Key == key)
                    {
                        return temp.Value;
                    }
                    temp = temp.Next;
                }
                return null;
            }
        }

        public virtual NAW Delete(string key)
        {
            if (key == null)
            {
                return null;
            }
            else if (Find(key) != null)
            {
                LogFileLink temp = Head;
                NAW tempnaw;
                if (temp.Key == key)
                {
                    tempnaw = temp.Value;
                    Head = temp.Next;
                    return tempnaw;
                }

                while (temp != null)
                {
                    if (temp.Next.Key == key)
                    {
                        tempnaw = temp.Next.Value;
                        temp.Next = temp.Next.Next;
                        return tempnaw;
                    }
                    temp = temp.Next;
                }
                return null;
            }

            return null;
        }
    }

}
