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


### **發佈並執行 Console 應用程式**

#### **發佈應用程式**
```bash
dotnet publish
```
- **用途**：將 Console 應用程式進行編譯並發佈至指定目錄。

#### **檢視目錄內容**
```bash
ls -laF
```
- **用途**：檢查發佈後的檔案和目錄結構。

#### **執行 Console 應用程式**
```bash
./ConsoleApp
dotnet ./ConsoleApp.dll
```
- **用途**：執行已發佈的 Console 應用程式。


### **發佈並執行 Web 應用程式**

#### **發佈應用程式**
```bash
dotnet publish
```
- **用途**：將 Web 應用程式編譯並發佈至指定目錄。

#### **執行 Web 應用程式**
```bash
./WebApp
dotnet WebApp.dll
```
- **用途**：執行已發佈的 Web 應用程式。


### **檢視 .NET 環境資訊**

#### **顯示系統資訊**
```bash
dotnet --info
```
- **用途**：顯示目前系統中安裝的 .NET SDK 和運行時的詳細資訊。

#### **複製資訊到剪貼簿（macOS）**
```bash
dotnet --info | pbcopy
```
- **用途**：將 `dotnet --info` 的輸出複製到剪貼簿，方便後續使用。


### **設定 CLI 語言**

#### **切換為英文界面**
```bash
export DOTNET_CLI_UI_LANGUAGE=en-us
```
- **用途**：設定 .NET CLI 工具的顯示語言為英文。

#### **切換為繁體中文界面**
```bash
export DOTNET_CLI_UI_LANGUAGE=zh-tw
```
- **用途**：設定 .NET CLI 工具的顯示語言為繁體中文。

｀版本策略（最新修補版本）**
```bash
dotnet new globaljson --sdk-version 8.0.300 --roll-forward latestPatch --force
```
- **用途**：生成 `global.json`，並設定使用最新的修補版本。

#### **移除 global.json 檔案**
```bash
rm global.json
```
- **用途**：移除與 .NET SDK 版本綁定的 `global.json` 檔案。


### **檢視專案的參考與套件**

#### **列出專案的參考**
```bash
dotnet list reference
```
- **用途**：列出當前專案中添加的所有專案參考。

#### **列出專案的 NuGet 套件**
```bash
dotnet list package
```
- **用途**：列出當前專案中安裝的所有 NuGet 套件。


### **發佈應用程式**

#### **針對特定運行時發佈（macOS ARM 架構）**
```bash
dotnet publish -r osx-arm64
```
- **用途**：為 macOS ARM 架構生成適用的執行檔。

#### **不包含 App Host 的發佈**
```bash
dotnet publish -r osx-arm64 /p:UseAppHost=false
```
- **用途**：發佈應用程式，但不生成 App Host 執行檔。

#### **發佈自包含的應用程式**
```bash
dotnet publish -r osx-arm64 --self-contained
```
- **用途**：生成包含所有依賴項的自包含應用程式。

#### **進階自包含發佈選項**
```bash
dotnet publish -c Release --nologo --self-contained -r osx-arm64 -p:PublishSingleFile=true -p:DebugType=embedded -p:IncludeNativeLibrariesForSelfExtract=true -p:PublishTrimmed=true
```
- **用途**：以釋出模式發佈單一檔案的自包含應用程式，並啟用內嵌原生程式庫和修剪。


### **建立與測試 MSTest 專案**

#### **建立 MSTest 專案**
```bash
dotnet new mstest -n Mylib.Share.Test
```
- **用途**：建立一個名為 `Mylib.Share.Test` 的 MSTest 專案。

#### **新增專案參考**
```bash
dotnet add reference ../Mylib.Share/Mylib.Share.csproj
```
- **用途**：將 `Mylib.Share` 專案作為參考新增到測試專案中。

#### **將測試專案新增到解決方案**
```bash
dotnet sln aspnet-core8-day1.sln add Mylib.Share.Test/Mylib.Share.Test.csproj
```
- **用途**：將 `Mylib.Share.Test` 專案加入到解決方案中。

#### **執行測試**
```bash
dotnet test
```
- **用途**：執行解決方案中所有測試專案的測試方法。

 
