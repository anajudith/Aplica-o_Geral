using System;
using System.Collections;


class Operações
{
    public void Inserir(Aluno MeuAluno, Dados MeusDados)
    {
        MeuAluno.LêDados();

        MeusDados.InserirAluno(MeuAluno);
        
    }

    public void Listar(Dados MeusDados)
    {
        ArrayList Lista;

        Lista = MeusDados.ListarAlunos();

        foreach (Aluno x in Lista)
        {
            x.MostraDados();
        }
    }

    public void Pesquisar(string CódPesq, Aluno MeuAluno, Dados MeusDados)
    {
        MeuAluno = MeusDados.PesquisarAluno(CódPesq);

        if(MeuAluno != null)
        {
            MeuAluno.MostraDados();
        } 
        else
        {
            Console.Write("\nAluno não encontrado no cadastro...");
        }
        Console.ReadKey();
    }

    public void Excluir(string CódPesq, Aluno MeuAluno, Dados MeusDados)
    {
        MeuAluno = MeusDados.PesquisarAluno(CódPesq);

        if(MeuAluno != null)
        {
            MeuAluno.MostraDados();
            MeusDados.ExcluirAluno(MeuAluno);

            Console.Write("Aluno excluído do cadastro...");
        }
        else
        {
            Console.Write("Aluno não cadastrado...");
        }
        Console.ReadKey();
    }
}