﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDtos>();
            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            
            Mapper.CreateMap<CustomerDtos, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movies>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}