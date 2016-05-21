using Services;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.Mvc5;

namespace CodeSamples
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            /*
             * I haved moved unity configuration to separate file which enable us to do modifications 
             * without recompiling existing application. 
             * We can do this by adding config section to web.config file as below.
             */
            //container.RegisterType<ICourseService, CourseService>();
            //container.RegisterType<IInstitutionService, InstitutionService>();
            container.LoadConfiguration();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}