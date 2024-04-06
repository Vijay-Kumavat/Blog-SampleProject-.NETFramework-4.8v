using SampleProject.Common.Core.Providers;
using SampleProject.Common.Data;

namespace SampleProject.Common.Core
{
    public class DataContext
    {
        private static IDataContextProvider _provider;

        public static SampleDBEntities Context => _provider.Context;

        static DataContext()
        {
            ResetProvider();
        }

        public static void ResetProvider()
        {
            SetDataContextProvider(new WebDataContextProvider());
        }

        public static void SetDataContextProvider(IDataContextProvider provider)
        {
            _provider = provider;
        }
    }
}
