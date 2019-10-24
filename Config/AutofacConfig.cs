using Autofac;
using Logics;
using Interfaces;
using Storage;
using Autofac.Extensions.DependencyInjection;

namespace Config
{
    public class AutofacConfig
    {
        public static void ConfigureContainer(ContainerBuilder builder)
        {

            // регистрируем споставление типов
            builder.RegisterType<MaterialService>().As<IMaterialService>();
            builder.RegisterType<WorkflowOpimizationDBContext>().As<IStorageContext>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            // установка сопоставителя зависимостей
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
