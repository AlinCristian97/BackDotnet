using BackDotnet.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDotnet.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IFruitRepository Fruits { get; }


        public UnitOfWork(IFruitRepository fruitRepository)
        {
            Fruits = fruitRepository;
        }
    }
}
