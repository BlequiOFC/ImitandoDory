Console.Clear();
String Frase, FraseDory;

Console.WriteLine("Digite uma frase para a Dory dizer em baleiês");
Frase = Console.ReadLine()!;

FraseDory = Frase

.Replace("A", "AAA")
.Replace("a", "aaa")
.Replace("E", "EEE")
.Replace("e", "eee")
.Replace("I", "III")
.Replace("i", "iii")
.Replace("O", "OOO")
.Replace("o", "ooo")
.Replace("U", "UUU")
.Replace("u", "uuu")
.Replace("Á", "ÁÁÁ")
.Replace("á", "ááá")
.Replace("Ã", "ÃÃÃ")
.Replace("ã", "ããã")
.Replace("Õ", "ÕÕÕ")
.Replace("õ", "õõõ");

Console.WriteLine($"Dory: {FraseDory}");



