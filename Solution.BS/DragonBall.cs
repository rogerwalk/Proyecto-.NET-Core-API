using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class DragonBall : ICRUD<data.DragonBall>
    {

        private SolutionDBContext _solutionDBContext = null;

        public DragonBall(SolutionDBContext solutionDBContext)
        {
            _solutionDBContext = solutionDBContext;
        }

        public void Delete(data.DragonBall t)
        {
            new Solution.DAL.DragonBall(_solutionDBContext).Delete(t);
        }

        public IEnumerable<data.DragonBall> GetAll()
        {
            return new Solution.DAL.DragonBall(_solutionDBContext).GetAll();
        }

        public data.DragonBall GetOneById(int id)
        {
            return new Solution.DAL.DragonBall(_solutionDBContext).GetOneById(id);
        }

        public void Insert(data.DragonBall t)
        {
            t.Id = null;

            new Solution.DAL.DragonBall(_solutionDBContext).Insert(t);
        }

        public void Update(data.DragonBall t)
        {
            
            new Solution.DAL.DragonBall(_solutionDBContext).Update(t);
        }

    }
}
