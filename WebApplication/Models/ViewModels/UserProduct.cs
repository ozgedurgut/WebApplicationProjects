using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models.ViewModels
{
    public class UserProduct
    {
        public Product Product { get; set; }
        public UserProduct User { get; set; }

        public static implicit operator UserProduct(User v)
        {
            throw new NotImplementedException();
        }
    }
}
