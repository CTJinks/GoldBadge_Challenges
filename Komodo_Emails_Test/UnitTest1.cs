using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Emails_Test
{
    public enum PersonType { Potential, Current, Past }
    [TestClass]
    public class People
    {
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
        public string Email
        {
            get
            {
                if (PersonType == PersonType.Potential)
                {
                    return "We currently have the lowest rates on Helicopter Insurance!";
                }
                else if (PersonType == PersonType.Current)
                {
                    return "Thank you for your worl with us! We appreciate your loyalty. Here's a coupon.";
                }
                else if (PersonType == PersonType.Past)
                {
                    return "It's been a long time since we've heard from you, we want you back";
                }
                else
                {
                    return "error";
                }
            }
        }
        public People(string name, PersonType personType)
        {
            Name = name;
            PersonType = personType;
        }
    }
}
