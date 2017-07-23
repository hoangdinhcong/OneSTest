using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneSTest.Models
{
    public class ViewModelCategoryProduct
    {
        public ICollection<category> categories { set; get; }
        public ICollection<product> products { set; get; }
    }
}