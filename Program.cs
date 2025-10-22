using System.Security.Cryptography.X509Certificates;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone celular1 = new Iphone("1122203i03", "Iphone 11", "1112010003A", 128);
Smartphone celular2 = new Nokia("8192931003", "Nokia Lumia", "131231392495E", 32);

celular1.Ligar();
celular2.ReceberLigacao();

celular2.Ligar();
celular1.ReceberLigacao();

celular1.InstalarAplicativo("Pou 2");
celular2.InstalarAplicativo("Free Fire");