using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choix_Restaurant.Models
{
    public interface IDal : IDisposable
    {
        void CreerRestaurant(string Nom, string Telephone);
        List<Resto> ObtientTousLesRestaurants();
    }
}
