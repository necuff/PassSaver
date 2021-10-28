using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PassSaver
{
    class Database
    {
        public string Name { get; set; }

        public ObservableCollection<Group> groups;

        public Database()
        {
            groups = new ObservableCollection<Group>();
        }
    }
}
