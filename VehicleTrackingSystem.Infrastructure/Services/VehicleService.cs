using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VehicleTrackingSystem.Application.Common.Models;

using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;
using Microsoft.Extensions.Hosting;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Application.Handlers.Vehicle;
using Emarket.Application.Constants;
using VehicleTrackingSystem.Application.Common.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly AppDbContext _context;
        private readonly IHostEnvironment _hostEnvironment;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IMapper _mapper;
        public VehicleService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime, IHostEnvironment hostEnvironment)

        {

            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _context = context ?? throw new ArgumentNullException(nameof(_context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _context = context ?? throw new ArgumentNullException(nameof(_context));
            _hostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(_hostEnvironment));


        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async  Task<ResultModel> CreateVehicle(VehicleVm vehicleVm)
        {
            

            try
            {
               

                var entity = new  Vehicle
                {

                    VehicleName = vehicleVm.VehicleName,
                    ChassisNo = vehicleVm.ChassisNo,
                    ModelNo = vehicleVm.ModelNo,
                    ColorCode = vehicleVm.ColorCode,
                    ProductionYear = vehicleVm.ProductionYear,
                    RegistrationYear = vehicleVm.RegistrationYear,
                    ManufacturerId = vehicleVm.ManufacturerId,
                    EngineCC = vehicleVm.EngineCC,
                    CountryCode = vehicleVm.CountryCode,
                    Remarks = vehicleVm.Remarks,
                    ActiveStatus = vehicleVm.ActiveStatus,

                    UpdateBy = _currentUserService.UserId,
                    UpdateDate = _dateTime.Now,
                    CreatedBy = _currentUserService.UserId,
                    CreateDate = _dateTime.Now,

                };

                await _context.VEHICLE.AddAsync(entity);
                

                await _context.SaveChangesAsync();

                var data = new Owner
                {

                    OwnerName = vehicleVm.Owner.OwnerName,
                    VehicleId = entity.VehicleId,
                    JoiningDate = vehicleVm.Owner.JoiningDate,
                    DateOfBirth = vehicleVm.Owner.DateOfBirth,
                    NidNo = vehicleVm.Owner.NidNo,
                    GenderId = vehicleVm.Owner.GenderId,
                    PresentAddress = vehicleVm.Owner.PresentAddress,
                    PermanentAddress = vehicleVm.Owner.PermanentAddress,
                    CountryCode = vehicleVm.Owner.CountryCode,
                    Email = vehicleVm.Owner.Email,
                    Deleted = false

                };

                await _context.OWNER.AddAsync(data);
                await _context.SaveChangesAsync();




                return new ResultModel
                {
                    Result = true,
                    Message = NotificationConfig.InsertSuccessMessage($"{vehicleVm.VehicleName}"),
                    Id = entity.VehicleId.ToString()
                };

 

                

            }
            catch(Exception)
            {
                return new ResultModel { Result = false, Message = NotificationConfig.InsertErrorMessage($"{vehicleVm.VehicleName}") };

            }





        }
        public async Task<ResultModel> UpdateVehicle(UpdateVehicleVm updateVehicleVm)
        {
           
            try
            {

                if (updateVehicleVm.VehicleId > 0)
                {


                    var entity = new Vehicle
                    {

                        VehicleId = updateVehicleVm.VehicleId,
                        VehicleName = updateVehicleVm.VehicleName,
                        ChassisNo = updateVehicleVm.ChassisNo,
                        ModelNo = updateVehicleVm.ModelNo,
                        ColorCode = updateVehicleVm.ColorCode,
                        ProductionYear = updateVehicleVm.ProductionYear,
                        RegistrationYear = updateVehicleVm.RegistrationYear,
                        ManufacturerId = updateVehicleVm.ManufacturerId,
                        EngineCC = updateVehicleVm.EngineCC,
                        CountryCode = updateVehicleVm.CountryCode,
                        Remarks = updateVehicleVm.Remarks,
                        ActiveStatus = updateVehicleVm.ActiveStatus,

                        UpdateBy = _currentUserService.UserId,
                        UpdateDate = _dateTime.Now,
                        CreatedBy = _currentUserService.UserId,
                        CreateDate = _dateTime.Now,

                    };

                    _context.VEHICLE.Update(entity);

                    var data = new Owner
                    {
                        OwnerId = updateVehicleVm.Owner.OwnerId,
                        OwnerName = updateVehicleVm.Owner.OwnerName,
                        VehicleId = entity.VehicleId,
                        JoiningDate = updateVehicleVm.Owner.JoiningDate,
                        DateOfBirth = updateVehicleVm.Owner.DateOfBirth,
                        NidNo = updateVehicleVm.Owner.NidNo,
                        GenderId = updateVehicleVm.Owner.GenderId,
                        PresentAddress = updateVehicleVm.Owner.PresentAddress,
                        PermanentAddress = updateVehicleVm.Owner.PermanentAddress,
                        CountryCode = updateVehicleVm.Owner.CountryCode,
                        Email = updateVehicleVm.Owner.Email,
                        Deleted = false

                    };

                    _context.OWNER.Update(data);
                    await _context.SaveChangesAsync();


                    return new ResultModel
                    {
                        Result = true,
                        Message = NotificationConfig.UpdateSuccessMessage($"{updateVehicleVm.VehicleName}"),
                        Id = entity.VehicleId.ToString()
                    };

                }
                else
                {

                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{updateVehicleVm.VehicleName} information") };

                }
 

            }
            catch (Exception)
            {
                return new ResultModel { Result = false, Message = NotificationConfig.UpdateErrorMessage($"{updateVehicleVm.VehicleName}") };

            }





        }
        public async Task<ResultModel> DeleteVehicle(int id)
        {
            if (id > 0)
            {
                var entity = await _context.VEHICLE.FirstOrDefaultAsync(x => x.VehicleId == id && x.Deleted == false);
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

       
        public async Task<IList<VehicleReturnVm>> GetVehicle()
        {
            var entity = await _context.VEHICLE.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<VehicleReturnVm>>(entity);
            return data;
        }

        public async Task<VehicleReturnVm> GetVehicleById(int id)
        {
            var entity = await _context.VEHICLE.FirstOrDefaultAsync(x => x.VehicleId == id && !x.Deleted);
            var data = _mapper.Map<VehicleReturnVm>(entity);
            return data;
        }
    }
}
