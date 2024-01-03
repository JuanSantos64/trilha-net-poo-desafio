using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new("numeroIphone", "modeloIphone", "imeiIphone", 128);
Nokia nokia = new("numeroNokia", "modelNokia", "imeiNokia", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
