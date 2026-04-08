namespace WekaWeka.Models
{
    public class Customer
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }   // REQUIRED
        public string Email { get; set; }

        public string IdNumber { get; set; }
        public string IdType { get; set; }  // national_id, passport, etc.

        public string NodeId { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int is_checkedout { get; set; }   // 0/1
        public string checkout_id { get; set; }

        public int IsDeleted { get; set; }
    }
}