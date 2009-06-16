using System;
using System.Collections.Generic;
using System.Text;

namespace WiiDesktop.Common
{
    public interface Observer
    {
        void Update(object subject);
    }

}
