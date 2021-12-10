using desafio04;
double soma=0;
Random randNum = new Random();
Aluno[] aluno = new Aluno[3];
aluno[0] = new Aluno();
aluno[1] = new Aluno();
aluno[2] = new Aluno();

List<string>randNames=new List<string>();
randNames.Add("israel");
randNames.Add("Orlando");
randNames.Add("Miguel");

var arrayNome= new string[3];
int [] arrayIdade = new int[3];
double [] arrayNota = new double[3];

for (int i = 0; i < 3; i++) {
    arrayNota[i] = randNum.Next(0,10);
    arrayIdade[i] = randNum.Next(0,70);
    arrayNome[i] = randNames[i];

}

for (int i = 0; i < 3; i++)
{
    aluno[i].nome = arrayNome[i];
    aluno[i].nota = arrayNota[i];
    aluno[i].idade = arrayIdade[i];

}
List<Aluno>alunos=new List<Aluno>();

for (int i = 0; i < 3; i++)
{
    alunos.Add(aluno[i]);
    soma = soma + alunos[i].nota;
    Console.WriteLine(alunos[i].nome + " " + aluno[i].nota);  
}
        
        Console.WriteLine("A soma de todas as notas é " + soma);


Console.ReadKey();  
