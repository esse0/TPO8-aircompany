using Aircompany.Models;
using Aircompany.Planes;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        private List<Plane> _planes;

        public Airport(IEnumerable<Plane> planes)
        {
            _planes = planes.ToList();
        }

        public IEnumerable<Plane> GetPlanes()
        {
            return _planes;
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            return _planes.OfType<PassengerPlane>().ToList();
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            return _planes.OfType<MilitaryPlane>().ToList();
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            return GetPassengersPlanes().OrderByDescending(plane => plane.PassengersCapacity()).First();
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            return GetMilitaryPlanes()
                .Where(militaryPlane => militaryPlane.Type == MilitaryType.TRANSPORT).ToList();
        }

        public void SortByMaxFlightDistance()
        {
            _planes = _planes.OrderByDescending(plane => plane.GetMaxFlightDistance()).ToList();
        }

        public void SortByMaxSpeed()
        {
            _planes = _planes.OrderBy(plane => plane.GetMaxSpeed()).ToList();
        }

        public void SortByMaxLoadCapacity()
        {
            _planes = _planes.OrderBy(plane => plane.GetMaxLoadCapacity()).ToList();
        }

        public override string ToString()
        {
            return $"Airport{{planes={string.Join(", ", _planes.Select(plane => plane.GetModel()))}}}";
        }
    }
}
