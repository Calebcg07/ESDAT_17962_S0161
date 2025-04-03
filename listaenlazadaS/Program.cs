
using listaenlazadaS;

Locomotora l =  new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
Console.WriteLine(l.VerVagones());

l.EliminaUltimo();
Console.WriteLine(l.VerVagones());

l.EliminaUltimo();
Console.WriteLine(l.VerVagones());

l.EliminaUltimo();
Console.WriteLine(l.VerVagones());

if (l.ExisteValor(10) == true)
{
    Console.WriteLine("El vagon 10 fue encontrado");
}
else
{
    Console.WriteLine("El vagon 10 no fue encontrado");
}