using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //responde con una task de srvice response del tipo list characters
        Task <ServiceResponse<List<Character>>> GetAllCharacters();
        Task <ServiceResponse<Character>> GetCharacterById(int id);
        Task <ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
        
    }
}