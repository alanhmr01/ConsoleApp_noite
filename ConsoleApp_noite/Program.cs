﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp_noite;

Produto p1 = new Produto(1, 10.90M, "Cervejinha");

Console.WriteLine(p1.getDescricao()+" "+p1.getId());

p1.setValor(11.85M);
p1.setDescricao("Cerveja SKOL Litrão");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
