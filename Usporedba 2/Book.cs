using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usporedba_2
{
    internal class Book
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Image: {Image}, Name: {Name}";
        }

    }

}
