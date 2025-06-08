using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basy.Models
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public List<Template> Templates { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
