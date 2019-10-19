using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactServices.Models
{
    public class ContactsDetailsViewModel
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public IList<MessagesTopicsViewModel> MessagesTopics { get; set; }
    }
}