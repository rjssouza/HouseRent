using Module.Dto.Advertiser;
using Module.Service.Interface.Base;

namespace Module.Service.Interface.Advertiser
{
    public interface IAdvertiserManagerService : IBaseService
    {
        void Register(AdvertiserUserDto advertiserUserDto);
    }
}