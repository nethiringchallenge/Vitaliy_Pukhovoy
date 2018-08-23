using System;
using Autofac;
using OfficeSpace;
using Autofac.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


static class AutofacConfig
{
    public static IContainer ConfigureContainer( Dictionary<int, int> dic, int[] cubicles, int cubicle, int personInTeam)
    {
        var builder = new ContainerBuilder();

        builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
               .AsImplementedInterfaces();

       
        builder.RegisterType<FindingSpaceForTeam>().As<IFindingSpace>()
               .WithParameters(new List<Parameter> {
                new NamedParameter("_dic", dic),
                new NamedParameter("_cubicles", cubicles),
                new NamedParameter("_cubicle", cubicle),
                new NamedParameter("_personInTeam", personInTeam)
               });
        builder.RegisterType<FillingData>().As<IFillingData>()
               .WithParameters(new List<Parameter> {
                new NamedParameter("_dic", dic) });

        //var container = builder.Build();
        return builder.Build();

        //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
    }
}

