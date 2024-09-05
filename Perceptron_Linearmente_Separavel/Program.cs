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
};

// Treina o perceptron com as entradas
neuronioArtificial.Treinar(entradas);

// Testa a classificação
Console.WriteLine("Teste de Classificação:");
Console.WriteLine("Entrada (113, 6.8): " + neuronioArtificial.Perguntar(113, 6.8)); // 1
Console.WriteLine("Entrada (122, 4.7): " + neuronioArtificial.Perguntar(122, 4.7)); // 0
Console.WriteLine("Entrada (107, 5.2): " + neuronioArtificial.Perguntar(107, 5.2)); // 1
Console.WriteLine("Entrada (98, 3.6): " + neuronioArtificial.Perguntar(98, 3.6));   // 1
Console.WriteLine("Entrada (115, 2.9): " + neuronioArtificial.Perguntar(115, 2.9)); // 0
Console.WriteLine("Entrada (120, 4.2): " + neuronioArtificial.Perguntar(120, 4.2)); // 0