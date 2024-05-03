int mg;
Console.WriteLine("Avaliação de Diabetes em gestantes");
Console.Write("Escreva a quantidade de mg/dL:  ");
mg = Convert.ToInt32(Console.ReadLine());
if(92>mg){Console.WriteLine("reavaliar entre 24 e 28 semanas "+
 "com TTOG 75g de glicose");}
if(mg >= 92 && mg <126){Console.WriteLine("Compatível com Diabetes "+
"Gestacional");}
if(126 <= mg){Console.WriteLine("Diabetes Mellitus na Gravidez");}


