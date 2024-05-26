using System;

public class Calculadora
{
    private List<string> historico;

    public Calculadora() { 
       historico = new List<string>();
    }
    public int Somar(int x, int y)
    {
        historico.Insert(0, $"Resultado: {(x + y)}");
        return x + y;
    }

    public int Subtrair(int x, int y)
    {
        historico.Insert(0, $"Resultado: {(x - y)}");
        return x - y;
    }

    public int Multiplicar(int x, int y)
    {
        historico.Insert(0, $"Resultado: {(x * y)}");
        return x * y;
    }

    public int Dividir(int x, int y)
    {
        historico.Insert(0, $"Resultado: {(x / y)}");
        return x / y;
    }

    public List<string> Historico()
    {
        historico.RemoveRange(3, historico.Count -3);
        return historico;
    }
}
