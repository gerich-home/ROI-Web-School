using System;

namespace BusinessLogic
{

        internal enum ServiceOption
        {
            Singleton,
            PerResolve
        }

        [AttributeUsage(AttributeTargets.Class)]
        internal class ServiceAttribute : Attribute
        {
            public ServiceOption Option { get; set; }

            public ServiceAttribute(ServiceOption option)
            {
                Option = option;
            }
        }
    
}
