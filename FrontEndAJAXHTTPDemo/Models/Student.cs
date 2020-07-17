using System;

namespace FrontEndAJAXHTTPDemo.Models
{
    public class Student
    {
        public int SID { get; set; }
        public string SName { get; set; }
        public DateTime DTDOB { get; set; }
        public string[] ARKnownLanguages { get; set; }
    }
}
