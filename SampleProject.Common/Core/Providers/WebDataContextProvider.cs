using System.Web;
using SampleProject.Common.Data;

namespace SampleProject.Common.Core.Providers
{
    public class WebDataContextProvider : IDataContextProvider
    {
        private const string DbContext = "{E4C02911-1337-4F2E-A9B4-212B6B0157B9}";

        private static SampleDBEntities InternalContext
        {
            get => (SampleDBEntities)HttpContext.Current.Items[DbContext];
            set => HttpContext.Current.Items[DbContext] = value;
        }

        public SampleDBEntities Context
        {
            get
            {
                if (InternalContext == null)
                {
                    InternalContext = new SampleDBEntities();

                    // Force no lazy loading
                    InternalContext.Configuration.LazyLoadingEnabled = false;
                }
                return InternalContext;
            }
        }

        public void DisposeContext()
        {
            if (InternalContext == null)
                return;

            InternalContext.Dispose();
            InternalContext = null;
        }
    }
}