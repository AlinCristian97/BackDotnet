using BackDotnet.Application.Interfaces;
using BackDotnet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace BackDotnet.Infrastructure.Repositories
{
    public class FruitRepositoryInMemory : IFruitRepository
    {
        private List<Fruit> fruits = new List<Fruit>
        {
            new Fruit()
            {
                Id = 1,
                Name = "Apple",
                Description = "Good for teeth",
                HealthScore = 10
            },
            new Fruit()
            {
                Id = 2,
                Name = "Banana",
                Description = "Very tasty",
                HealthScore = 9
            },
            new Fruit()
            {
                Id = 3,
                Name = "Watermelon",
                Description = "Juicy!!!",
                HealthScore = 9
            }
        };

        public Task<int> Add(Fruit entity)
        {
            entity.Id = fruits.Last().Id + 1;
            fruits.Add(entity);
            return Task.FromResult(entity.Id);
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Fruit> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Fruit>> GetAll()
        {
            return Task.FromResult<IEnumerable<Fruit>>(fruits);
        }

        public Task<int> Update(Fruit entity)
        {
            throw new NotImplementedException();
        }
    }
}
