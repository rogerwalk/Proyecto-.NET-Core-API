using Solution.DAL.EF;

using Solution.DAL.Repositoy;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;
namespace Solution.DAL
{
   public class DragonBall : ICRUD<data.DragonBall>
    {
        private Repository<data.DragonBall> _repository = null;

        public DragonBall(SolutionDBContext solutionDBContext)
        {
            _repository = new Repository<data.DragonBall>(solutionDBContext);
        }

        public void Delete(data.DragonBall t)
        {
            _repository.Delete(t);
            _repository.Commit();
        }

        public IEnumerable<data.DragonBall> GetAll()
        {
            return _repository.GetAll();
        }

        public data.DragonBall GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public void Insert(data.DragonBall t)
        {
            _repository.Insert(t);
            _repository.Commit();
        }

        public void Update(data.DragonBall t)
        {
            _repository.Update(t);
            _repository.Commit();
        }
    }
}
