using System;
using Modelos;
namespace Projeto1
{
    public class Program
    {
        static void Main(string[] args)
        {
			Turma t1 = new Turma();
			t1.numeroDaTurma = "1";
			t1.numeroDaSala = "504";
			t1.disciplina = "Biologia";
			t1.bloco = 'A';
			t1.disponivel = true;



			Aluno a1 = new Aluno();
			a1.nome = "Iago";
			a1.sexo = "Masculino";
			a1.matricula = 1576202;
			a1.cpf = "000.000.000-00";
			a1.identidade = "0.000.000";
			a1.curso = "Ensino Médio";

			Professor p1 = new Professor();
			p1.nome = "José";
			p1.sexo = "Masculino";
			p1.chapa = "xxxxx";
			p1.cpf = "000.000.000-00";
			p1.identidade = "0.000.000";
			p1.turma = t1;

			t1.professor = p1;



			Console.WriteLine("O professor da turma de " + t1.disciplina + " é " + p1.nome);

		}
	}
}
