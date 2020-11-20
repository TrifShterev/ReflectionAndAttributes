using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationAttributes
{
   public class Person
    {
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;

        }
        [MyRange(12, 90)]
      //  [Range(12,90)] it is C# integrated attribute
        public int Age { get; set; }
        [MyRequired]
        //[Required]it is C# integrated attribute
        public string FullName { get; set; }
    }
}
