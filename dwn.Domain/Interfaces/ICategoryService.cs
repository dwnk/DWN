using dwn.Domain.Models;

namespace dwn.Domain.Interfaces
{
    public interface ICategoryService
    {
        public bool AddCategory(TradeCategory category); 
        public bool UpdateCategory(TradeCategory category);
        public bool DeleteCategory(TradeCategory category);
    }
}
