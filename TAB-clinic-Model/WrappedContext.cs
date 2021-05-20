using System;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Wraps a ClinicDBContext so that Services or Forms don't need references to the Data library.
    /// </summary>
    public class WrappedContext : IDisposable
    {
        internal ClinicDBContext Context { get; } = new();

        public void SaveChanges() => Context.SaveChanges();

        #region boring stuff
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    Context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~WrappedContext()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
