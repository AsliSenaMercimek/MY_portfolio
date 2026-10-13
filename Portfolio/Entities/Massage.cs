namespace Portfolio.Entities
{
    public class Massage
    {
        public int MassageId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; } 

        public string MassageDetail { get; set; } 

        public DateTime SendDate { get; set; }

        public bool ısRead { get; set; }



    }
}
