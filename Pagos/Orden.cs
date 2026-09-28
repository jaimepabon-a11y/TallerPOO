namespace TallerPOO.Pagos;

public class Orden
{
    public int Id { get; }
    public string Cliente { get; }
    public decimal Valor { get; }
    public EstadoOrden Estado { get; private set; } = EstadoOrden.Pendiente;

    public Orden(int id, string cliente, decimal valor)
    {
        Id = id;
        Cliente = cliente;
        Valor = valor;
    }

    public bool PagarCon(IMetodoPago metodo)
    {
        // una orden no se puede pagar dos veces
        if (Estado == EstadoOrden.Pagada)
        {
            Console.WriteLine($"La orden {Id} ya estaba pagada");
            return false;
        }

        if (!metodo.Pagar(Valor))
            return false;

        Estado = EstadoOrden.Pagada;
        Console.WriteLine($"Orden {Id} de {Cliente} pagada con {metodo.Nombre}");
        return true;
    }
}
