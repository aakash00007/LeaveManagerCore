using AutoMapper;
using LeaveManagement.Data.Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequestDto, LeaveRequest>();
            CreateMap<UserRegisterationDto, User>();
            CreateMap<ApprovalDto, Approval>();
        }
    }
}
