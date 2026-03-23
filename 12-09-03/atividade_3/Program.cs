Console.Write("Insira os segundos:  ");
string a = Console.ReadLine();
int segundos = int.Parse(a);

int horas = segundos/3600;
int minutos = (segundos%3600)/60;
int segundo = segundos-((minutos*60)+(horas*3600));

Console.WriteLine($"O horário é {horas:d2}:{minutos:d2}:{segundo:d2}");
