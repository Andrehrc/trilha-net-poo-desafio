using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testes com as classes Nokia e Iphone
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "Azul");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("987654321", "iPhone 12", "Preto");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}