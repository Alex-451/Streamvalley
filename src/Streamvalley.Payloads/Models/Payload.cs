using System;

namespace Streamvalley.Payloads.Models
{
    public class Payload
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Action Method { get; set; }
        public bool IsActive { get; set; }
    }
}