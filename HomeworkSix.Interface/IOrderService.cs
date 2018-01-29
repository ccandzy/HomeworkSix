using HomeworkSix.Model;

namespace HomeworkSix.Interface
{
    public interface IOrderService
    {
        void Create(Order order);
        void Cancel(Order order);
        void Pay(Order order);
    }
}
