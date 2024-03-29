﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarajRestfulApp.Models
{
    public class CarRequestDto
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public byte MinDrivingLicenseAge { get; set; }
        public byte MinCustomerAge { get; set; }
        public int MaxKmPerDay { get; set; }
        public int CarKM { get; set; }
        public byte AirBagCount { get; set; }
        public short CarTrunkVolume { get; set; }
        public byte CarSeatCount { get; set; }
        public decimal CarPriceForRent { get; set; }
        public string CarPhotoURL { get; set; }
    }
}
