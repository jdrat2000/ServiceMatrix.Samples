﻿using NServiceBus;

namespace Amazon.ECommerce
{
    public class MessageConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
            .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("Amazon.InternalMessages"))
            .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("Amazon.Contracts"));
        }
    }
}
