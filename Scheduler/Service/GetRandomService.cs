using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Scheduler.Service
{
    public class GetRandomService : HostedService
    {
        private readonly Provider _provider;

            public GetRandomService(Provider provider)
        {
            _provider = provider;
        }

        protected override Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)

            {

                await _randomStringProvider.UpdateString(cancellationToken);

                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);

            }
        }
    }
}
