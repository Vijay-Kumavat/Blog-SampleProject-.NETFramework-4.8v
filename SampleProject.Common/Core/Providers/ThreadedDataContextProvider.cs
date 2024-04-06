namespace EBev.Data.DAO.Providers
{
    public class ThreadedDataContextProvider : IDataContextProvider
    {
        private readonly object _syncRoot = new object();
        private static EBevDataModelEntities _context;

        public EBevDataModelEntities Context
        {
            get
            {
                lock (_syncRoot)
                {
                    return _context ?? (_context = new EBevDataModelEntities());
                }
            }
        }

        public void DisposeContext()
        {
        }
    }
}