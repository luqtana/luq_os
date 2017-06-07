using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebAppOS.Models;

namespace WebAppOS.DAL
{
    public class Contexto : DbContext
    {
        public Contexto()

            :base("strConexao")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet <Tecnico> Tecnicos{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            //removendo pluralização e deleção em cascata.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Mapeamento para a heranças de Pessoa - PessoaFisica e PessoaJuridica
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoaFisica");
            modelBuilder.Entity<PessoaJuridica>().ToTable("PessoaJuridica");


        }


    }
}