using Microsoft.AspNetCore.Http;
using Module.Dto;
using Module.Dto.Advert;
using Module.Dto.Advert.AdvertHouse;
using Module.Dto.Sell;
using Module.Service.Base;
using Module.Service.Interface;
using Module.Service.Interface.Advert;
using Module.Service.Interface.Sell;
using Module.Service.Validation.Interface.Advert.AdvertHouse;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Module.Service.Advert.AdvertHouse
{
    public class AdvertHouseManagerViewService : BaseService, IAdvertHouseManagerViewService
    {
        public IAdvertHouseManagerValidation AdvertHouseManagerValidation { get; set; }
        public ISellService SellService { get; set; }
        public IAdvertHouseService AdvertHouseService { get; set; }
        public IContactRequestService ContactRequestService { get; set; }
        public IAdvertGoalService AdvertGoalService { get; set; }
        public IAdvertResourceService AdvertResourceService { get; set; }
        public IHouseTypeService HouseTypeService { get; set; }
        public IPictureService PictureService { get; set; }
        public IAdvertImageService AdvertImageService { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public AdvertHouseManagerViewService(IHttpContextAccessor httpContextAccessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
        }

        public void CreateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            var advertHouseDto = this.ObjectConverterFactory.ConvertTo<AdvertHouseDto>(createAdvertHouseRequestDto);
            var advertiserId = this.HttpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Sid).Value;
            advertHouseDto.AdvertiserId = Guid.Parse(advertiserId);
            var advertHouseId = this.AdvertHouseService.Insert(advertHouseDto);
            this.OpenTransaction();
            this.InsertResourceList(advertHouseId, createAdvertHouseRequestDto.AdvertResourceList);
            this.InsertAdvertHousePictureList(advertHouseId, createAdvertHouseRequestDto.AdvertHousePictureList);

            this.Commit();
        }

        public AdvertHouseViewDto GetAdvertView()
        {
            var result = new AdvertHouseViewDto()
            {
                AdvertGoalSelectList = this.AdvertGoalService.GetSelection(),
                HouseTypeSelectList = this.HouseTypeService.GetSelection()
            };

            return result;
        }

        public AdvertHouseViewDto GetAdvertView(Guid id)
        {
            var result = new AdvertHouseViewDto()
            {
                AdvertGoalSelectList = this.AdvertGoalService.GetSelection(),
                HouseTypeSelectList = this.HouseTypeService.GetSelection(),
                AdvertHouse = this.AdvertHouseService.GetById(id)
            };

            return result;
        }

        public void SellAdvert(Guid advertHouseId, Guid contactRequestId)
        {
            this.AdvertHouseManagerValidation.ValidateAdvertSellRequest(advertHouseId, contactRequestId);

            var advertHouseDto = this.AdvertHouseService.GetById(advertHouseId);
            var sellRequestDto = new SellDto()
            {
                AdvertHouseId = advertHouseId,
                ContactRequestId = contactRequestId,
                Price = advertHouseDto.Price,
                Description = advertHouseDto.Description
            };

            this.SellService.Insert(sellRequestDto);
        }

        public void SendContactRequest(ContactRequestDto contactRequest)
        {
            this.ContactRequestService.Insert(contactRequest);
        }

        public void UpdateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            var advertHouseDto = this.ObjectConverterFactory.ConvertTo<AdvertHouseDto>(createAdvertHouseRequestDto);
            this.OpenTransaction();
            this.AdvertHouseService.Update(advertHouseDto);
            this.UpdateResourceList(createAdvertHouseRequestDto.AdvertResourceList);
            this.UpdateAdvertHousePictureList(createAdvertHouseRequestDto.AdvertHousePictureList);

            this.Commit();
        }

        private void InsertAdvertHousePictureList(Guid advertHouseId, IEnumerable<AdvertImageDto> advertHousePictureList)
        {
            foreach (var picture in advertHousePictureList)
            {
                var imageId = this.PictureService.Insert(new PictureDto()
                {
                    Array = picture.ImageArray,
                    Name = Guid.NewGuid().ToString()
                });
                picture.ImageId = imageId;
                picture.AdvertHouseId = advertHouseId;
                this.AdvertImageService.Insert(picture);
            }
        }

        private void InsertResourceList(Guid advertHouseId, IEnumerable<AdvertResourceDto> advertResourceList)
        {
            foreach (var resource in advertResourceList)
            {
                resource.AdvertHouseId = advertHouseId;
                this.AdvertResourceService.Insert(resource);
            }
        }

        private void UpdateResourceList(IEnumerable<AdvertResourceDto> advertResourceList)
        {
            foreach (var resource in advertResourceList)
            {
                this.AdvertResourceService.Update(resource);
            }
        }

        private void UpdateAdvertHousePictureList(IEnumerable<AdvertImageDto> advertHousePictureList)
        {
            foreach (var picture in advertHousePictureList)
            {
                this.PictureService.Delete(picture.ImageId);
                var imageId = this.PictureService.Insert(new PictureDto()
                {
                    Array = picture.ImageArray,
                    Name = Guid.NewGuid().ToString()
                });
                picture.ImageId = imageId;
                this.AdvertImageService.Update(picture);
            }
        }
    }
}