using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace GitTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        public int ProviderId { get; set; }
        public Provider? Provider { get; set; }
    }
}
