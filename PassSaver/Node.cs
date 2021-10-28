using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PassSaver
{
    public class Node
    {
        public string Name { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }

        
    }
}
