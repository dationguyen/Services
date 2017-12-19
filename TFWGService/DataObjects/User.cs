using Microsoft.Azure.Mobile.Server;
using System;

namespace TFWGService.DataObjects
{
    public class User:EntityData
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Mobile { get; set; }
        public DateTime DoB { get; set; }
        public bool Maried { get; set; }
        public int Dependents { get; set; }

    }
}