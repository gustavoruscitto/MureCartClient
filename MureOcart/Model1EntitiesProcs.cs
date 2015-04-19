using System.Data.Entity.Infrastructure;

namespace MureOcart
{
    public partial class Model1Entities
    {
        public virtual void SetStock(int prodId, int stock)
        {
            var command = string.Format("CALL set_product_stock({0},{1})", prodId, stock);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }
    }
}