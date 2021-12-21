using OvertimeRequestSystem.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OvertimeRequestSystem.Models;
using OvertimeRequestSystem.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvertimeRequestSystem.Controllers.NewControllers
{
    [Route("OvertimeRequestSystem/[controller]")]
    [ApiController]
    public class AccountsController : BaseController<Account, AccountRepository, int>
    {
        private AccountRepository AccountRepository;
        public AccountsController(AccountRepository repository) : base(repository)
        {
            this.AccountRepository = repository;
        }
    }
}
