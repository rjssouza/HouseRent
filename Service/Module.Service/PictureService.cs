using Module.Dto;
using Module.Repository.Interface;
using Module.Repository.Model;
using Module.Service.Base;
using Module.Service.Interface;
using System;

namespace Module.Service
{
    public class PictureService : BaseService, IPictureService
    {
        public IPictureRepository PictureRepository { get; set; }

        public void Delete(Guid id)
        {
            var pictureModel = this.PictureRepository.GetEntityById(id);
            this.OpenTransaction();
            this.PictureRepository.Delete(pictureModel);

            this.Commit();
        }

        public PictureDto GetById(Guid id)
        {
            var pictureModel = this.PictureRepository.GetEntityById(id);
            var result = this.ObjectConverterFactory.ConvertTo<PictureDto>(pictureModel);

            return result;
        }

        public Guid Insert(PictureDto pictureDto)
        {
            var pictureModel = this.ObjectConverterFactory.ConvertTo<PictureModel>(pictureDto);
            this.OpenTransaction();
            var result = this.PictureRepository.Insert(pictureModel);
            this.Commit();

            return result;
        }

        public void Update(PictureDto pictureDto)
        {
            var pictureModel = this.ObjectConverterFactory.ConvertTo<PictureModel>(pictureDto);
            this.OpenTransaction();
            this.PictureRepository.Update(pictureModel);

            this.Commit();
        }
    }
}