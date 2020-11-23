using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Services
{
    public class CommonService
    {
        protected readonly ILogger logger;
        protected readonly UnitOfWork unitOfWork;
        public CommonService(ILogger logger, UnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }
    }
}
