using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Model;

/// <summary>
/// Pokémon
/// </summary>
internal class Pokemon
{
    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Element Principale
    /// </summary>
    public Element Element { get; set; }

    /// <summary>
    /// Constructeur d'un pokémon
    /// </summary>
    /// <param name="name"></param>
    /// <param name="element"></param>
    public Pokemon(string name, Element element)
    {
        Name = name;
        Element = element;
        Element.Pokemons.Add(this);
    }
}
