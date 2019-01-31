﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16125296_OnlineStore.ViewModels
{
    public class BasketSummaryViewModel
    {
        public int NumberOfItems { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}