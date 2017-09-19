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
            //ForMemeber to ignore the key that should not be modified
            Mapper.CreateMap<Customer, CustomerDto>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movie, MovieDto>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}