using OvertimeRequestSystem.Context;
using OvertimeRequestSystem.Repository;
using OvertimeRequestSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeRequestSystem.Repository.Data
{
    public class ResponseRepository : GeneralRepository<MyContext, Response, int>
    {
        private readonly MyContext context;
        public ResponseRepository(MyContext myContext) : base(myContext)
        {
            this.context = myContext;
        }
    }
}
