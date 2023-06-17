using DevBasics.CarManagement.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBasics.CarManagement.Refactor
{
    public class CarMissingDataChecker
    {
        // zu viele Expression, die Verkettung ist zu lang
        public bool HasMissingData(CarRegistrationModel car)
        {
            return (string.IsNullOrWhiteSpace(car.CompanyId))
                        || (string.IsNullOrWhiteSpace(car.VehicleIdentificationNumber))
                            || (string.IsNullOrWhiteSpace(car.CustomerId))
                                || car.DeliveryDate == null
                                    || (string.IsNullOrWhiteSpace(car.ErpDeliveryNumber));
        }
    }
}
