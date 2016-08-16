using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests
{
    class MockedTeleportStation : TeleportStation
    {
        public MockedTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) 
            : base(owner, galacticMap, location)
        {
            this.Owner = owner;
            this.GalacticMap = galacticMap;
            this.Location = location;
            this.Resources = new Resources();
        }

        public IBusinessOwner Owner { get; set; }

        public IEnumerable<IPath> GalacticMap { get; set; }

        public ILocation Location { get; set; }

        public IResources Resources { get; set; }

    }
}
