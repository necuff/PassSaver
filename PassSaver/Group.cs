using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PassSaver
{
    public class Group
    {
        public string Name { get; set; }

        public ObservableCollection<Group> Nodes { get; set; }

        public static ObservableCollection<Group> GetCollectionGroups(string dbName)
        {
            return new ObservableCollection<Group>
            {
                new Group
                {
                    Name = dbName,
                    Nodes = new ObservableCollection<Group>
                    {
                        new Group {Name="General" },
                        new Group {Name="Games" },
                        new Group {Name="Системы сообщений" },
                        new Group {Name="Мама/Папа" },
                        new Group
                        {
                            Name ="Recucle Bin",
                            Nodes = new ObservableCollection<Group>
                            {
                                new Group {Name="Windows" },
                                new Group {Name="Network" },
                                new Group {Name="eMail" },
                                new Group {Name="Homebanking" },
                            }
                        },
                        new Group {Name="Работа" },
                        new Group {Name="Internet" }
                    }
                }
            };
        }
    }
}
