using System.Collections.Generic;
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

        public virtual void AgregarImagenProd(int prodId, string imagen, int orden)
        {
            var command = string.Format("CALL create_product_image({0},'{1}',{2})", prodId, imagen, orden);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }

        public virtual void ActualizarOrden(int orderId, int status, string comentario)
        {
            var command = string.Format("CALL set_order_history({0},{1},'{2}')", orderId, status, comentario);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }

        public virtual void AgregarProducto(string[] campos)
        {
            var commandText = string.Format("CALL create_product({0},'{1}','{2}',{3},'{4}','{5}', " +
                                                                "'{6}','{7}','{8}','{9}',{10},'{11}')", 
                                        campos[0],campos[1],campos[2],campos[3],campos[4],campos[5],
                                        campos[6],campos[7],campos[8],campos[9],campos[10],campos[11]);
            var command = string.Format(commandText);
            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand(command);
        }
    }
}