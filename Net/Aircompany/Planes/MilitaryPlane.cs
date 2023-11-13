using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _type = type;
        }

        public MilitaryType Type
        {
            get
            {
                return _type;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is MilitaryPlane militaryPlane &&
                   base.Equals(obj) &&
                   _type == militaryPlane.Type;
        }
        
        public override int GetHashCode()
        {
            var hashCode = 1701194404;

            hashCode *= -1521134295;
            hashCode += base.GetHashCode();
            hashCode += Type.GetHashCode();

            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", $", type={Type}}}");
        }        
    }
}
