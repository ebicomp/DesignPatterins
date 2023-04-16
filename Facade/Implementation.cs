namespace Facade
{
    public class OrderService
    {
        public bool HasEnoughtOrders(int customerId)
        {
            return customerId > 0;
        }
    }
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountbase(int customerId)
        {
            return (customerId > 5) ? 10 : 20;
        }
    }
    public class DayOfTheWeekFactorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }
    public class DiscountFacade
    {
        private readonly OrderService orderService = new();
        private readonly CustomerDiscountBaseService CustomerDiscountBaseService = new();
        private readonly DayOfTheWeekFactorService dayOfTheWeekFactorService = new();


    }

}
