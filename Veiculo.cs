public abstract partial class Veiculo
{// em c# array é uma coleção de elementos do mesmo tipo, tamanho fixo, tudo já é definido
    public int velocidade;
    //Métodos abstratos n tem implementação, public abstract, tipo de retorno, e valor do método
    public abstract void Acelerar();

    public void ExibirVelocidade()
    {
        Console.WriteLine($"A velocidade está em {velocidade}");
        
    }
    public abstract void Frear();

}