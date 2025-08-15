using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllInjector
{
    internal class DllListManager
    {

        private readonly List<string> dllList;
        public DllListManager()
        {
            dllList = new List<string>();
        }

        public void AddDll(string dllPath)
        {
            if (!dllList.Contains(dllPath))
            {
                dllList.Add(dllPath);
            }
        }

        public void RemoveDll(string dllPath)
        {
            if (dllList.Contains(dllPath))
            {
                dllList.Remove(dllPath);
            }
        }
        public IReadOnlyCollection<string> GetDlls()
        {
            return dllList.AsReadOnly();
        }

        public void ClearDlls()
        {
            dllList.Clear();
        }
    }
}
