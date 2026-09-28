using TallerPOO.Biblioteca;
using TallerPOO.Pagos;

// primero probamos la parte de biblioteca
Console.WriteLine("=== BIBLIOTECA ===");

var biblioteca = new GestorBiblioteca();
var libro = new Libro("Cien años de soledad", "Gabriel Garcia Marquez", 1967, 1, "978-0307474728", 471);
var revista = new Revista("Semana", "Varios", 2024, 2, 2150, Frecuencia.Semanal);

biblioteca.AgregarMaterial(libro);
biblioteca.AgregarMaterial(revista);
biblioteca.MostrarMateriales();

biblioteca.PrestarMaterial(libro, "Ana");
biblioteca.PrestarMaterial(libro, "Carlos");
libro.Devolver();
biblioteca.PrestarMaterial(libro, "Carlos");
biblioteca.PrestarMaterial(revista, "Luis");

Console.WriteLine();
Console.WriteLine("=== SISTEMA DE PAGOS ===");

var orden1 = new Orden(1, "Laura", 150000);
var orden2 = new Orden(2, "Pedro", 89900);

orden1.PagarCon(new TarjetaCredito());
orden2.PagarCon(new BilleteraDigital());
orden1.PagarCon(new TransferenciaBancaria());
