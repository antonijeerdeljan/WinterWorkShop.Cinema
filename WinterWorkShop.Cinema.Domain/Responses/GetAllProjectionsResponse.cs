﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterWorkShop.Cinema.Domain.Responses
{
    public class GetAllProjectionsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public int BrojSale { get; set; }
        public DateTime DateTime { get; set; }

        public string Descripton { get; set; }
    }
}
