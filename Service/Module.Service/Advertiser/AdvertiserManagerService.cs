using Module.Dto;
using Module.Dto.Advertiser;
using Module.Dto.User.Security;
using Module.Service.Base;
using Module.Service.Interface;
using Module.Service.Interface.Advertiser;
using Module.Service.Interface.Security;
using Module.Service.Validation.Interface.Advertiser;
using System;

namespace Module.Service.Advertiser
{
    public class AdvertiserManagerService : BaseService, IAdvertiserManagerService
    {
        public IAdvertiserService AdvertiserService { get; set; }
        public IUserLoginService UserLoginService { get; set; }
        public IContactService ContactService { get; set; }
        public IAdvertiserManagerValidation AdvertiserManagerValidation { get; set; }
        public IPictureService PictureService { get; set; }

        public void Register(AdvertiserUserDto advertiserUserDto)
        {
            this.AdvertiserManagerValidation.ValidateRequest(advertiserUserDto);
            var advertiserDto = this.ObjectConverterFactory.ConvertTo<AdvertiserDto>(advertiserUserDto);
            this.OpenTransaction();
            advertiserDto.UserId = this.SaveLogin(advertiserUserDto);
            advertiserDto.PictureId = this.SavePicture(advertiserUserDto);
            advertiserDto.ContactId = this.SaveContactInfo(advertiserUserDto);
            this.AdvertiserService.Insert(advertiserDto);

            this.Commit();
        }

        private Guid SaveLogin(AdvertiserUserDto advertiserUserDto)
        {
            var userLoginId = this.UserLoginService.Insert(new UserLoginDto()
            {
                Login = advertiserUserDto.ContactInfo.Mail,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(advertiserUserDto.Password),
            });

            return userLoginId;
        }

        private Guid? SavePicture(AdvertiserUserDto advertiserUserDto)
        {
            if (advertiserUserDto.Picture == null || advertiserUserDto.Picture.Length <= 0)
                return null;

            var pictureId = this.PictureService.Insert(new PictureDto()
            {
                Array = advertiserUserDto.Picture,
                Name = Guid.NewGuid().ToString()
            });

            return pictureId;
        }

        private Guid SaveContactInfo(AdvertiserUserDto advertiserUserDto)
        {
            if (advertiserUserDto.ContactInfo == null)
                return Guid.Empty;

            var contactId = this.ContactService.Insert(advertiserUserDto.ContactInfo);

            return contactId;
        }
    }
}