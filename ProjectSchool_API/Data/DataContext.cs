using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectSchool_API.Models;

namespace ProjectSchool_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Professor>()
            .HasData(
                new List<Professor>(){
                    new Professor(){
                        ID = 1,
                        Nome = "Daniel"
                    },
                    new Professor(){
                        ID = 2,
                        Nome = "Vinicius"
                    },
                    new Professor(){
                        ID = 3,
                        Nome = "Paula"
                    }
                }
            );

            builder.Entity<Aluno>()
                .HasData(
                    new List<Aluno>(){
                        new Aluno(){
                            ID = 1,
                            Nome = "Maria",
                            Sobrenome = "José",
                            DataNasc = "01/01/2000",
                            ProfessorId = 1
                        },
                        new Aluno(){
                            ID = 2,
                            Nome = "João",
                            Sobrenome = "Paulo",
                            DataNasc = "20/01/1990",
                            ProfessorId = 2
                        },
                        new Aluno(){
                            ID = 3,
                            Nome = "Alex",
                            Sobrenome = "Feraz",
                            DataNasc = "25/06/1981",
                            ProfessorId = 3
                        }
    }
);
        }
    }
}