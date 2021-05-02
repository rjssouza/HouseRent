using Module.Repository.Interface.Base;
using Module.Repository.Model.Base;
using Module.Service.Interface.Base;

namespace Module.Service.Base
{
    public abstract class BaseEntityService<TModel, TDto, TKeyType, TRepository> : BaseService, IBaseEntityService<TDto, TKeyType>
        where TModel : BaseModel
        where TRepository : IBaseCrudRepository<TModel>
    {
        public abstract TRepository CrudRepository { get; set; }

        /// <summary>
        /// Remove o entidade efetuando as validações necessarias
        /// </summary>
        /// <param name="id">Identificador do anuncio de locação de imoveis</param>
        public virtual void Delete(TKeyType id)
        {
            var addressModel = this.CrudRepository.GetEntityById(id);
            this.OpenTransaction();
            this.CrudRepository.Delete(addressModel);

            this.Commit();
        }

        /// <summary>
        /// Obtem pelo identificador
        /// </summary>
        /// <param name="id">Identificador da entidade</param>
        /// <returns>Objeto de dados da entidade</returns>
        public virtual TDto GetById(TKeyType id)
        {
            var model = this.CrudRepository.GetEntityById<TKeyType>(id);
            var resultado = this.ObjectConverterFactory.ConvertTo<TDto>(model);

            return resultado;
        }

        /// <summary>
        /// Insere os dados da entidade efetuando as validaões necessarias
        /// </summary>
        /// <param name="dtoObject">Objeto dto </param>
        public virtual void Insert(TDto dtoObject)
        {
            var model = this.ObjectConverterFactory.ConvertTo<TModel>(dtoObject);
            this.OpenTransaction();
            this.CrudRepository.Insert(model);

            this.Commit();
        }

        /// <summary>
        /// Atualiza as informações da entidade efetuando as validações necessarias
        /// </summary>
        /// <param name="dtoObject">Objeto dto </param>
        public virtual void Update(TDto dtoObject)
        {
            var model = this.ObjectConverterFactory.ConvertTo<TModel>(dtoObject);
            this.OpenTransaction();
            this.CrudRepository.Update(model);

            this.Commit();
        }
    }
}