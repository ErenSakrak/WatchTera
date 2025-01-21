using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatchTera.Business.Abstract;
using WatchTera.DTO.DTOs.AboutDtos;
using WatchTera.DTO.DTOs.AddressDtos;
using WatchTera.Entity.Entities;

namespace WatchTera.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController(IGenericService<Address> _addressService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _addressService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _addressService.TGetById(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _addressService.TDelete(id);
            return Ok("Adres Alanı Silindi.");
        }

        [HttpPost]
        public IActionResult Create(CreateAddressDto createAddressDto)
        {
            var newValue = _mapper.Map<Address>(createAddressDto);
            _addressService.TCreate(newValue);
            return Ok("Yeni Adres Alanı Oluşturuldu.");
        }

        [HttpPut]
        public IActionResult Update(UpdateAddressDto updateAddressDto)
        {
            var value = _mapper.Map<Address>(updateAddressDto);
            _addressService.TUpdate(value);
            return Ok("Adres Alanı Güncellendi.");
        }
    }
}
