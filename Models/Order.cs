using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProgTask2.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public int ProductId { get; set; }

        public int? CategoryId { get; set; }

    }
}