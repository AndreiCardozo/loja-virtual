using System;
using System.Collections.Generic;
using LiteDB;
using PooLojaVirtual.Core;
using PooLojaVirtual.Models;

namespace PooLojaVirtual.Infraestructure
{
    public class RepositorioLiteDB<T> : IRepositorio<T> where T: Entidade
    {
        private LiteRepository _db;

        public RepositorioLiteDB()
        {
            _db = new LiteRepository("loja.db");
        }

        public void Excluir(T entidade)
        {
            _db.Delete<T>(entidade.Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Query<T>().ToEnumerable();
        }

        public void Inserir(T entidade)
        {
            _db.Insert<T>(entidade);
        }

        public T RecuperarPorId(int id)
        {
            return _db.SingleById<T>(id);
        }

        public void Salvar(T entidade)
        {
            _db.Update<T>(entidade);
        }
    }
}