﻿using AppAlmoxarifado.Domain.Entities.Base;
using AppAlmoxarifado.Domain.Exceptions;
using AppAlmoxarifado.Domain.Exceptions.Base;

namespace AppAlmoxarifado.Domain.Entities;

public class Almoxarifado : EntityBase
{
    public string Nome { get; set; }

    public Almoxarifado(string nome)
    {
        Nome = nome;
        ValidarNome();
    }

    protected Almoxarifado() { }

    private void ValidarNome()
    {
        string msg = string.Empty;

        if(string.IsNullOrEmpty(Nome))
        {
            msg = "O Nome deve ser preenchido";
            throw new Exception(msg);
        }

        if(Nome.Length <= 5 && Nome.Length >= 50)
        {
            msg = "O Nome deve ter entre 5 e 50 caracteres";
            throw new Exception(msg);
        }
    }
}
