using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactDataAccess;
using ContactServices.Models;
using System.Reflection;
using System.Text;



namespace ContactServices.Controllers
{
    public class ContactsController : ApiController
    {
        public IHttpActionResult GetContacts()
        {
            IList<MessagesTopicsViewModel> MessagesTopics = null;

            using (var ctx = new MessagesDatabaseEntities())
            {
                MessagesTopics = ctx.MessagesTopics.Include("MessagesTable")
                            .Select(s => new MessagesTopicsViewModel()
                            {
                                ContactId = s.ContactId,
                                MessageId = s.MessageId,
                                Topic = s.Topic
                            }).ToList<MessagesTopicsViewModel>();
            }

            if (MessagesTopics.Count == 0)
            {
                return NotFound();
            }

            return Ok(MessagesTopics);
        }



        public IHttpActionResult PostNewContact(ContactsDetailsViewModel Contact)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new MessagesDatabaseEntities())
            {
                ctx.ContactsDetails.Add(new ContactsDetails()
                {
                    ContactId = Contact.ContactId,
                    Name = Contact.Name,
                    Email = Contact.Email,
                    Phone = Contact.Phone
                });
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
