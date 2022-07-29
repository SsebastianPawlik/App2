using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace StanAplikacjiXAML
{
    internal class SuspensionManager
    {
        public static string CurrnetQuery { get; set; }
        private const string filename = "_sessionState.txt";
        static async public Task SaveAsync()
        {
            if (String.IsNullOrEmpty(CurrnetQuery))
                CurrnetQuery = String.Empty;
            IStorageFile storageFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(storageFile, CurrnetQuery);
        }
        static async public Task RestoreAsync()
        {
            IStorageFile storageFile = await ApplicationData.Current.LocalFolder.GetFileAsync(filename);
            CurrnetQuery = await FileIO.ReadTextAsync(storageFile);
        }
    }
}
