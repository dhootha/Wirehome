﻿using System;
using HA4IoT.Contracts.Components.States;
using HA4IoT.Contracts.Components.Adapters;

namespace HA4IoT.Extensions.Core
{
    public interface IMonostableLampAdapter : ILampAdapter
    {
        event Action<PowerStateValue> StateChanged;
    }
}