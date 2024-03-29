﻿using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class PlaneRepository : IPlaneRepository
    {
        List<Plane> Planes = new List<Plane>
            {
                new Plane
                {
                    Id = 1,
                    Consumption = 0,
                    Name = "Boeing 727"
                }
            };

        public IEnumerable<Plane> LoadFake()
        {
            return Planes;
        }
    }
}
