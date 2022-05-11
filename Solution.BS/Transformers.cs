using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Transformers : ICRUD<data.Transformers>
    {

        private SolutionDBContext _solutionDBContext = null;

        public Transformers(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public void Delete(data.Transformers t)
        {
            new Solution.DAL.Transformers(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.Transformers> GetAll()
        {
            return new Solution.DAL.Transformers(_solutionDBContext).GetAll();
        }

        public data.Transformers GetOneById(int id)
        {
            return new Solution.DAL.Transformers(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.Transformers t)
        {
            t.Id = null;
            new Solution.DAL.Transformers(_solutionDBContext).Insert(t);
        }

        public void Update(data.Transformers t)
        {
            
            new Solution.DAL.Transformers(_solutionDBContext).Update(t);
        }

    }
}
