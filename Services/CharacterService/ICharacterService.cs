using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //responde con una task de srvice response del tipo list characters
        Task <ServiceResponse<List<GetCharacterResponseDto>>> GetAllCharacters();
        Task <ServiceResponse<GetCharacterResponseDto>> GetCharacterById(int id);
        Task <ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter);
        Task <ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
        Task <ServiceResponse<List<GetCharacterResponseDto>>> DeleteCharacter(int id);
        
    }
}