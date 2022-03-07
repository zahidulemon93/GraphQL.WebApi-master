using GraphQL.Types;
using GraphQL.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Types
{
    class IdentityQueryGraphType : ObjectGraphType<AgentList>
    {
        public IdentityQueryGraphType()
        {
            Name = "AgentList";
            //Field(x => x.Id, type: typeof(IdGraphType)).Description("Customer Id");
            Field(x => x.identityId).Description("identity Id");
    }
    }
}
