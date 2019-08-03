using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Trust.Wallet.Core.RNTrustWalletCore
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTrustWalletCoreModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTrustWalletCoreModule"/>.
        /// </summary>
        internal RNTrustWalletCoreModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTrustWalletCore";
            }
        }
    }
}
