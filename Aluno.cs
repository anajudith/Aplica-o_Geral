using System;

class Aluno {
    public string Código { get; set;}
    public string Nome { get; set;}
    public string Telefone { get; set;}
    public string Mail { get; set;}

    public Aluno ()  //DAO 
    {
        this.Código = Guid.NewGuid().ToString().Substring(9,4).ToUpper();  //Gera um identificador com numeros e letras aletorios
        this.Nome = "";
        this.Telefone = "";
        this.Mail = "";
    }

    public void LêDados()
    {
        Console.WriteLine("Código do Aluno.......: {0}", this.Código);

        Console.Write("Nome do Aluno........: ");
        this.Nome = Console.ReadLine();

        Console.Write("Telefone.............: ");
        this.Telefone = Console.ReadLine();

        Console.Write("Email................: ");
        this.Mail = Console.ReadLine();

    }

    public void MostraDados()
    {
        Console.WriteLine("Nome do Aluno: {0} ({1})", this.Nome, this.Código);
        Console.WriteLine("Telefone.....: {0}", this.Telefone);
        Console.WriteLine("Mail.....: {0}\n", this.Mail);
    }
}
