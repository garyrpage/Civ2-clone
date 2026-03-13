using Model.Core.Units;

namespace Model.Core.GoodyHuts.Outcomes
{
    public abstract class TribeOutcome : GoodyHutOutcome
    {
        protected TribeOutcome(string message) : base(message) { }
        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            throw new NotImplementedException();
            //if (unit.CurrentLocation != null)
            //{
            //    // Terrain is the determining factor in which is selected..
            //    // Advanced Tribes occur only on Grasslands or Plains. All other terrain types produce nomads.
            //    if (unit.CurrentLocation.Terrain.Type == TerrainType.Grassland || unit.CurrentLocation.Terrain.Type == TerrainType.Plains)
            //    {
            //        // Before 1000AD, all cities founded from Advanced Tribes have a size of 1.
            //        // After that date, the size of the city can be 1 to 4. It will always have a Temple.
            //        // In addition, it has a 50% chance of having a Marketplace, 33% chance of a Granary, and a 25% chance of a Library.
            //        new AdvancedTribeOutcome().ApplyOutcome(unit);
            //    }
            //    else
            //    {
            //        // TODO: Nomads can also occur on Plains or Grasslands when the surrounding terrain makes the site poorly suited for a city.
            //        // TODO: The Nomads result is subject to the Nomads Rule and the Explosives Rule (see below).
            //        // After any Civ acquires Explosives, the Nomad result is suppressed and its chance is added to Gold. Thus, on Nomad-suited terrain, the outcome ratio becomes 0:2:1:1:1
            //        new NomadsOutcome().ApplyOutcome(unit);
            //    }
            //}
        }
    }

    public class AdvancedTribeOutcome : TribeOutcome
    {
        public string Name => "Advanced Tribe";
        public AdvancedTribeOutcome() : base("SURPRISETRIBE") { }

        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Tribe");
        }
    }

    public class NomadsOutcome : TribeOutcome
    {
        public NomadsOutcome() : base("SURPRISENOMADS") { }

        public override GoodyHutOutcomeResult ApplyOutcome(Unit unit)
        {
            return new GoodyHutOutcomeResult(Message, true, "Nomads");
        }
    }

    //    public string Name => "Nomads";
    //    public string Description => "SURPRISENOMADS";
    //    public override void ApplyOutcome(Unit unit)//, Rules rules)
    //    {
    //        // Add Settlers unit to the players units at this unit's location.
    //        var nomad = new Unit
    //        {
    //            Counter = 0,
    //            Dead = false,
    //            Id = unit.Owner.Id,
    //            Order = (int)OrderType.NoOrders,
    //            Owner = unit.Owner,
    //            Veteran = false,
    //            X = unit.CurrentLocation.X,
    //            Y = unit.CurrentLocation.Y,
    //            CurrentLocation = unit.CurrentLocation,
    //            //TypeDefinition = rules.UnitTypes[(int)UnitType.Settlers];
    //        };

    //        unit.Owner.Units.Add(unit);

    //        throw new NotImplementedException();
    //    }
    //}
}
