# ASP.NET Core 8 開發實戰：基礎知識篇

### **建立 ASP.NET Core MVC 專案**
```bash
dotnet new mvc -n WebApp -f net6.0
```
- **用途**：建立一個新的 ASP.NET Core MVC 專案，專案名稱為 `WebApp`，目標框架為 `.NET 6.0`。


### **分析專案的升級路徑**
```bash
upgrade-assistant analyze ./WebApp
```
- **用途**：使用 .NET Upgrade Assistant 工具分析專案的升級可行性，生成升級建議。


### **升級現有專案**
```bash
upgrade-assistant upgrade ./WebApp
```
- **用途**：將 `./WebApp` 專案升級到最新的 .NET 版本（例如升級到 .NET 8.0）。


### **管理 NuGet 本地緩存**
#### **檢視所有緩存路徑**
```bash
dotnet nuget locals all -l
```
- **用途**：列出所有 NuGet 的緩存目錄位置，幫助檢查緩存的檔案。

#### **清除所有緩存**
```bash
dotnet nuget locals all -c
```
- **用途**：清除所有 NuGet 緩存，適用於排除套件安裝問題或釋放磁碟空間。


### **檢視 NuGet 套件來源**
```bash
dotnet nuget list source
```
- **用途**：列出目前已配置的 NuGet 套件來源，幫助確認下載來源的正確性。


### **NuGet 配置檔案位置**
- **Mac**: `~/.nuget/NuGet/NuGet.Config`
- **Windows**: `%APPDATA%\NuGet\NuGet.config`
- **用途**：定位 NuGet 的配置檔案位置，方便手動修改或檢查。


### **建立 Console 應用程式**
```bash
dotnet new console -n ConsoleApp -f net8.0
```
- **用途**：建立一個新的 Console 應用程式，專案名稱為 `ConsoleApp`，目標框架為 `.NET 8.0`。


### **將專案新增到解決方案**
```bash
dotnet sln aspnet-core8-day1.sln add ConsoleApp/ConsoleApp.csproj
```
- **用途**：將 `ConsoleApp` 專案新增到解決方案 `aspnet-core8-day1.sln` 中，進行統一管理。


### **建立 Class Library 專案**
```bash
dotnet new classlib -n Mylib.Share -f net8.0
```
- **用途**：建立一個新的類別庫（Class Library）專案，專案名稱為 `Mylib.Share`，目標框架為 `.NET 8.0`。


### **新增 Class Library 到解決方案**
```bash
dotnet sln aspnet-core8-day1.sln add Mylib.Share/Mylib.Share.csproj
```
- **用途**：將 `Mylib.Share` 專案新增到解決方案 `aspnet-core8-day1.sln` 中。


### **生成 NuGet 套件**
```bash
dotnet pack
```
- **用途**：根據專案檔案中的 `PackageId` 和 `PackageVersion` 設定，生成 `.nupkg` NuGet 套件。


### **建立 NuGet 配置檔案**
```bash
dotnet new nuget.config
```
- **用途**：建立一個新的 `nuget.config` 配置檔案，管理自定義的 NuGet 套件來源。


### **新增自定義的 NuGet 套件來源**
```bash
dotnet nuget add source -n MyNuget ../MyNuget
```
- **用途**：將 `../MyNuget` 資料夾設定為名為 `MyNuget` 的 NuGet 套件來源。


### **安裝特定版本的 NuGet 套件**
#### **安裝 `1.0.0` 版本**
```bash
dotnet add package Mylib.Share --version 1.0.0
```
- **用途**：將 `Mylib.Share` 的 `1.0.0` 版本加入到當前專案。

#### **安裝 `1.1.0` 版本**
```bash
dotnet add package Mylib.Share --version 1.1.0
```
- **用途**：將 `Mylib.Share` 的 `1.1.0` 版本加入到當前專案。
