using System;
using System.Collections.Generic;
using Components.SOLID.Interfaces.SingleResponsibility;
using SOLID.SingleResponsibility.DataTransferObjects;

namespace SOLID.SingleResponsibility.ContactParsers
{
    internal class CSVContactParser : IContactParser
    {
        public IList<IContactDTO> Parse(string csvData)
        {
            IList<IContactDTO> contacts = new List<IContactDTO>();
            string[] lines = csvData.Split(new string[] { @"\r\l" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var contact = new ContactDTO
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Email = columns[2]
                };
                contacts.Add(contact);
            }

            return contacts;
        }
    }
}
