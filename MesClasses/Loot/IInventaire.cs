using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Loot
{
    //Utilisation d'une interface pour donner les paramètres, méthodes, utilisation d'objet et polymorphisme aux classes qui auront hérité de l'interface
    public interface IInventaire
    {
        List<Equipements> ContenuInventaire { get; set; }
    }
}
