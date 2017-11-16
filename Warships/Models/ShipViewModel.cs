﻿using System.ComponentModel;

namespace Warships.Models
{
    public class ShipViewModel
    {
        public int? ShipId { get; set; }

        [DisplayName("Ship Name")]
        public string ShipName { get; set; }

        [DisplayName("Ship Type")]
        public string ShipTypeName { get; set; }

        [DisplayName("Ship Type")]
        public int ShipTypeId { get; set; }

        [DisplayName("Ship Name")]
        public string FullName => ShipName ;
    }
}