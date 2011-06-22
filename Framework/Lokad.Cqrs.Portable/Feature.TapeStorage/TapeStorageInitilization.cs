﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lokad.Cqrs.Feature.TapeStorage
{
    public sealed class TapeStorageInitilization : IEngineProcess
    {
        readonly IEnumerable<ISingleThreadTapeWriterFactory> _storage;
        public TapeStorageInitilization(IEnumerable<ISingleThreadTapeWriterFactory> storage)
        {
            _storage = storage;
        }

        public void Dispose()
        {
            
        }

        public void Initialize()
        {
            foreach (var factory in _storage)
            {
                factory.Initialize();
            }
        }

        public Task Start(CancellationToken token)
        {
            // don't do anything
            return new Task(() => { });
        }
    }
}