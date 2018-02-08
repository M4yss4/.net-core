using System.Collections.Generic;
using System.Linq;
using core_projects.Models;
 
namespace core_projects.Repositories
{
    public class AdressRepository
    {
        private static Dictionary<int, Adress> AdressS 
                                = new Dictionary<int, Adress>();
 
        static AdressRepository()
        {
            AdressS.Add(1, new Adress
            {
                Id = 1,
                Source = "A",
                Destination = "B",
                Moyen = "X",
                Prix = 2
            });
            AdressS.Add(2, new Adress
            {
                Id = 1,
                Source = "A",
                Destination = "B",
                Moyen = "Z",
                Prix = 5
            });
        }
 
        public static Adress GetById(int id)
        {
            return AdressS[id];
        }
 
        public static List<Adress> GetAll()
        {
            return AdressS.Values.ToList();
        }
 
        public static int GetCount()
        {
            return AdressS.Count();
        }
 
        public static void Remove()
        {
            if (AdressS.Keys.Any())
            {
                AdressS.Remove(AdressS.Keys.Last());
            }
        }
 
        public static string Save(Adress Adress)
        {
            var result = "";
            if (AdressS.ContainsKey(Adress.Id))
            {
                result = "Updated Adress with id=" + Adress.Id;
            }
            else
            {
                result = "Added Adress with id=" + Adress.Id;
            }
            AdressS.Add(Adress.Id, Adress);
            return result;
        }
    }
}