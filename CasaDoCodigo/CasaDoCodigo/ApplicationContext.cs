﻿using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CasaDoCodigo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(t => t.Id);

            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido);
            //modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro);
            //modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).HasForeignKey<Cadastro>(t => t.Id).IsRequired();
            modelBuilder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).HasForeignKey<Cadastro>("PedidoId").IsRequired();

            modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            modelBuilder.Entity<ItemPedido>().HasOne(t => t.Pedido);
            modelBuilder.Entity<ItemPedido>().HasOne(t => t.Produto); 

            modelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
            modelBuilder.Entity<Cadastro>().HasOne(t => t.Pedido);
           // modelBuilder.Entity<Cadastro>().HasMany(t => t.Pedidos);
            //modelBuilder.Entity<Cadastro>().HasOne(t => t.Pedido).WithOne(t => t.Cadastro).HasForeignKey<Pedido>(t => t.Id).IsRequired();
        }
    }
}
