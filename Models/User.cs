using System;
using System.Collections.Generic;
using System.Text;

namespace WekaWeka.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string password_hash { get; set; }
        public string NodeId { get; set; }
        public int Is_active { get; set; }
    }
}
