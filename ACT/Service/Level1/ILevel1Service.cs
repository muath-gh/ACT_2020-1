﻿using ACT.Models;
using ACT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACT.Service
{
 
    public interface ILevel1Service : IGenericService<Level1>
    {
        void UpdateDefaultFalse();
    }
}