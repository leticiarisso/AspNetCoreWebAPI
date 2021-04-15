using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
    public interface IRepository
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         bool SaveChanges();


        //Alunos

        public Aluno[] GetAllAlunos(bool includeProfessor = false);

        public Aluno[] GetAllAlunosByDisciplina(int disciplinaId, bool includeProfessor = false);

        public Aluno GetAlunoById(int alunoId, bool includeProfessor = false);


        //Professores

        public Professor[] GetAllProfessores(bool includeAlunos = false);

        public Professor[] GetAllProfessoresByDisciplina(int disciplinaId, bool includeAlunos = false);

        public Professor GetProfessorById(int professorId, bool includeProfessor = false);


    }
}