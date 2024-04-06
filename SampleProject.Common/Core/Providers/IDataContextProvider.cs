using SampleProject.Common.Data;

namespace SampleProject.Common.Core.Providers
{
    public interface IDataContextProvider
    {
        SampleDBEntities Context
        {
            get;
        }

        void DisposeContext();
    }
}