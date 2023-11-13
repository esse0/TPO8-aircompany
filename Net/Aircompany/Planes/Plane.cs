using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        private string _model;
        private int _maxSpeed;
        private int _maxFlightDistance;
        private int _maxLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            _model = model;
            _maxSpeed = maxSpeed;
            _maxFlightDistance = maxFlightDistance;
            _maxLoadCapacity = maxLoadCapacity;
        }

        public string GetModel()
        {
            return _model;
        }

        public int GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public int GetMaxFlightDistance()
        {
            return _maxFlightDistance;
        }

        public int GetMaxLoadCapacity()
        {
            return _maxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane {" +
                $" model = '{_model}'" +
                $", maxSpeed = {_maxSpeed}" +
                $", maxFlightDistance = {_maxFlightDistance}" +
                $", maxLoadCapacity = {_maxLoadCapacity} }}";
        }

        public override bool Equals(object obj)
        {    
            return obj is Plane plane &&
                   _model == plane.GetModel() &&
                   _maxSpeed == plane.GetMaxSpeed() &&
                   _maxFlightDistance == plane.GetMaxFlightDistance() &&
                   _maxLoadCapacity == plane.GetMaxLoadCapacity();
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;

            hashCode *= -1521134295;
            hashCode += EqualityComparer<string>.Default.GetHashCode(_model);
            hashCode += _maxSpeed.GetHashCode();
            hashCode += _maxFlightDistance.GetHashCode();
            hashCode += _maxLoadCapacity.GetHashCode();

            return hashCode;
        }        
    }
}
