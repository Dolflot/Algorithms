using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
        protected LogFile[] logFiles;
        private int count;

        public NawDictionary(int size)
        {
            Size = size;
            logFiles = new LogFile[size];
            for (int i = 0; i < logFiles.Length; ++i)
                logFiles[i] = new LogFile();
        }

        protected int KeyToIndex(string key)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }
            return Math.Abs(key.GetHashCode() % Size);
        }



        public void Insert(string key, NAW value)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }

            logFiles[KeyToIndex(key)].Insert(key, value);
            count++;
        }

        public NAW Find(string key)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }
            if (logFiles[KeyToIndex(key)] == null)
            {
                return null;
            }
            if (logFiles[KeyToIndex(key)].Find(key) == null)
            {
                return null;
            }
            return logFiles[KeyToIndex(key)].Find(key);
        }

        public NAW Delete(string key)
        {
            if (key.Equals(null))
            {
                throw new ArgumentNullException();
            }
            if (Find(key) == null)
            {
                return null;
            }
            NAW naw = logFiles[KeyToIndex(key)].Find(key);
            logFiles[KeyToIndex(key)].Delete(key);
            count--;
            return naw;
        }


        public int Count
        {
            get
            {
                return count;
            }
        }

        public double LoadFactor
        {
            get
            {
                return count / Size;
            }
        }
    }
}
