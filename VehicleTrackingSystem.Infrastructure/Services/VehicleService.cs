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
            //for Image save in a specific path

            try
            {
                string imagePath = "";
                bool isSaved = false;
                byte[] imageInBytes = new byte[] { };

                if (vehicleVm.ImageName != null || vehicleVm.ImageName != "null")
                {
                    if (vehicleVm.ImageName.Contains(","))
                    {
                        vehicleVm.ImageName = vehicleVm.ImageName.Substring(vehicleVm.ImageName.IndexOf(",") + 1);
                    }
                    imageInBytes = Convert.FromBase64String(vehicleVm.ImageName);
                    vehicleVm.ImageName = string.Format(@"{0}.png", Guid.NewGuid().ToString().Replace("-", ""));
                }


                var entity = new Domain.Entities.Vehicle
                {

                    VehicleId = vehicleVm.VehicleId,
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

                await _context.Vehicle.AddAsync(entity);
                

                await _context.SaveChangesAsync();

                var data = new Owner
                {
                    OwnerId = vehicleVm.Owner.OwnerId,
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

                await _context.Owner.AddAsync(data);
                await _context.SaveChangesAsync();




                return new ResultModel
                {
                    Result = true,
                    Message = NotificationConfig.InsertSuccessMessage($"{vehicleVm.VehicleName}"),
                    Id = entity.VehicleId.ToString()
                };

                if ( vehicleVm.ImageName != null)
                {
                   
                        imagePath = ImageDirectory.CheckDirectory(_hostEnvironment, PathConstant.PRIMARY_IMAGE_PATH);

                        isSaved = await ImageDirectory.SaveImageInDirectory(imageInBytes, imagePath, vehicleVm.ImageName);
                        if (!isSaved)
                        {
                            return new ResultModel { Result = false, Message = NotificationConfig.NotFoundError };


                            //return Result.Failure(new List<string> { "Image Not Saved!!" });
                        }

                     


                }

                return null;

            }
            catch(Exception e)
            {
                return new ResultModel { Result = false, Message = NotificationConfig.NotFoundError };
               // return Result.Failure(new List<string> { "Error Occured!!" });
            }
           


           
           
        }

        public async Task<ResultModel> DeleteVehicle(int id)
        {
            if (id > 0)
            {
                var entity = await _context.Vehicle.FirstOrDefaultAsync(x => x.VehicleId == id && x.Deleted == false);
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
            var entity = await _context.Vehicle.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<VehicleReturnVm>>(entity);
            return data;
        }

        public async Task<VehicleReturnVm> GetVehicleById(int id)
        {
            var entity = await _context.Vehicle.FirstOrDefaultAsync(x => x.VehicleId == id && !x.Deleted);
            var data = _mapper.Map<VehicleReturnVm>(entity);
            return data;
        }
    }
}
