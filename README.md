
# react-native-trust-wallet-core

## Getting started

`$ npm install react-native-trust-wallet-core --save`

### Mostly automatic installation

`$ react-native link react-native-trust-wallet-core`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-trust-wallet-core` and add `RNTrustWalletCore.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNTrustWalletCore.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNTrustWalletCorePackage;` to the imports at the top of the file
  - Add `new RNTrustWalletCorePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-trust-wallet-core'
  	project(':react-native-trust-wallet-core').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-trust-wallet-core/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-trust-wallet-core')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNTrustWalletCore.sln` in `node_modules/react-native-trust-wallet-core/windows/RNTrustWalletCore.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Trust.Wallet.Core.RNTrustWalletCore;` to the usings at the top of the file
  - Add `new RNTrustWalletCorePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNTrustWalletCore from 'react-native-trust-wallet-core';

// TODO: What to do with the module?
RNTrustWalletCore;
```
  