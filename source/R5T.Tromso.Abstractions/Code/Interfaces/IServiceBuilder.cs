using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace R5T.Tromso
{
    /// <summary>
    /// Provides an abstraction to which actions to configure an <see cref="IConfigurationBuilder"/>, an <see cref="IServiceCollection"/>, and an <see cref="IServiceProvider"/> can be added.
    /// </summary>
    public interface IServiceBuilder
    {
        void AddConfigureConfiguration(Action<IConfigurationBuilder, IServiceProvider> configureConfigurationAction);
        void AddConfigureServices(Action<IServiceCollection> configureServicesAction);
        void AddConfigure(Action<IServiceProvider> configureAction);

        /// <summary>
        /// Builds a service by applying all actions.
        /// </summary>
        void Build(IServiceProvider configurationServiceProvider);
    }
}
