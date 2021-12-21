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
    public class ResponsesController : BaseController<Response, ResponseRepository, int>
    {
        private ResponseRepository ResponseRepository;
        public ResponsesController(ResponseRepository repository) : base(repository)
        {
            this.ResponseRepository = repository;
        }
    }
}
