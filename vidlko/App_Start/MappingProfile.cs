using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using vidlko.DTOs;
using vidlko.Models;

namespace vidlko.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API -> Outbound
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            // API <- Inbound
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}