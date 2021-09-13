using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EntityRepositoryBase<User, LibraryContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join useroperationClaims in context.UserOperationClaims
           on operationClaim.Id equals useroperationClaims.OperationClaimsId
                             join users in context.Users on
                             useroperationClaims.UserId equals users.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
