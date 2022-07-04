using Microsoft.EntityFrameworkCore;
using RS2_seminarski_tattoostudio.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_seminarski_tattoostudio
{
    public class SetupService
    {
        public void Init(TattooStudioRSIIContext context)
        {
            context.Database.Migrate();
        }
    }
}
