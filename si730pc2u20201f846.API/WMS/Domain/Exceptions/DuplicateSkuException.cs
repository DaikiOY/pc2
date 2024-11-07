using System;

namespace WMS.Domain.Exceptions
{
    /// <summary>
    /// Excepción lanzada cuando se intenta agregar un producto con un SKU duplicado.
    /// </summary>
    public class DuplicateSkuException : Exception
    {
        public DuplicateSkuException(string sku)
            : base($"A product with SKU '{sku}' already exists.")
        {
        }
    }
}
