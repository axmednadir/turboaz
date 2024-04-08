using System;
using System.Collections.Generic;

#nullable disable

namespace turboaz.Models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public int? PhotoCarId { get; set; }

        public virtual Car PhotoCar { get; set; }
    }
}
