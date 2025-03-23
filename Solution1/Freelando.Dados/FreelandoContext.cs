﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Freelando.Dados
{
    public class FreelandoContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public FreelandoContext(DbContextOptions<FreelandoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectionStrings:DefaultConnection"));
            }
        }

        public DbSet<Candidatura> Candidaturas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
    }
}
