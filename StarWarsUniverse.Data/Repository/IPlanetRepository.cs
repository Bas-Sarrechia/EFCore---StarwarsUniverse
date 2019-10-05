using System;
using System.Collections.Generic;
using System.Text;
using StarWarsUniverse.domain;

namespace StarWarsUniverse.Data.Repository
{
    public interface IPlanetRepository
    {
        IList<Planet> GetAllPlanets();
    }
}