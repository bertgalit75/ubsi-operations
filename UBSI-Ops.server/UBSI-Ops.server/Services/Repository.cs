using System.Collections.Generic;
using System.Threading.Tasks;
using UBSI_Ops.server.Data;

namespace UBSI_Ops.server.Services
{
    public abstract class Repository
    {
        protected readonly OperationContext _context;

        public Repository(OperationContext context)
        {
            _context = context;
        }

        public async Task AddReferences(string type, List<string> references)
        {
            throw new System.NotImplementedException();
            //await _context.References.FindOneAndUpdateAsync(
            //     reference => reference.Type == type,
            //     Builders<Reference>.Update.AddToSetEach(reference => reference.Names, references.Except(
            //         _context.References.Find(reference => reference.Type == type).FirstOrDefault().Names
            //     )).CurrentDate(reference => reference.UpdatedAt)
            // );
        }
    }
}
