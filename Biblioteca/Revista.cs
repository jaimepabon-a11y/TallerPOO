namespace TallerPOO.Biblioteca;

public class Revista : Material, IPrestable
{
    public int NumeroEdicion { get; set; }
    public Frecuencia Frecuencia { get; set; }

    public Revista(string titulo, string autor, int anioPublicacion, int stock, int numeroEdicion, Frecuencia frecuencia)
        : base(titulo, autor, anioPublicacion, stock)
    {
        NumeroEdicion = numeroEdicion;
        Frecuencia = frecuencia;
    }

    public bool Prestar(string persona)
    {
        // revisamos si queda disponible
        if (!EstaDisponible())
            return false;

        RestarStock();
        Console.WriteLine($"{Titulo} prestada a {persona}");
        return true;
    }

    public void Devolver()
    {
        SumarStock();
        Console.WriteLine($"{Titulo} devuelta");
    }

    public override string ObtenerDescripcion()
    {
        return $"Revista: {Titulo} - edicion {NumeroEdicion}, {Frecuencia}, stock {Stock}";
    }
}
