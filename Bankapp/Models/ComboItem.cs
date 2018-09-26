using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankapp.Models
{
    public class ComboItem
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
