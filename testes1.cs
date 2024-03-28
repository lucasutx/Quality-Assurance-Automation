
using System;
using System.Collections.Generic;

class Testes
{
    private string email;
    private string senha;

    //lista de caracteres especiais
    private List<char> caracteresEspeciais = new List<char> { '/', '?', ':', ';', ',', '<', '>', '°', '{', '}', '!', '#', '$', '%', '¨', '*', '(', ')' };

    // lista para armazenar os registros de cadastro
    private List<Dictionary<string, string>> cadastro = new List<Dictionary<string, string>>();

    public Testes(string e, string s)
    {
        email = e;
        senha = s;

        // verifica se já tem a conta 
        ExisteConta();

        // adicionar o cadastro
        AdicionarCadastro();
    }

    private void AdicionarCadastro()
    {
        // criar um dicionário 
        Dictionary<string, string> registro = new Dictionary<string, string>();
        registro["email"] = email;
        registro["senha"] = senha;

        // adicionar o registro
        cadastro.Add(registro);
    }



    public void ExisteCaracteresEspeciais()
    {
        for (int i = 0; i < caracteresEspeciais.Count; i++)
        {
            //procura caracteres especiais
            if (email.Contains(caracteresEspeciais[i]))
            {
                throw new Exception("O email contém caracteres especiais.");
            }
        }
    }

    public void Tamanho()
    {
        // calcular o tamanho da senha
        int tamanho = senha.Length;

        if (tamanho < 5 || tamanho > 20)
        {
            throw new Exception("O tamanho de senha é inválido; deve ter entre 5 e 20 caracteres.");
        }
    }

    public void ExisteConta()
    {
        for (int i = 0; i < cadastro.Count; i++)
        {
            //procura se já existe essa conta no array (que no caso poderia ser no banco de dados num site real)
            if (cadastro[i]["email"].Contains( email))
            {
                throw new Exception("Conta já existente");
            }
        }



    }
}

