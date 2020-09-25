using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace BizTalkComponents.WCFCustomExtensions.EnableTLS12Behaviour
{
    public sealed class EnableTLS12BehaviorExtension : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(EnableTLS12EndPointBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new EnableTLS12EndPointBehavior();
        }
    }
}
