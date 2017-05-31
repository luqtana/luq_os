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

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet <Tecnico> Tecnicos{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            //removendo pluralização e deleção em cascata.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();





        }


    }
}