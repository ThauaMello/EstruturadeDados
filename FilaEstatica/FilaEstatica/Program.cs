using FilaEstatica;
Fila agenda = new Fila(5);


Console.WriteLine("Trabalhando com a Fila");
Console.WriteLine();

agenda.Enfileirar("A");
agenda.Enfileirar("B");
agenda.Enfileirar("C");
agenda.Enfileirar("D");
agenda.Enfileirar("E");

agenda.Imprimir();
