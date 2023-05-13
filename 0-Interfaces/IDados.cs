
using System;
using System.Collections;
using System.Collections.Generic;

namespace CasaMendes
{
    internal interface IDados
    {

        void AdicionarParametro(string Name, Object Value);
        string Cadastrar(string Procedimento = null);
        List<string> Selecionar(string Procedimento);
        void Atualizar(string Procedimento);
        void Excluir(string Procedimento);


    }
}
