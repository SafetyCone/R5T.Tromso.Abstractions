using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace R5T.Tromso
{
    /// <summary>
    /// Provides an interface for a service that can be built by configuring its <see cref="IConfigurationBuilder"/>.
    /// It is up to the implementation to decide whether the service can be built more than once.
    /// </summary>
    public interface IBuildableService
    {
        IConfigurationBuilder ConfigurationBuilder { get; }
        IServiceCollection ServiceCollection { get; }
        IServiceProvider ServiceProvider { get; }
    }
}
