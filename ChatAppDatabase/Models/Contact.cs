namespace ChatAppDatabase.Models
{
    public class Contact
    {

        public Guid id { get; set; }

        public string name { get; set; }

        public string user_email { get; set; }


        public string reciever_email { get; set; }


        public virtual User user { get; set; }


        public Guid user_id {  get; set; }

        public Guid reciever_id { get; set; }


        public Contact()
        {

            id= Guid.NewGuid();
        }
        


        
    }
}
