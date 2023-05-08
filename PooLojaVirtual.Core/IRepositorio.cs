using System;
using System.Collections.Generic;
using PooLojaVirtual.Models;

namespace PooLojaVirtual.Core
{
    public interface IRepositorio<T>
    {
        IEnumerable<T> GetAll();
        void Inserir(T entidade);
        T RecuperarPorId(int id);
        void Salvar(T entidade);
        void Excluir(T entidade);
    }
}