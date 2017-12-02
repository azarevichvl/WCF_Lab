using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace BooksWCFServiceLib
{
    [DataContract]
    class Book
    {
        public Book ( string name, string info, int year, bool ava) {
            this.Name = name;
            this.Info = info;
            this.Year = year;
            this.Availabe = ava;
        }

        [DataMember]
        public string Name {get; set;}
        [DataMember]
        public string Info {get; set;}
        [DataMember]
        public int Year {get; set;}
        [DataMember]
        public bool Availabe{get; set;}
    }
}
