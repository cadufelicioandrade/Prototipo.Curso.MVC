﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prototipo.Curso.MVC.Dados.Context;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Dados.Repository
{
    public class ClienteRepository : BaseRepository, IBaseInterface<Cliente>, IClienteRepository
    {
        public ClienteRepository(LocadoraContext locadoraContext) : base(locadoraContext)
        {
        }

        public Cliente Create(Cliente entity)
        {
            _context.Cliente.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Cliente GetById(int id)
        {
            return _context.Cliente
                        .Include(c => c.Endereco)
                        .Include(c => c.Endereco.Cidade)
                        .Include(c => c.Endereco.Cidade.Estado)
                        .Include(c => c.ItemLocacoes)
                        .FirstOrDefault(f => f.Id == id);
        }

        public List<Cliente> GetAll()
        {
            return _context.Cliente
                            .Include(c => c.Endereco)
                            .Include(c => c.Endereco.Cidade)
                            .Include(c => c.Endereco.Cidade.Estado)
                            .Include(c => c.ItemLocacoes)
                            .ToList();
        }

        public Cliente Update(Cliente entity)
        {
            _context.Cliente.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
