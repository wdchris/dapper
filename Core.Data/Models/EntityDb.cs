using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Core.Models;

namespace Core.Data.Models
{
    internal class EntityDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal static class EntityDbExtensions
    {
        public static Entity Map(this EntityDb entity)
        {
            return Mapper.Map<Entity>(entity);
        }

        public static IEnumerable<Entity> Map(this IEnumerable<EntityDb> entities)
        {
            return entities.Select(a => a.Map());
        }
    }
}
