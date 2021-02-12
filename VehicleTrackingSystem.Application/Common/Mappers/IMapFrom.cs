using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace VehicleTrackingSystem.Application.Common.Mappers
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
