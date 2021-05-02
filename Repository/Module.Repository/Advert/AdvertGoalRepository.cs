﻿using Module.Dto.Base;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using System.Collections.Generic;

namespace Module.Repository.Advert
{
    public class AdvertGoalRepository : BaseCrudRepository<AdvertGoalModel>, IAdvertGoalRepository
    {
        public AdvertGoalRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        public IEnumerable<GenericGuidSelectDto> GetSelection()
        {
            throw new System.NotImplementedException();
        }
    }
}