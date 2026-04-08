public class LuggageCheckout
{
    public string id { get; set; }

    public string luggage_id { get; set; }
    public string customer_id { get; set; }

    public string collector_name { get; set; }
    public string collector_phone { get; set; }
    public string collector_id_number { get; set; }

    public string relationship_to_customer { get; set; }

    public string remarks { get; set; }

    public string checked_out_by_user_id { get; set; }
    public string node_id { get; set; }

    public string checked_out_at { get; set; }
}