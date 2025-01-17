﻿using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            _passengersCapacity = passengersCapacity;
        }

        public int PassengersCapacity()
        {
            return _passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            var plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   _passengersCapacity == plane._passengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;

            hashCode *= -1521134295;
            hashCode += base.GetHashCode();
            hashCode += PassengersCapacity().GetHashCode();

            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString().Replace("}", $", passengersCapacity={PassengersCapacity()}}}");
        }       
    }
}
