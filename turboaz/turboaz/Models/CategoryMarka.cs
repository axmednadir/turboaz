using System;
using System.Collections.Generic;

#nullable disable

namespace turboaz.Models
{
    public partial class CategoryMarka
    {
        public CategoryMarka()
        {
            Cars = new HashSet<Car>();
        }

        public int CategoryMarkaId { get; set; }
        public string CategoryMarkaName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
