using Beerlibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RestserviceBeer.Manager
{
    public class BeerManager
    {
        private static int _NextID = 1;
        private static readonly List<Beer> Data = new List<Beer>
        {
            new Beer {Id = _NextID++, Name = "Tuborg", Abv = 8, Pris =37},
            new Beer {Id = _NextID++, Name = "Carlsberg", Abv = 5, Pris =27}
        };

        public IEnumerable<Beer> GetAll()
        {
            return new List<Beer>(Data);
        }

        public Beer GetByID(int id)
        {
            return Data.Find(Beer => Beer.Id == id);
        }

        public Beer Add(Beer newBeer)
        {
            newBeer.Id = _NextID++;
            Data.Add(newBeer);
            return newBeer;
        }

        public Beer Update(int id, Beer updates)
        {
            Beer beer = Data.Find(book1 => book1.Id == id);
            if (beer == null) return null;
            beer.Name = updates.Name;
            beer.Pris = updates.Pris;
                return beer;
        }

        public Beer Delete(int Id)
        {
            Beer beer = Data.Find(book1 => book1.Id == Id);
            if (beer == null) return null;
            Data.Remove(beer);
            return beer;
        }
    }
}
