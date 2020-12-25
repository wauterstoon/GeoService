﻿using GeoService.Domain.Managers;
using GeoService.Domain.Models;
using GeoService.EF.DataAccess;
using GeoService.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoService.EF.Mappers
{
    internal static class CountryMapper
    {
        internal static CountryDB CountryToDBModel(Country country)
        {
            CountryDB countryDB = new CountryDB();
            countryDB.Id = country.Id;
            countryDB.Name = country.Name;
            countryDB.Population = country.Population;
            countryDB.Surface = country.Surface;
            countryDB.ContinentId = country.Continent.Id;
            return countryDB;
        }

        internal static Country CountryDBToBusinessModel(CountryDB countryDB)
        {
            Country country = new Country();
            country.Id = countryDB.Id;
            country.Name = countryDB.Name;
            country.Population = countryDB.Population;
            country.Surface = countryDB.Surface;
            country.Continent = ContinentMapper.ContinentDBWithoutCountriesToBusinessModel(countryDB.Continent);
            return country;
        }
        internal static List<Country> CountryDBListToBusinessModel(List<CountryDB> countryDBs)
        {
            List<Country> countries = new List<Country>();
            foreach(CountryDB countryDB in countryDBs)
            {
                Country country = CountryDBToBusinessModel(countryDB);
                countries.Add(country);
            }
            return countries;
        }
    }
}