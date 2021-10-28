using System;
using System.Collections.Generic;
using System.Text;

namespace PassSaver
{
    class Group
    {
        public string Name { get; set; }

        public List<Entry> entries = new List<Entry>();
    }
}
