﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRMSystem.Domains
{
    public interface ISaleService
    {
        Task<int> Save(Sale data);
    }
}
