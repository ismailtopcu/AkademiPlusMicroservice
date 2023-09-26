using AkademiPlusMicroservice.Discount.Dtos;
using AkademiPlusMicroservice.Discount.Models;
using AutoMapper;

namespace AkademiPlusMicroservice.Discount.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<DiscountCoupon,ResultDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon,CreateDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon,UpdateDiscountCouponDtos>().ReverseMap();
        }
    }
}
