using System;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;


namespace Acr.MvvmCross.Plugins.BarCodeScanner.WindowsStore {

    public class Plugin : IMvxPlugin {

        public void Load() {
            //Mvx.RegisterSingleton<IBarCodeScanner>(new DroidBarCodeScanner());
        }
    }
}