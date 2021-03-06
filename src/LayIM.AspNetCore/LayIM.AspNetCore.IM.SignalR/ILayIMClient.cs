﻿using LayIM.AspNetCore.Core.Models;
using LayIM.AspNetCore.Core.Models.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LayIM.AspNetCore.IM.SignalR
{
    public interface ILayIMClient
    {
        Task Receive(object message);
    }
}
