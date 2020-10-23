using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            //Map object Camp(entity to Model)
            //Map VenueName from Object to Venue property of Model
            CreateMap<Camp, CampModel>()
      .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName))
      .ReverseMap();
            CreateMap<Talk, TalkModel>().ReverseMap()
                .ForMember(t => t.Speaker, opt => opt.Ignore())
                .ForMember(t => t.Camp, opt => opt.Ignore());
            CreateMap<Speaker, SpeakerModel>().ReverseMap();
        }
    }
}