﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<Rental, NewRentalDto>();

            Mapper.CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie >().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MembershipTypeDto, MembershipType>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<GenreDto, Genre>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<NewRentalDto, Rental>().ForMember(m => m.Id, opt => opt.Ignore());

        }
    }
}