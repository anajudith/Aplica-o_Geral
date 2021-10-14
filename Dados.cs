using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

class Dados 
{
    private ArrayList Cadastro;

    public Dados()
    {
        Cadastro = new ArrayList();
    }

    public void InserirAluno(Aluno x)
    {
        Cadastro.Add(x);
    }

    public ArrayList ListarAlunos()
    {
        return Cadastro;
    }

    public Aluno PesquisarAluno(string Cód)
    {
        foreach(Aluno x in Cadastro)
        {
            if (x.Código == Cód.ToUpper())
                return x;
        }
        return null;
    }

    public void ExcluirAluno(Aluno x)
    {
        Cadastro.Remove(x);
    }
}