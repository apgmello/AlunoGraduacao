namespace _03_alunoGraduacao
{
    internal class AlunoPos : AlunoGraduacao
    {
        private string orientador = "";
        private double bolsaDeEstudos = 0;
        private byte linhaDePesquisa;
        public const byte MOBILIDADE = 5;
        public const byte GEOTECNOLOGIAS = 6;
        public AlunoPos(int matricula, string nome, DateOnly dataNascimento,
        byte codCurso, double bolsaDeEstudos, string orientador, byte linhaDePesquisa) :
        base(matricula, nome, dataNascimento,  0)
        {
            this.bolsaDeEstudos = bolsaDeEstudos;
            this.orientador = orientador;
            this.linhaDePesquisa = linhaDePesquisa;
        }
        public override void CalculaMensalidade()
        {
            switch (linhaDePesquisa)
            {
                case MOBILIDADE:
                    valor = 1000;
                    valor -= bolsaDeEstudos;
                    break;
                case GEOTECNOLOGIAS:
                    valor = 750;
                    valor -= bolsaDeEstudos;
                    break;
            }
        }
        private string LinhaDePesquisa(byte linhaDePesquisa)
        {
            switch (linhaDePesquisa)
            {
                case MOBILIDADE:
                    return "Mobilidade";
                    break;
                case GEOTECNOLOGIAS:
                    return "Geotecnologias";
                    break;
            }
            return "";
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine($"-------------------------\n" +
                $"Orientador: {orientador}\n" +
                $"Bolsa: {bolsaDeEstudos}\n" +
                $"Linha de Pesquisa: {LinhaDePesquisa(linhaDePesquisa)}");
        }
    }

}
