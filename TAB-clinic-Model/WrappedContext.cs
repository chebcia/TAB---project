using System;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Wraps a ClinicDBContext so that Services or Forms don't need references to the Data library.
    /// </summary>
    public class WrappedContext : IDisposable
    {
        internal ClinicDBContext Context { get; private set; } = new();

        public void SaveChanges() => Context.SaveChanges();

        /// <summary>
        /// Replaces the internal context with a new one (and also abandons unsaved changes).
        /// </summary>
        public void Refresh()
        {
            Context.Dispose();
            Context = new();
        }

        #region IDisposable implementation - boring stuff, no need to call it
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects)
                    Context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
