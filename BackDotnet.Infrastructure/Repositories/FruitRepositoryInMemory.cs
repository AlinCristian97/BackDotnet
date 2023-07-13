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
            Fruit fruitToDelete = fruits.FirstOrDefault(fruit => fruit.Id == id);

            if (fruitToDelete != null)
            {
                fruits.Remove(fruitToDelete);
                return Task.FromResult(fruitToDelete.Id);
            }

            throw new InvalidOperationException($"Fruit with Id {id} does not exist.");
        }

        public Task<Fruit> Get(int id)
        {
            Fruit searchedFruit = fruits.FirstOrDefault(fruit => fruit.Id == id);

            if (searchedFruit != null)
            {
                fruits.Remove(searchedFruit);
                return Task.FromResult(searchedFruit);
            }

            throw new InvalidOperationException($"Fruit with Id {id} could not be found.");
        }

        public Task<IEnumerable<Fruit>> GetAll()
        {
            return Task.FromResult<IEnumerable<Fruit>>(fruits);
        }

        public Task<int> Update(Fruit entity)
        {
            Fruit fruitToUpdate = fruits.FirstOrDefault(entity);

            if (fruitToUpdate != null)
            {
                fruitToUpdate = entity;
                return Task.FromResult(fruitToUpdate.Id);
            }

            throw new InvalidOperationException($"The fruit you are trying to update does not exist.");
        }
    }
}
