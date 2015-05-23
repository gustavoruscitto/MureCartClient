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

        public virtual void AgregarProdCateg(int prodId, int categId)
        {
            var command = string.Format("CALL create_product_category({0},{1})", prodId, categId);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }

        public virtual void AgregarCategoria(int categId, int categIdPadre, string nombre, string descripcion,
                                            string metaDesc, string metaKeys, string imagen)
        {
            var command = string.Format("CALL create_category({0},{1},'{2}','{3}','{4}','{5}','{6}')", 
                                            categId,categIdPadre,nombre,descripcion,
                                            metaDesc,metaKeys,imagen);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }
    }
}