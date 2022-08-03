using System;
using PCStore.Component;

namespace PCStore.Decorator
{
    public abstract class ComponentDecorator : Computer
    {
        public override abstract decimal CalculateCost();
    }
}

