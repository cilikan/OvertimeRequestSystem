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
    public class EmployeesController : BaseController<Employee, EmployeeRepository, int>
    {
        private EmployeeRepository EmployeeRepository;
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {
            this.EmployeeRepository = repository;
        }
    }
}
