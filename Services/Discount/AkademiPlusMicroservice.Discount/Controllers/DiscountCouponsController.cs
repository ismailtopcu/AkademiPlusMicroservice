using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Discount.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Discount.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDtos createDiscountCouponDtos)
        {
            await _discountCouponService.CreateDiscountCoupon(createDiscountCouponDtos);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCoupon(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetListDiscountCoupon()
        {
            var values =await _discountCouponService.GetListAll();
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDtos updateDiscountCouponDtos)
        {
            await _discountCouponService.UpdateDiscountCoupon(updateDiscountCouponDtos);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCoupon(int id)
        {
           var value = await _discountCouponService.GetDiscountById(id);
            return Ok(value);
        }

    }
}
