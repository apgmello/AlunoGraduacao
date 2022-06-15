using _03_alunoGraduacao;

string nome;
int matricula;
DateOnly dataNascimento;
byte codCurso;
string orientador = "";
double bolsaDeEstudos = 0;
byte linhaDePesquisa;

Console.Write("Nome aluno: ");
nome = Console.ReadLine();

Console.Write("Matrícula: ");
int.TryParse(Console.ReadLine(), out matricula);

Console.Write("Data de Nascimento: ");
DateOnly.TryParse(Console.ReadLine(), out dataNascimento);


Console.Write("Cursos de graduação\n" +
    "(1) Arquitetura\n" +
    "(2) Ciências da Computação)\n" +
    "(3) Engenharia\n" +
    "(4) Biomedicina\n" +
    "Cursos de Pós-Graduação\n" +
    "(5) Mobilidade\n" +
    "(6) Geotecnologias\n" +
    "Opção: ");
byte.TryParse(Console.ReadLine(), out codCurso);

AlunoGraduacao aluno;

if (codCurso <= 0 || codCurso > 5)
{
    Console.WriteLine("Opção inválida!");
    return;
}
if (codCurso < 5)
{
    aluno = new AlunoGraduacao(matricula, nome, dataNascimento, codCurso);
    aluno.CalculaMensalidade();
    aluno.Imprimir();
}
else
{
    linhaDePesquisa = codCurso;
    Console.Write("Orientador: ");
    orientador = Console.ReadLine();
    Console.Write("Valor da bolsa de estudos: ");
    double.TryParse(Console.ReadLine(), out bolsaDeEstudos);
    aluno = new AlunoPos(matricula, nome, dataNascimento, codCurso, bolsaDeEstudos, orientador, linhaDePesquisa);
    aluno.CalculaMensalidade();
    aluno.Imprimir();
}