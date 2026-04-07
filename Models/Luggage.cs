namespace WekaWeka.Models
{
    public class Luggage
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string Description { get; set; }   // e.g. "Black suitcase"
        public double? Weight { get; set; }

        public string TagNumber { get; set; }     // unique tracking code
        public string Status { get; set; }        // checked_in, in_transit, delivered

        public string Origin { get; set; }
        public string Destination { get; set; }

        public string NodeId { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public int IsDeleted { get; set; }
    }
}