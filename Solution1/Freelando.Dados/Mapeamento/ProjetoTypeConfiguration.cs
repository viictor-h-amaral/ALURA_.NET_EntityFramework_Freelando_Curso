using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Mapeamento
{
    internal class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> entity)
        {
            entity.ToTable("TB_Projetos");
            entity.HasKey(k => k.Id).HasName("PK_Projeto");
            entity.Property(e => e.Id).HasColumnName("ID_Projeto");
            entity.Property(e => e.Descricao).HasColumnName("DS_Projeto").HasColumnType("nvarchar(200");
        }
    }
}