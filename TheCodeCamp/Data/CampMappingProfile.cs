﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(t => t.Speaker, opt => opt.Ignore())
                .ForMember(t => t.Camp, opt => opt.Ignore());

            CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, opt => opt.MapFrom(
                    m => m.Location.VenueName))
                .ReverseMap();


        }
    }
}