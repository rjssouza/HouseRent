using Module.Dto.Advertiser;
using Module.Service.Validation.Interface.Base;

namespace Module.Service.Validation.Interface.Advertiser
{
    public interface IAdvertiserManagerValidation : IBaseValidation
    {
        void ValidateRequest(AdvertiserUserDto advertiserUserDto);
    }
}