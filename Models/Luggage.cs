public class Luggage
{
    public string id { get; set; }

    public string customer_id { get; set; }

    public string description { get; set; }
    public double? weight { get; set; }

    public string tag_number { get; set; }
    public string status { get; set; }

    public string origin { get; set; }
    public string current_location { get; set; }

    public int is_fragile { get; set; }

    public string node_id { get; set; }

    public string created_at { get; set; }
    public string updated_at { get; set; }
    public int is_checkedout { get; set; }   
    public string checkout_id { get; set; }

    public int is_deleted { get; set; }
}