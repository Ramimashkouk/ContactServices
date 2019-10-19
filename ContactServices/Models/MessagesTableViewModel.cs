using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactServices.Models
{
    public class MessagesTableViewModel
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }

        public MessagesTopicsViewModel MessagesTopics { get; set; }
    }
}