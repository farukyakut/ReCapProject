﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        //kiralama tarihi
        public DateTime RentDate { get; set; }
        //Teslim Tarihi
        public DateTime? ReturnDate { get; set; }
    }
}
