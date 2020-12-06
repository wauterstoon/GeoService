﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeoService.Domain.Exceptions
{
    public class CountryException : Exception
    {
        public CountryException(string message) : base(message)
        {
        }

        public CountryException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
