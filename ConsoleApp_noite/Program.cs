// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp_noite;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja SKOL Litrão");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco endereco = new Endereco("Rua Mario Miziara", "91", "Sobral", "159906304", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "Gabriele", "997935682", endereco);
Cliente c2 = new Cliente(1, "Gabriela", "997935682", endereco);
Cliente c3 = new Cliente(1, "Ryan", "997935682", endereco);
Cliente c4 = new Cliente(1, "Fernanda", "997935682", endereco);
Cliente c5 = new Cliente(1, "Giovanni", "997935682", endereco);

Console.WriteLine(c2.getEndereco().getRua() + "" + c2.getEndereco().getNumero());
c2.getEndereco().setNumero("135");