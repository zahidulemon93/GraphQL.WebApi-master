using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.WebApi.Model
{
public class AgentList
{
    public int Id { get; set; }
    public string identityId { get; set; }
    public string wallet { get; set; }
    public decimal balance { get; set; }
    public string lastUpdateTime { get; set; }
    public string RAWallet { get; set; }
    //public DateTime DateOfBirth { get; set; }
}
}
