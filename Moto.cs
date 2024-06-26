public class Moto : Veiculo 
{
    //classe abstrata é uma classe que serve de base para outras classses, as classes abstratas n podem ser instanciadas
    //override, método sobreescrito
    public override void Acelerar()
    {
        velocidade = velocidade + 15;
        Console.WriteLine("Moto Acelerando.");
    }
    public override void Frear()
    {
        velocidade = velocidade - 10;
        Console.WriteLine("Moto Freando");
    }

}