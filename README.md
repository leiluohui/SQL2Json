Sql2Json
========

convert sql query result to json

Convert to UWP
========

*Step 1:*
Make MSI installer

*Step 2:*
DesktopAppConverter.exe -Setup -BaseImage "C:\Workspace\Windows10DesktopAppConverter\BaseImage-14393.wim"
DesktopAppConverter.exe -Installer "C:\Edi-GitHub\Sql2Json\SqlToJson\Sql2JsonSetup\Release\Sql2JsonSetup.msi" -Destination "C:\Edi-GitHub\Sql2Json\AppxOutput" -PackageName "SQL2Json" -Publisher "CN=ISAAC\Edi.Wang" -Version 1.0.0.0 -MakeAppx -Sign -Verbose

*Step 3:*
Create UWP App and Associate with Store, merge and edit C:\Edi-GitHub\Sql2Json\AppxOutput\SQL2Json\PackageFiles\AppxManifest.xml

`
<?xml version="1.0" encoding="utf-8"?>
<Package xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10" xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10" xmlns:uap2="http://schemas.microsoft.com/appx/manifest/uap/windows10/2" xmlns:uap3="http://schemas.microsoft.com/appx/manifest/uap/windows10/3" xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities" xmlns:desktop="http://schemas.microsoft.com/appx/manifest/desktop/windows10">
  <Identity Name="58027.SQL2Json" Publisher="CN=DB299AFD-CD90-4B49-8407-33F11AF0C784" Version="1.1.0.0" />
  <Properties>
    <DisplayName>SQL2Json</DisplayName>
    <PublisherDisplayName>汪宇杰</PublisherDisplayName>
    <Logo>Assets\NewStoreLogo.scale-400.png</Logo>
  </Properties>
  <Resources>
    <Resource Language="en-us" />
  </Resources>
  <Dependencies>
    <TargetDeviceFamily Name="Windows.Desktop" MinVersion="10.0.14393.0" MaxVersionTested="10.0.14393.0" />
  </Dependencies>
  <Capabilities>
    <rescap:Capability Name="runFullTrust" />
  </Capabilities>
  <Applications>
    <Application Id="SQL2Json" Executable="SqlToJson.exe" EntryPoint="Windows.FullTrustApplication">
      <uap:VisualElements DisplayName="SQL2Json" Description="SQL2Json" BackgroundColor="transparent" Square150x150Logo="Assets\Square150x150Logo.scale-400.png" Square44x44Logo="Assets\Square44x44Logo.targetsize-32.png">
      </uap:VisualElements>
      <Extensions />
    </Application>
  </Applications>
</Package>
`

Step 4:
Sign the Appx

CMD C:\Program Files (x86)\Windows Kits\10\bin\x64>

signtool.exe sign -f "C:\Edi-GitHub\Sql2Json\SqlToJson\UWPTemplate\UWPTemplate_StoreKey.pfx" -fd SHA256 -v "C:\Edi-GitHub\Sql2Json\AppxOutput\SQL2Json.appx"
