using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerCard : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public int CardId { get; set; }
    }
}
