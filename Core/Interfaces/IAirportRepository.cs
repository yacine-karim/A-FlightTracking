﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IAirportRepository
    {
        IEnumerable<Airport> LoadFake();
    }
}
