namespace Module.Service.Interface.Base
{
    public interface IBaseReadEntityService<TDto, TKeyType> : IBaseService
    {
        /// <summary>
        /// Obtem pelo identificador
        /// </summary>
        /// <param name="id">Identificador da entidade</param>
        /// <returns>Objeto de dados da entidade</returns>
        TDto GetById(TKeyType id);
    }
}