using Module.Repository.Model.Address;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Address;

namespace Module.Service.Validation.Address
{
    public class AddressValidation : BaseCrudValidation<AddressModel>, IAddressValidation
    {
        public override void ValidateInsert(AddressModel model)
        {
            base.ValidateInsert(model);

            this.ZipCode_AddressMustHaveZipCode(model);
            this.Neighborhood_AddressMustHaveNeighborhood(model);
            this.Street_AddressMustHaveStreet(model);
            this.CountyId_AddressMustHaveCountyIdInformed(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(AddressModel model)
        {
            base.ValidateUpdate(model);

            this.ZipCode_AddressMustHaveZipCode(model);
            this.Neighborhood_AddressMustHaveNeighborhood(model);
            this.Street_AddressMustHaveStreet(model);
            this.CountyId_AddressMustHaveCountyIdInformed(model);

            this.OnValidated();
        }

        private void ZipCode_AddressMustHaveZipCode(AddressModel model)
        {
            var message = "Endereço deve ter o cep informado";

            if (string.IsNullOrEmpty(model.ZipCode))
                this.summary.AddError("AddressModel", message);
        }

        private void Neighborhood_AddressMustHaveNeighborhood(AddressModel model)
        {
            var message = "Endereço deve ter o cep informado";

            if (string.IsNullOrEmpty(model.Neighborhood))
                this.summary.AddError("AddressModel", message);
        }

        private void Street_AddressMustHaveStreet(AddressModel model)
        {
            var message = "Endereço deve ter o cep informado";

            if (string.IsNullOrEmpty(model.Street))
                this.summary.AddError("AddressModel", message);
        }

        private void CountyId_AddressMustHaveCountyIdInformed(AddressModel model)
        {
            var message = "Endereço deve ter o cep informado";

            if (model.CountyId <= 0)
                this.summary.AddError("AddressModel", message);
        }
    }
}