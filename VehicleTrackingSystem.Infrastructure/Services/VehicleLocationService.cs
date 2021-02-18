using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Handlers.VehicleLocation;
using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class VehicleLocationService : IVehicleLocationService
    {
        private readonly AppDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IMapper _mapper;
        public VehicleLocationService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime)

        {

            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _context = context ?? throw new ArgumentNullException(nameof(_context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _context = context ?? throw new ArgumentNullException(nameof(_context));


        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<ResultModel> CreateVehicleLocation(VehicleLocationVm vehicleLocationVm)
        {
            try
            {
                var entity = new Domain.Entities.VehicleLocation
                {

                    Latitude = vehicleLocationVm.Latitude,
                    Longitude = vehicleLocationVm.Longitude,
                    TripDate = vehicleLocationVm.TripDate,
                    TripTime = vehicleLocationVm.TripTime,
                    Speed = vehicleLocationVm.Speed,
                    Altitude = vehicleLocationVm.Altitude,
                    VehicleId = vehicleLocationVm.VehicleId

                };


                await _context.VEHICLE_LOCATION.AddAsync(entity);
                await _context.SaveChangesAsync();
                return new ResultModel
                {
                    Result = true,
                    Message = NotificationConfig.InsertSuccessMessage($"{vehicleLocationVm.VehicleId}"),
                    Id = entity.VehicleLocationId.ToString()
                };

            }

            catch(Exception)
            {

                return new ResultModel { Result = false, Message = NotificationConfig.InsertErrorMessage($"{vehicleLocationVm.VehicleId}") };

            }
           

        }


        public async Task<ResultModel> UpdateVehicleLocation(UpdateVehicleLocationVm updateVehicleLocationVm)
        {
            try
            {
                var VehicleLocationId = await _context.VEHICLE_LOCATION.FirstOrDefaultAsync(x => x.VehicleLocationId == updateVehicleLocationVm.VehicleLocationId && !x.Deleted);
                if (VehicleLocationId != null)
                {
                    var entity = new Domain.Entities.VehicleLocation
                    {

                        Latitude = updateVehicleLocationVm.Latitude,
                        Longitude = updateVehicleLocationVm.Longitude,
                        TripDate = updateVehicleLocationVm.TripDate,
                        TripTime = updateVehicleLocationVm.TripTime,
                        Speed = updateVehicleLocationVm.Speed,
                        Altitude = updateVehicleLocationVm.Altitude,
                        VehicleId = updateVehicleLocationVm.VehicleId

                    };


                    _context.VEHICLE_LOCATION.Update(entity);
                    await _context.SaveChangesAsync();
                    return new ResultModel { Result = true, Message = NotificationConfig.UpdateSuccessMessage($"{updateVehicleLocationVm.VehicleId}"), Id = entity.VehicleLocationId.ToString() };

                }
                else
                {
                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{updateVehicleLocationVm.VehicleId} information") };
                }


            }

            catch (Exception)
            {

                return new ResultModel { Result = false, Message = NotificationConfig.UpdateErrorMessage($"{updateVehicleLocationVm.VehicleId}") };

            }
        }


        public async Task<ResultModel> DeleteVehicleLocation(int id)
        {
            if (id > 0)
            {
                var entity = await _context.VEHICLE_LOCATION.FirstOrDefaultAsync(x => x.VehicleId == id && x.Deleted == false);
                if (entity != null)
                {
                    entity.Deleted = true;
                    await _context.SaveChangesAsync();
                    return new ResultModel { Result = true, Message = NotificationConfig.DeleteSuccessMessage($"{entity.VehicleId}") };
                }
                else
                {
                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundError };
                }
            }
            else
            {
                return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{id}") };
            }
        }

        public async Task<IList<VehicleLocationReturnVm>> GetVehicleLocation()
        {
            var entity = await _context.VEHICLE_LOCATION.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<VehicleLocationReturnVm>>(entity);
            return data;
        }

        public async Task<VehicleLocationReturnVm> GetVehicleLocationById(int id)
        {
            var entity = await _context.VEHICLE_LOCATION.FirstOrDefaultAsync(x => x.VehicleLocationId == id && !x.Deleted);
            var data = _mapper.Map<VehicleLocationReturnVm>(entity);
            return data;
        }

    }
}
