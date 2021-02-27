using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public IFormFile Files { get; set; }
    }
}
