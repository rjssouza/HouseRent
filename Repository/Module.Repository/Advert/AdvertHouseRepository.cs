using Dapper;
using Module.Dto.Advert;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using System.Collections.Generic;
using System.Text;

namespace Module.Repository.Advert
{
    public class AdvertHouseRepository : BaseCrudRepository<AdvertHouseModel>, IAdvertHouseRepository
    {
        public AdvertHouseRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        /// <summary>
        /// Obtém lista de imóveis anunciados por filtro
        /// </summary>
        /// <param name="advertHouseFilter">Filtro lista de anúncios</param>
        /// <returns>Lista de imóveis anunciados por filtro</returns>
        public IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter)
        {
            var sql = new StringBuilder(@"select
											ROW_NUMBER() OVER ( ORDER BY advert_house.id ) AS RowNum,
											advertiser.name as AdvertiserName,
											advert_house.title as Title,
											advert_house.description as Description,
											house_type.name as HouseTypeName,
 											address.street as FormattedAddress,
											goal.name as AdvertGoalName,
											advert_house.price as Price,
											advert_house.qtd_bathrooms as QtdBathrooms,
											advert_house.qtd_bedrooms as QtdBedromms,
											advert_house.qtd_rooms as QtdRooms,
											advert_house.qtd_garage as QtdSuite,
											advert_house.qtd_garage as QtdGarage,
											(
											select
												top 1 i.[array]
											from
												advert_image advert_image
											inner join [image] i on
												i.id = advert_image.image_id
											order by
												advert_image.ordem) AdvertFirstPicture
										from
											advert_house advert_house
										inner join advertiser advertiser on
											advert_house.advertiser_id = advertiser.id
										inner join goal goal on
											goal.id = advert_house.goal_id
										inner join house_type house_type on
											house_type.id = advert_house.house_type_id
										inner join status status on
											status.id = advert_house.status_id
										inner join address address on
											address.id = advert_house.address_id
										where 1 = 1 ");
            var param = new DynamicParameters();

            if (!string.IsNullOrEmpty(advertHouseFilter.Keyword))
            {
                sql.AppendLine(" and (advert_house.description like @keyword or advertiser.name like @keyword or advert_house.description like @keyword) ");
                param.Add("keyword", advertHouseFilter.Keyword);
            }

            if (advertHouseFilter.HouseTypeId.HasValue)
            {
                sql.AppendLine(" and ( advert_house.house_type_id = @houseTypeId) ");
                param.Add("houseTypeId", advertHouseFilter.HouseTypeId);
            }

            if (advertHouseFilter.LimitMustBeUsed)
            {
                sql.AppendLine(" and (RowNum >= @limitStart AND RowNum < @limitMax) ");

                param.Add("limitStart", advertHouseFilter.LimitStart);
                param.Add("limitMax", advertHouseFilter.LimitMax);
            }

            if (!string.IsNullOrEmpty(advertHouseFilter.OrderBy))
            {
                sql.AppendLine($" order by {advertHouseFilter.OrderBy} ");
            }

            var result = this.Select<AdvertHouseListItemDto>(sql.ToString(), param);

            return result;
        }
    }
}