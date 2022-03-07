using GraphQL.Types;
using GraphQL.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Types
{
    class CurrentBalanceQueryGraphType : ObjectGraphType<AgentList>
    {
        public CurrentBalanceQueryGraphType()
        {
            Name = "AgentList";
            //Field(x => x.Id, type: typeof(IdGraphType)).Description("Customer Id");
            Field(x => x.currentBalance).Description("currentBalance");
        }
    }
}
