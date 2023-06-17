using DevBasics.CarManagement.CarPoolNumberHelperRefactor;
using System;

namespace DevBasics.CarManagement
{
    public static class CarRegistrationNumberGenerator
    {
        public static void Generate(ICarBrandRegistrationNumberGenerator carBrandRegistrationNumberGenerator, string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber)
        {
            registrationRegistrationId = GenerateRegistrationRegistrationId();
            registrationNumber = carBrandRegistrationNumberGenerator.GenerateRegistrationNumber(endCustomerRegistrationReference, registrationRegistrationId);
        }

        public static string GenerateRegistrationRegistrationId() // hätten es so gelassen da die klasse sonst sehr klein ist und auch nur hier die Methode genutzt wird
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}