using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactServices.Models
{
    public class MessagesTopicsViewModel
    {
        public int MessageId { get; set; }
        public int ContactId { get; set; }
        public string Topic { get; set; }

        public ContactsDetailsViewModel Contact { get; set; }
        public MessagesTableViewModel ContactMessage { get; set; }
    }
}