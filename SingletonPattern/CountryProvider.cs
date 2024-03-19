﻿using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CountryProvider
    {
        private static CountryProvider instance = null;
        public static CountryProvider Instance
        {
            get => instance ?? (instance = new CountryProvider());
        }
        private new List<Country> Countries { get; set; }
        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();
            Countries =
                new List<Country>()
                {
                        new Country(){ Name = "Türkiye" },
                        new Country(){ Name = "Birleşik Krallık" }
                };
        }
        public async Task<List<Country>> GetCountries()
        {
            return Countries;
        }
    }
}
