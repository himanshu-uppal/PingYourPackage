﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Abstract
{
    interface IEntity
    {
        Guid Key { get; set; }
    }
}
