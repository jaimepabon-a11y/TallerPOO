namespace TallerPOO.Biblioteca;

public abstract class Material
{
    // datos que tienen los materiales
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnioPublicacion { get; set; }
    public int Stock { get; private set; }

    protected Material(string titulo, string autor, int anioPublicacion, int stock)
    {
        Titulo = titulo;
        Autor = autor;
        AnioPublicacion = anioPublicacion;
        Stock = stock;
    }

    public bool EstaDisponible()
    {
        return Stock > 0;
    }

    protected void RestarStock()
    {
        Stock--;
    }

    protected void SumarStock()
    {
        Stock++;
    }

    public abstract string ObtenerDescripcion();
}
