﻿using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;

namespace Module.Repository.Advert
{
    public class AdvertResourceRepository : BaseCrudRepository<AdvertResourceModel>, IAdvertResourceRepository
    {
        public AdvertResourceRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}