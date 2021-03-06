﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.ComponentModel;
using SafeSendersOptimizer;

namespace SenderListOptimizer
{
    /// <summary>
    /// Maintain and manage sender lists
    /// </summary>
    public class SendersList
    {
        private string filePath;
        private string publicDomainFilePath;

        public SortableBindingList<sender> Senders = new SortableBindingList<sender>();

        /// <summary>
        /// Constructor for SenderList
        /// </summary>
        /// <param name="senderfilepath">File path to the file containing the senders email addresses</param>
        /// <param name="publicdomainfilepath">File path to the file containing known public email domains</param>
        public SendersList(string senderfilepath, string publicdomainfilepath)
        {
            filePath = senderfilepath;
            publicDomainFilePath = publicdomainfilepath; 
            parseSendersList(); 
        }

        /// <summary>
        /// Read sender list from file and create a list of sender objects (Senders)
        /// </summary>
        private void parseSendersList()
        {
            PublicDomainList publicDomains = new PublicDomainList(publicDomainFilePath);

            string [] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] address = new string[3];

                // safe or blocked domains can be specified with or without the @
                if (line.Contains('@'))
                    address = line.Split('@');
                else
                {
                    // no @ sign, the line is a domain
                    address[0] = string.Empty;
                    address[1] = line;  
                }
                Senders.Add(new sender(address[0], address[1], publicDomains.IsPublic(address[1])));
            }               
        }


        // for unit testing
        public void ShowParsedList()
        {
            foreach (sender s in Senders)
                Console.WriteLine("-->LOCAL: " + s.local + "\t DOMAIN:" + s.domain + "\t Public:" + s.publicd.ToString());
        }
    }

    /// <summary>
    /// Sender
    /// </summary>
    public class sender
    {
        public string local;
        public string domain;
        public bool publicd;
        public sender (string localpart, string domainpart, bool publicdomain)
        {
            local = localpart;
            domain = domainpart;
            publicd = publicdomain;
        }

        public string Email
        {
            get { return local +"@" + domain; }
        }

        public string Local
        { 
         get {return local; }
         set { local = value; }
        }

        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public bool PublicD
        {
            get { return publicd; }                                 
            set { publicd = value; }
        }
    }
}
