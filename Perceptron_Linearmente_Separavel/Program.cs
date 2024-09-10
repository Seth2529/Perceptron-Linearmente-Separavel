using Perceptron_Linearmente_Separavel;

NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);

// Cria lista de entradas
List<Entradas> entradas = new List<Entradas>
{
    new Entradas(113, 6.8, 1), // Maçã
    new Entradas(122, 4.7, 0), // Laranja
    new Entradas(107, 5.2, 1), // Maçã
    new Entradas(98, 3.6, 1),  // Maçã
    new Entradas(115, 2.9, 0), // Laranja
    new Entradas(120, 4.2, 0), // Laranja
    new Entradas(110, 6.5, 1), // Maçã
    new Entradas(125, 4.1, 0), // Laranja
    new Entradas(105, 6.0, 1), // Maçã
    new Entradas(130, 4.3, 0), // Laranja
    new Entradas(115, 6.2, 1), // Maçã
};

// Treina o perceptron com as entradas
neuronioArtificial.Treinar(entradas, 5000);


Console.WriteLine("Pesos finais:");
Console.WriteLine("W1: " + neuronioArtificial.pesos.W1);
Console.WriteLine("W2: " + neuronioArtificial.pesos.W2);


// Testa a classificação
Console.WriteLine("Classificação das entradas:");
foreach (var entrada in entradas)
{
    var resultado = neuronioArtificial.Perguntar(entrada.Entrada1, entrada.Entrada2);
    Console.WriteLine($"Entrada ({entrada.Entrada1}, {entrada.Entrada2}): " + (resultado == 1 ? "Maçã" : "Laranja"));
}