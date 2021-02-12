using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace VehicleTrackingSystem.Application.Mapper
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
