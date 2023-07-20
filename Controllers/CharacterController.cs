using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    { 
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService )
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> Get(){
            return Ok(await _characterService.GetAllCharacters());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> GetSingle(int id){
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost("AddCharacter")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut("UpdateCharacter")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {

            var response = await _characterService.UpdateCharacter(updateCharacter);
            if(response.Data is null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}