using Solution.DAL.EF;

using Solution.DAL.Repositoy;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.DAL
{
    public class Transformers : ICRUD<data.Transformers>
    {
        private Repository<data.Transformers> _repository = null;

        public Transformers(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.Transformers>(solutionDBContext);
        }

        public void Delete(data.Transformers t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.Transformers> GetAll()
        {
            return _repository.GetAll();
        }

        public data.Transformers GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.Transformers t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.Transformers t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
