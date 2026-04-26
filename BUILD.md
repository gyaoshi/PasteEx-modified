# 编译说明

## 编译方法

### 方法一：使用批处理文件（推荐）
1. 双击运行项目根目录下的 `build.bat` 文件
2. 等待编译完成
3. 编译成功后，可执行文件会生成在 `PasteEx` 目录下

### 方法二：手动编译
1. 打开命令提示符（cmd）
2. 切换到 `PasteEx` 目录
3. 运行以下命令：
   ```cmd
   "C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe" /noconfig /nowarn:1701,1702 /nostdlib+ /platform:anycpu32bitpreferred /errorreport:prompt /warn:3 /define:TRACE /highentropyva+ /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\Microsoft.CSharp.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Configuration.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Core.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Data.DataSetExtensions.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Data.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Deployment.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Drawing.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Management.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Net.Http.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Web.Extensions.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Windows.Forms.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Xml.dll" /reference:"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\System.Xml.Linq.dll" /resource:obj\Release\PasteEx.Forms.FormInfo.resources /resource:obj\Release\PasteEx.Forms.FormMain.resources /resource:obj\Release\PasteEx.Forms.FormMain.zh-CN.resources /resource:obj\Release\PasteEx.Forms.FormMain.zh-Hant.resources /resource:obj\Release\PasteEx.Forms.FormSetting.resources /resource:obj\Release\PasteEx.Forms.FormSetting.zh-CN.resources /resource:obj\Release\PasteEx.Forms.FormSetting.zh-Hant.resources /resource:obj\Release\PasteEx.Properties.Resources.resources /resource:obj\Release\PasteEx.Resources.Strings.resources /resource:obj\Release\PasteEx.Resources.Strings.zh-CN.resources /resource:obj\Release\PasteEx.Resources.Strings.zh-Hant.resources /debug:pdbonly /filealign:512 /nowin32manifest /optimize+ /out:PasteEx.exe /subsystemversion:6.00 /target:winexe /utf8output /win32icon:Resources\Image\ico.ico Core\AppCopyFilter.cs Core\ClipboardData.cs Core\ClipboardMonitor.cs Core\History\PasteResult.cs Core\History\PasteResultHistory.cs Core\History\PasteResultHistoryHelper.cs Core\ModeController.cs Core\Processor\Assist\HTMLFormat.cs Forms\FormInfo.cs Forms\FormInfo.Designer.cs Forms\Hotkey\Hotkey.cs Forms\Hotkey\HotkeyTextBox.cs Forms\PathGenerator.cs Library\Kernel32.cs Core\Processor\BaseProcessor.cs Core\Processor\FileProcessor.cs Core\Processor\HtmlProcessor.cs Core\Processor\ImageProcessor.cs Core\Processor\RtfProcessor.cs Core\Processor\TextProcessor.cs Forms\FormMain.cs Forms\FormMain.Designer.cs Forms\FormSetting.cs Forms\FormSetting.Designer.cs Client.cs Library\User32.cs Properties\Resources.Designer.cs Resources\Strings.Designer.cs Resources\Strings.zh-Hant.Designer.cs Settings.cs Util\AppInfo.cs Util\ApplicationHelper.cs Util\CLIHelper.cs Util\CommandLine.cs Util\Device.cs Util\GAHelper.cs Util\HttpUtil.cs Util\I18n.cs Core\Processor\Assist\ImageHelper.cs Forms\Hotkey\HotkeyHook.cs Util\Logger.cs MySettingsProvider.cs Program.cs Properties\AssemblyInfo.cs Resources\Strings.zh-CN.Designer.cs Util\ObjectHelper.cs Util\RightMenu.cs Util\UpdateRepairer.cs Properties\Settings.Designer.cs
   ```

## 编译环境要求

### 1. .NET Framework 4.7.2
- 确保已安装 .NET Framework 4.7.2 或更高版本
- 下载地址：https://dotnet.microsoft.com/download/dotnet-framework/net472

### 2. C# 编译器
- 系统自带的 `csc.exe` 编译器（位于 `C:\Windows\Microsoft.NET\Framework\v4.0.30319\`）

### 3. 资源文件
- 编译前确保 `obj\Release` 目录下存在以下资源文件：
  - `PasteEx.Forms.FormInfo.resources`
  - `PasteEx.Forms.FormMain.resources`
  - `PasteEx.Forms.FormMain.zh-CN.resources`
  - `PasteEx.Forms.FormMain.zh-Hant.resources`
  - `PasteEx.Forms.FormSetting.resources`
  - `PasteEx.Forms.FormSetting.zh-CN.resources`
  - `PasteEx.Forms.FormSetting.zh-Hant.resources`
  - `PasteEx.Properties.Resources.resources`
  - `PasteEx.Resources.Strings.resources`
  - `PasteEx.Resources.Strings.zh-CN.resources`
  - `PasteEx.Resources.Strings.zh-Hant.resources`

## 注意事项

1. **编译警告**：编译过程中可能会出现一个关于未使用变量的警告，这不会影响程序的正常运行。

2. **资源文件**：如果 `obj\Release` 目录下没有资源文件，需要先使用 MSBuild 或 Visual Studio 编译一次项目，生成资源文件。

3. **运行环境**：编译生成的可执行文件需要在安装了 .NET Framework 4.7.2 或更高版本的 Windows 系统上运行。

4. **权限**：编译和运行时可能需要管理员权限，特别是当程序需要修改注册表或系统设置时。

## 故障排除

### 1. 资源文件缺失
- 错误信息：`System.Resources.MissingManifestResourceException`
- 解决方法：确保资源文件已正确生成并嵌入到可执行文件中

### 2. 编译器找不到
- 错误信息：`'csc.exe' 不是内部或外部命令，也不是可运行的程序`
- 解决方法：检查 `csc.exe` 的路径是否正确，或使用完整路径

### 3. 引用缺失
- 错误信息：`找不到类型或命名空间名称`
- 解决方法：确保所有必要的引用都已添加到编译命令中

## 输出文件

- **可执行文件**：`PasteEx\PasteEx.exe`
- **调试信息**：`PasteEx\PasteEx.pdb`

编译完成后，您可以直接运行 `PasteEx.exe` 来使用应用程序。