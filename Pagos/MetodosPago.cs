namespace TallerPOO.Pagos;

public class TarjetaCredito : IMetodoPago
{
    public string Nombre => "Tarjeta de credito";

    public bool Pagar(decimal valor)
    {
        Console.WriteLine($"Cobrando {valor} a la tarjeta de credito");
        return true;
    }
}

public class BilleteraDigital : IMetodoPago
{
    public string Nombre => "Billetera digital";

    public bool Pagar(decimal valor)
    {
        Console.WriteLine($"Descontando {valor} de la billetera digital");
        return true;
    }
}

public class TransferenciaBancaria : IMetodoPago
{
    public string Nombre => "Transferencia bancaria";

    public bool Pagar(decimal valor)
    {
        Console.WriteLine($"Haciendo transferencia por {valor}");
        return true;
    }
}
