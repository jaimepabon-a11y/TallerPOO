namespace TallerPOO.Biblioteca;

public class GestorBiblioteca
{
    private List<Material> materiales = new();

    public void AgregarMaterial(Material material)
    {
        materiales.Add(material);
    }

    public void MostrarMateriales()
    {
        // mostramos lo que ya tenemos guardado guardado
        foreach (var material in materiales)
        {
            Console.WriteLine(material.ObtenerDescripcion());
        }
    }

    public void PrestarMaterial(Material material, string persona)
    {
        if (material is not IPrestable prestable)
        {
            Console.WriteLine($"{material.Titulo} no se puede prestar");
            return;
        }

        if (!prestable.Prestar(persona))
        {
            Console.WriteLine($"{material.Titulo} no esta disponible");
        }
    }
}
