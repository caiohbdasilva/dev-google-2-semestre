Console.Write("Insira o valor disponível:  ");
string a = Console.ReadLine();
decimal valor = decimal.Parse(a);

decimal desconto = valor-((valor/100)*10);
decimal acrescimo = valor+((valor/100)*7);

Console.WriteLine($"O valor com o desconto de 10% será de: R$ {desconto:f2}");
Console.WriteLine($"O valor com o acrescimo de 7% será de: R$ {acrescimo:f2}");
