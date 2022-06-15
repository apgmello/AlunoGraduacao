namespace _03_alunoGraduacao
{
    internal class AlunoGraduacao
    {
        public int matricula;
        public string nome;
        public DateOnly dataNascimento;
        public double percentualCobranca;
        public double valor;
        public byte codCurso;
        public const byte ARQUITETURA = 1;
        public const byte CIENCIAS_DA_COMPUTACAO = 2;
        public const byte ENGENHARIA = 3;
        public const byte BIOMEDICINA = 4;
        private const byte POS_GRADUACAO = 0;

        public AlunoGraduacao(int matricula, string nome, DateOnly dataNascimento, byte codCurso)
        {
            if (codCurso != ARQUITETURA && codCurso != CIENCIAS_DA_COMPUTACAO && codCurso != ENGENHARIA && codCurso != BIOMEDICINA && codCurso != POS_GRADUACAO)
            {
                throw new ArgumentException("Codigo inválido!");
            }
            this.codCurso = codCurso;
            this.matricula = matricula;
            this.nome = nome;
            this.dataNascimento = dataNascimento;

        }

        public virtual void CalculaMensalidade()
        {
            switch (codCurso)
            {
                case ARQUITETURA:
                    valor = 450;
                    break;
                case CIENCIAS_DA_COMPUTACAO:
                    valor = 650;
                    break;
                case ENGENHARIA:
                    valor = 850;
                    break;
                case BIOMEDICINA:
                    valor = 750;
                    break;
                case POS_GRADUACAO:
                    valor = 0;
                    break;
            }
        }
        private string NomeCurso(byte codCurso)
        {

            switch (codCurso)
            {
                case ARQUITETURA:
                    return "Arquitetura";
                    break;
                case CIENCIAS_DA_COMPUTACAO:
                    return "Ciências da Computação";
                    break;
                case ENGENHARIA:
                    return "Engenharia";
                    break;
                case BIOMEDICINA:
                    return "Biomedicina";
                    break;
                case POS_GRADUACAO:
                    return "Pós Graduação";
                    break;
            }
            return "";
        }

        public virtual void Imprimir()
        {
            Console.WriteLine($"-------------------------\n" +
                              $"Matrícula: {matricula}\n" +
                              $"Nome: {nome}\n" +
                              $"Data de Nascimento: {dataNascimento}\n" +
                              $"Curso: {NomeCurso(codCurso)}\n" +
                              $"Valor mensalidade: {valor}");
        }
    }
}
