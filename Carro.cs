public class Carro : Veiculo
{
    //override, método sobreescrito
    public override void Acelerar()
    {
        velocidade = velocidade + 10;
        Console.WriteLine("Carro Acelerando");
    }

      public override void Frear()
    {
        velocidade = velocidade - 5;
        Console.WriteLine("O carro esta freando.");
    }

    
}
    
