namespace primerTaller.Models
{
    public class ErrorViewModel
    {
        // Modelo Persona
        public class Persona
        {
            public string Codigo { get; set; }
            public string Email { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
        }

        // Modelo Factura
        public class Factura
        {
            public DateTime Fecha { get; set; }
            public int Numero { get; set; }
            public float Total { get; set; }
        }

        // Modelo ProductoPorFactura
        public class ProductoPorFactura
        {
            public int Cantidad { get; set; }
            public float Subtotal { get; set; }
        }

        // Modelo Vendedor
        public class Vendedor
        {
            public int Carnet { get; set; }
            public string Direccion { get; set; }
        }

        // Modelo Cliente (Tabla 'credito')
        public class Cliente
        {
            public float Credito { get; set; }
        }

        // Modelo Producto
        public class Producto
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public int Stock { get; set; }
            public float ValorUnitario { get; set; }
        }

        // Modelo Empresa
        public class Empresa
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
        }

        // Otros posibles campos para el manejo de errores
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
