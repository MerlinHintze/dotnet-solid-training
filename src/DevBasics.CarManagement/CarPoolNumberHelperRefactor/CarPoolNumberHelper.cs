using DevBasics.CarManagement.CarPoolNumberHelperRefactor;
using DevBasics.CarManagement.Dependencies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DevBasics.CarManagement
{
    public class CarPoolNumberHelper
    {
        private readonly IEnumerable<ICarBrandRegistrationNumberGenerator> _generator;

        public CarPoolNumberHelper(IEnumerable<ICarBrandRegistrationNumberGenerator> generator)
        {
            _generator = generator;
        }

        public void Generate(CarBrand carBrand, string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber)
        {
            var generator = _generator.Single(gen => gen.ValidFor.Equals(carBrand));
            registrationRegistrationId = GenerateRegistrationRegistrationId();
            registrationNumber = generator.GenerateRegistrationNumber(endCustomerRegistrationReference, registrationRegistrationId);
        }

        public string GenerateRegistrationRegistrationId() // hätten es so gelassen da die klasse sonst sehr klein ist und auch nur hier die Methode genutzt wird
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}