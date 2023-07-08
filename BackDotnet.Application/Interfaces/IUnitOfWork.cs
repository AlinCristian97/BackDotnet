using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDotnet.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IFruitRepository Fruits { get; }
    }
}
