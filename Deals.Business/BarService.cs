using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deals.Data.Models;
using Deals.Models.Models;

namespace Deals.Business
{
    public class BarService
    {
        public Bar GetBar()
        {
            using (var context = new BarDealsContext())
            {
                return context.Bars.FirstOrDefault();
            }
        }
    }
}
