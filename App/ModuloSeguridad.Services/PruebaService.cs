using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Services
{
    public class PruebaService : CommonService
    {
        public PruebaService(ILogger logger, UnitOfWork unitOfWork) : base(logger, unitOfWork)
        {
            logger.LogInformation("ENTRO");
        }
    }
}
