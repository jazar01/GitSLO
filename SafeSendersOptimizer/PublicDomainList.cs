using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SenderListOptimizer
{
    class PublicDomainList
    {
        public List<string> Domains = new List<string>();
        private string filepath;
        public PublicDomainList(string pdomainpath)
        {
            if (string.IsNullOrEmpty(pdomainpath))
                filepath = null;
            else
                { 
                filepath = pdomainpath;
                Domains = File.ReadAllLines(filepath).ToList<string>();
                removeAts();
                }
        }

        /// <summary>
        /// Consructor with no parameters creates an empty list
        /// </summary>
        public PublicDomainList()
        {
            filepath = null;
        }

        /// <summary>
        /// remove the @signs
        /// </summary>
        private void removeAts()
        {
            for (int i = 0; i < Domains.Count(); i++)
            {
                int atPos = Domains[i].IndexOf('@');

                if (atPos == 0)   // @ at position 0, deleted it
                    Domains[i].Remove(0, 1);
                else if (atPos > 0)   // @ somewhere else, remove the line, not valid domain
                    Domains.RemoveAt(i);
            }
        }

        /// <summary>
        /// determines if domain is on the public domain list
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public bool IsPublic(string domain)
        {
            if (string.IsNullOrEmpty(filepath))
                return false;
            else
                return Domains.Contains(domain);
        }
    }
}
