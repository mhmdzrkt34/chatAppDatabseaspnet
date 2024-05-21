using System.ComponentModel.DataAnnotations;

namespace ChatAppDatabase.Models
{
    public class User
    {

        [Key]
        public Guid id { get; set; }

        public string email { get; set; }

        public string userName { get; set; }


        public string password { get; set; }

        public virtual ICollection<Messages> SendedMessages {  get; set; }

        public virtual ICollection<Messages> RecievedMessages { get; set; }

        public virtual ICollection<Contact> contacts { get; set; }  


        public User()
        {

            id= Guid.NewGuid();
        }


    }
}
