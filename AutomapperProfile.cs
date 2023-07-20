using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>();
            CreateMap<AddCharacterRequestDto, Character>();
        }
    }
}