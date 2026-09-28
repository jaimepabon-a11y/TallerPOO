namespace TallerPOO.Biblioteca;

public class Libro : Material, IPrestable
{
    public string Isbn { get; set; }
    public int Paginas { get; set; }

    public Libro(string titulo, string autor, int anioPublicacion, int stock, string isbn, int paginas)
        : base(titulo, autor, anioPublicacion, stock)
    {
        Isbn = isbn;
        Paginas = paginas;
    }

    public bool Prestar(string persona)
    {
        // si no hay stock no se presta
        if (!EstaDisponible())
            return false;

        RestarStock();
        Console.WriteLine($"{Titulo} prestado a {persona}");
        return true;
    }

    public void Devolver()
    {
        SumarStock();
        Console.WriteLine($"{Titulo} devuelto");
    }

    public override string ObtenerDescripcion()
    {
        return $"Libro: {Titulo} - {Autor} ({AnioPublicacion}) ISBN {Isbn}, {Paginas} paginas, stock {Stock}";
    }
}
