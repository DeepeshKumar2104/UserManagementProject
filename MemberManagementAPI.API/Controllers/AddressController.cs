using Microsoft.AspNetCore.Mvc;
using MemberManagementAPI.Application.DTOs;
using MemberManagementAPI.Application.Interfaces;

namespace MemberManagementAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress([FromBody] AddressDTO addressDTO)
        {
            var result = await _addressService.AddAddress(addressDTO);
            return Ok(result);
        }
    }
}
