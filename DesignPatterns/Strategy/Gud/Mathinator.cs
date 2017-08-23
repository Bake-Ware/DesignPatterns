using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy.Gud
{
    public class Mathinator : IDisposable
    {
        public double MathinateAverage(List<double> values, IMathinatorMethod mathinatingMethod)
        {
            return mathinatingMethod.MathinateFor(values);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        ~Mathinator() {
          Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
