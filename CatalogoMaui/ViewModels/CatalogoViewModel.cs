using CatalogoMaui.Models;
using CatalogoMaui.Service;
using System.Collections.ObjectModel;

namespace CatalogoMaui.ViewModels;

public class CatalogoViewModel
{
    // ObservableCollection notifica a la lista cuando cambian sus elementos.
    public ObservableCollection<Producto> Productos { get; } = new();
    public async Task CargarAsync()
    {
        var productos = await ProductosSqllite.Instancia.Consultar();
        Productos.Clear();
        foreach (var producto in productos)
            Productos.Add(producto);
    }
}