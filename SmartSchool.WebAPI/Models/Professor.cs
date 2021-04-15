using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor() {}
        public Professor(int id, int nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public int Nome { get; set; }

        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}