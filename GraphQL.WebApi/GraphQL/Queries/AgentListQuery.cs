using GraphQL.Types;
using GraphQL.WebApi.Data;
using GraphQL.WebApi.GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.GraphQL.Queries
{
    public class AgentListQuery : ObjectGraphType
    {
        private readonly ApplicationDbContext _appContext;
        public AgentListQuery(ApplicationDbContext appContext)
        {
            // this._appContext = appContext;
            // Name = "Query";
            // Field<ListGraphType<AgentListQueryGraphType>>("agentlists", "Returns a list of AgentList", resolve: context => _appContext.AgentList.ToList());
            // Field<AgentListQueryGraphType>("agentlist", "Returns a Single Agent List",
            //     new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id" }),
            //         context => _appContext.AgentList.Single(x => x.Id == context.Arguments["id"].GetPropertyValue<int>()));

            // Field<ListGraphType<AgentListQueryGraphType>>("getAgentListWithBalance", "Returns Agent List",
            // new QueryArguments(new QueryArgument<StringGraphType> { Name = "wallet", Description = "wallet" }),
            // context => _appContext.AgentList.Where(x => x.RAWallet == context.Arguments["wallet"].GetPropertyValue<string>()));


            // Field<ListGraphType<IdentityQueryGraphType>>("getIdentity", "Returns Identity",
            // new QueryArguments(new QueryArgument<StringGraphType> { Name = "wallet", Description = "wallet" }),
            // context => _appContext.AgentList.Where(x => x.RAWallet == context.Arguments["wallet"].GetPropertyValue<string>()));


            ////Field<ListGraphType<CurrentBalanceQueryGraphType>>("getCurrentBalance", "Returns Current Balance",
            //// new QueryArguments(new QueryArgument<StringGraphType> { Name = "identityId", Description = "identityId" }),
            //// context => _appContext.AgentList.Where(x => x.identityId == context.Arguments["identityId"].GetPropertyValue<string>()));


            //Field<CurrentBalanceQueryGraphType>("getCurrentBalance", "Returns Current Balance",
            // new QueryArguments(new QueryArgument<StringGraphType> { Name = "identityId", Description = "identityId" }),
            // context => _appContext.AgentList.Single(x => x.identityId == context.Arguments["identityId"].GetPropertyValue<string>()));

            this._appContext = appContext;
            Name = "Query";
            Field<ListGraphType<AgentListQueryGraphType>>("agentlists", "Returns a list of AgentList", resolve: context => _appContext.AgentList.ToList());
            Field<AgentListQueryGraphType>("agentlist", "Returns a Single Agent List",
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id" }),
                    context => _appContext.AgentList.Single(x => x.Id == context.Arguments["id"].GetPropertyValue<int>()));

            Field<ListGraphType<AgentListQueryGraphType>>("getAgentListWithBalance", "Returns Agent List",
            new QueryArguments(new QueryArgument<StringGraphType> { Name = "wallet", Description = "wallet" }),
            context => _appContext.AgentList.Where(x => x.RAWallet == context.Arguments["wallet"].GetPropertyValue<string>()));


            Field<IdentityQueryGraphType>("getIdentity", "Returns Identity",
            new QueryArguments(new QueryArgument<StringGraphType> { Name = "wallet", Description = "wallet" }),
            context => _appContext.AgentList.FirstOrDefault(x => x.RAWallet == context.Arguments["wallet"].GetPropertyValue<string>()));


            Field<CurrentBalanceQueryGraphType>("getCurrentBalance", "Returns Current Balance",
             new QueryArguments(new QueryArgument<StringGraphType> { Name = "identityId", Description = "identityId" }),
             context => _appContext.AgentList.FirstOrDefault(x => x.identityId == context.Arguments["identityId"].GetPropertyValue<string>()));


        }
    }
}
