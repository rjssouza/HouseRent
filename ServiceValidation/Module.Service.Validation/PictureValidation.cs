using Module.Repository.Model;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface;

namespace Module.Service.Validation
{
    public class PictureValidation : BaseCrudValidation<PictureModel>, IPictureValidation
    {
    }
}