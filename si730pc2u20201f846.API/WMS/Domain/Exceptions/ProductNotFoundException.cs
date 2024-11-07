using System;

namespace WMS.Domain.Exceptions
{
    /// <summary>
    /// Excepción lanzada cuando un producto específico no se encuentra en el sistema.
    /// </summary>
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string productId)
            : base($"Product with ID '{productId}' was not found.")
        {
        }
    }
}
