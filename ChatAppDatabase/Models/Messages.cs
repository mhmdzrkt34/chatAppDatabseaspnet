namespace ChatAppDatabase.Models
{
    public class Messages
    {
        public Guid id { get; set; }

        public string message { get; set; }

        public string type { get; set; }


        public virtual User sender {  get; set; }




        public Guid sender_id {  get; set; }


        public virtual User reciever { get; set; }

        public Guid reciever_id {  get; set; }



        public Messages()
        {
            id = Guid.NewGuid();
        }


    }
}
