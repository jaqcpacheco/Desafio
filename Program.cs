Carro c1 = new Carro();
c1.velocidade = 20;

Moto m1 = new Moto();
m1.velocidade = 50;
//list é quando n sabe o numero de elementos que a gente tem, e eu posso utilizar métods como add e remove para facilitar iteração
//Adicionando uma lista de veiculos

List<Veiculo> veiculos =
[
    //add para adicionar
    c1,
    m1,
];


c1.Acelerar();
c1.ExibirVelocidade();
c1.Frear();
c1.ExibirVelocidade();


m1.Acelerar();
m1.ExibirVelocidade();
m1.Frear();
m1.ExibirVelocidade();



