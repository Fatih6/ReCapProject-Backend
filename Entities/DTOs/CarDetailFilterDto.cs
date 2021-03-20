using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailFilterDto : IFilterDto
    {
        public int? CarId { get; set; }
        public int? BrandId { get; set; }
        public int? ColorId { get; set; }
        public int? ModelYear { get; set; }
        public string CarName { get; set; }
    }
}
