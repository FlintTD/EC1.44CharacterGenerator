using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EC1._44CharacterGenerator.Shared
{
    public class DropdownItem
    {
        public string Name { get; set; }
        public List<string> Content { get; set; }
        public bool Selected { get; set; }

        public DropdownItem (string name, List<string> content)
        {
            Name = name;
            Content = content;
        }

        public DropdownItem(string name)
        {
            Name = name;
            Content = new List<string>();
        }
    }
}
