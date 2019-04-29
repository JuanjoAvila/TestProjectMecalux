using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectMecalux.Interface;
using TestProjectMecalux.Methods;

namespace TestProjectMecaluxTextTests.Methods
{
    public static class Register
    {
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<TextPhraseMethods>().As<ITextMethods>();
           
        }
    }
}
