using System;
class Personaje 
{
    public string nombre;
    public int puntos;
    public Personaje(string NombreInicial, int PuntosInicial)
    {
        nombre  = NombreInicial;
        puntos=PuntosInicial;
        Console.WriteLine("El personaje "+nombre+" ha sido creado");
    }
    public void Saludar()
    {
        Console.WriteLine(nombre+" tiene "+puntos+" puntos.");
    }
    
}
class Program
{
    static void Main()
    {
        Personaje heroe=new Personaje("Fulano", 1060);
        heroe.Saludar();
    }
}
