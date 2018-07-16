using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Models
{
    public class ServiceModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}
