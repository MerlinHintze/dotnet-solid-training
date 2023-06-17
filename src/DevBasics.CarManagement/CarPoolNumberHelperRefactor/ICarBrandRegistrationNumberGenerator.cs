using DevBasics.CarManagement.Dependencies;

namespace DevBasics.CarManagement.CarPoolNumberHelperRefactor
{
    public interface ICarBrandRegistrationNumberGenerator
    {
        public CarBrand ValidFor { get; }
        public string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId);
    }
}
