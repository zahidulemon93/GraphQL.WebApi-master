using GraphQL.Types;
using GraphQL.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Types
{
    class AgentListQueryGraphType : ObjectGraphType<AgentList>
    {
        public AgentListQueryGraphType()
        {
            Name = "AgentList";
            //Field(x => x.Id, type: typeof(IdGraphType)).Description("Customer Id");
            Field(x => x.identityId).Description("identity Id");
            Field(x => x.wallet).Description("wallet");
            Field(x => x.RAWallet).Description("RAWallet");
            Field(x => x.balance).Description("balance");
            Field(x => x.lastUpdateTime).Description("last Update Time");
    }
    }
}
