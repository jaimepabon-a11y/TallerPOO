namespace TallerPOO.Pagos;

public interface IMetodoPago
{
    string Nombre { get; }
    bool Pagar(decimal valor);
}
