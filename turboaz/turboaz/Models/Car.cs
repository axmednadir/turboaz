using System;
using System.Collections.Generic;

#nullable disable

namespace turboaz.Models
{
    public partial class Car
    {
        public Car()
        {
            Photos = new HashSet<Photo>();
        }

        public int CarId { get; set; }
        public int? CarQiy { get; set; }
        public string CarModel { get; set; }
        public int? CarIl { get; set; }
        public string CarSeher { get; set; }
        public string CarUsername { get; set; }
        public string CarDesciption { get; set; }
        public int? CarcategoryMarkaId { get; set; }
        public string CarTestiq { get; set; }
        public int? CarUserId { get; set; }

        public virtual CategoryMarka CarcategoryMarka { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
