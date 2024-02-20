using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Model;

internal class Element
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    /// <summary>
    /// Constructeur d'un element
    /// </summary>
    /// <param name="name"></param>
    public Element(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
    }
}
