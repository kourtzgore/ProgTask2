using ProgTask2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.Web.Routing;

namespace ProgTask2
{
    public partial class OrderHistory : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Order> GetOrderHistory(
         [QueryString("id")] int? orderId)
        {
            var _db = new ProgTask2.Models.ProductContext();
            IQueryable<Order> query = _db.Orders;

            if (orderId.HasValue && orderId > 0)
            {
                query = query.Where(p => p.OrderId == orderId);
            }

            //if (!String.IsNullOrEmpty(categoryName))
            //{
            //    query = query.Where(p =>
            //        String.Compare(p.Category.CategoryName,
            //        categoryName) == 0);
            //}
            return query;
        }
    }
}