using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.wwwroot.Atributes
{
    [AttributeUsage(AttributeTargets.Method)]

    public class IgnoreAttribute : Attribute
    {
    }
}
