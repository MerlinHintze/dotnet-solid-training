using DevBasics.CarManagement.Dependencies;

namespace DevBasics.CarManagement.CarPoolNumberHelperRefactor
{
    public class FordRegistrationNumber : ICarBrandRegistrationNumberGenerator
    {
        public CarBrand ValidFor => CarBrand.Ford;

        public string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId)
        {
            return string.IsNullOrWhiteSpace(endCustomerRegistrationReference) ? registrationRegistrationId : endCustomerRegistrationReference;
        }
    }
}
