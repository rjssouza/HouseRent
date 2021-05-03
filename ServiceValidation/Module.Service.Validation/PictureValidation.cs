using Module.Repository.Model;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface;

namespace Module.Service.Validation
{
    public class PictureValidation : BaseCrudValidation<PictureModel>, IPictureValidation
    {
        public override void ValidateInsert(PictureModel model)
        {
            base.ValidateInsert(model);
            this.Length_PictureMustHaveLenghtAboveZero(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(PictureModel model)
        {
            base.ValidateUpdate(model);
            this.Length_PictureMustHaveLenghtAboveZero(model);

            this.OnValidated();
        }

        private void Length_PictureMustHaveLenghtAboveZero(PictureModel model)
        {
            var message = "A imagem deve ser informada";
            if (model.Array == null || model.Array.Length <= 0)
                this.summary.AddError("Picture", message);
        }
    }
}