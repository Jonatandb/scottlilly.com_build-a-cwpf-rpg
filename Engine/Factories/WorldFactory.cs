// https://scottlilly.com/build-a-cwpf-rpg/
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Campo del granjero",
                "Aquí hay hileras de maíz, con ratas gigantes que se esconden entre ellas.",
                "/Engine;component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Casa del granjero",
                "Esta es la casa de tu vecino, el granjero Ted.",
                "/Engine;component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Hogar",
                "Esta es tu casa",
                "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Tienda de comercio",
                "La tienda de Susan, la comerciante.",
                "/Engine;component/Images/Locations/Trader.png");

            newWorld.AddLocation(0, 0, "Plaza de la ciudad",
                "Ves una fuente aquí.",
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(1, 0, "Puerta de la ciudad",
                "Aquí hay una puerta que protege al pueblo de las arañas gigantes.",
                "/Engine;component/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Bosque de arañas",
                "Los árboles en este bosque están cubiertos de telarañas.",
                "/Engine;component/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(0, 1, "Cabaña del herbolario",
                "Ves una pequeña cabaña, con plantas secas que caen del techo.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Jardín del herbolario",
                "Aquí hay muchas plantas, con serpientes escondidas detrás de ellas.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}
