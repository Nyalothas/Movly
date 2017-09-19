using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movly.Models;
using Movly.Dtos;

namespace Movly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

        }
    }
}