using BackDotnet.Application.Interfaces;
using BackDotnet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDotnet.Application.Services
{
    public class FruitService
    {
        private readonly IFruitRepository _fruitRepository;

        public FruitService(IFruitRepository fruitRepository)
        {
            _fruitRepository = fruitRepository;           
        }

        public async Task<IEnumerable<Fruit>> GetFruits()
        {
            var fruits = await _fruitRepository.GetAll();

            return fruits;
        }
    }
}
