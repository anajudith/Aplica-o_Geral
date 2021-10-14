using System;

namespace Aplicação_Geral
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MeuMenu = new Menu(new Operações(), new Dados());

            MeuMenu.MostraMenu();
        }
    }
}
