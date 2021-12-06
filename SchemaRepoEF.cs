using MdsMessageSchema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MdsMessageSchema.Repo
{
    public class SchemaRepoEF : ISchemaRepo
    {
        private readonly SchemaDbContext context;       

        public SchemaRepoEF(SchemaDbContext ctx) =>
            context = ctx;
        
        public IQueryable<SchemaItem> SchemaItems =>
            context.SchemaItems;

    }
}
