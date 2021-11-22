
using System;
using System.IO;
namespace Lab7
{
    public class Author 
    {
        private string name;
        private char gender;
        private string email;

        public Author(string name, char gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public override string ToString()
        {
            return "Name = " + name + ", Gender = " + gender + ", Email = " + email;
        }
    }
}