SET Sample_DBServer=localhost
SET Sample_DBUser=sa
SET Sample_DBPassword=Kvm3coder
SET Sample_SQLPackagePath="C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\Extensions\Microsoft\SQLDB\DAC\SqlPackage.exe"

%Sample_SQLPackagePath% /Action:Publish /TargetConnectionString:"Data Source=%Sample_DBServer%;initial catalog=SampleDB;User ID=%Sample_DBUser%;Password=%Sample_DBPassword%;Pooling=False;Encrypt=False" /p:BlockOnPossibleDataLoss=False /sf:"..\SampleProject.Database\bin\Debug\SampleProject.Database.dacpac"