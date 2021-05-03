using Module.Repository.Model.Sell;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Sell;

namespace Module.Service.Validation.Sell
{
    public class SellValidation : BaseCrudValidation<SellModel>, ISellValidation
    {
        public override void ValidateInsert(SellModel model)
        {
            base.ValidateInsert(model);
            this.Price_SellMustHavePrice(model);
            this.Description_SellMustHaveDescription(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(SellModel model)
        {
            base.ValidateUpdate(model);
            this.Price_SellMustHavePrice(model);
            this.Description_SellMustHaveDescription(model);

            this.OnValidated();
        }

        private void Price_SellMustHavePrice(SellModel model)
        {
            var message = "É obrigatório informar o preço desta venda";
            if (model.Price <= 0)
                this.summary.AddError("SellModel", message);
        }

        private void Description_SellMustHaveDescription(SellModel model)
        {
            var message = "É obrigatório informar a descrição desta venda";
            if (string.IsNullOrEmpty(model.Description))
                this.summary.AddError("SellModel", message);
        }
    }
}