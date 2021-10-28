using System;
using System.Collections.Generic;
using System.Text;

namespace PassSaver
{
    class Entry
    {         
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Notes { get; set; }


        public Entry Create(string title, string userName, string password, string url, string notes) 
            => new Entry { Title = title, UserName = userName, Password = password, URL = url, Notes = notes };

        public Entry Edit(Entry entry, string title, string userName, string password, string url, string notes)
        {
            entry.Title = title;
            entry.UserName = userName;
            entry.Password = password;
            entry.URL = url;
            entry.Notes = notes;

            return entry;
        }
    }    
}
