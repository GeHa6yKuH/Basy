using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public List<Color> Colors { get; set; }
        public DateTime CreationDate { get; set; }
        public int InitialVersionId { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
