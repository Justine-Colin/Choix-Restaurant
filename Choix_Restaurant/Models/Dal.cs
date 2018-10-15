using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Choix_Restaurant.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void CreerRestaurant(string nom, string telephone)
        {
            bdd.Restos.Add(new Resto {Nom = nom, Telephone = telephone});
            bdd.SaveChanges();
        }

        public List<Resto> ObtientTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }

        public void ModifierRestaurant(int id, string nom, string telephone)
        {
            Resto RestoTrouve = bdd.Restos.FirstOrDefault(resto => resto.Id == id);
            if (RestoTrouve != null)
            {
                RestoTrouve.Nom = nom;
                RestoTrouve.Telephone = telephone;
                bdd.SaveChanges();
            }
        }
        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}