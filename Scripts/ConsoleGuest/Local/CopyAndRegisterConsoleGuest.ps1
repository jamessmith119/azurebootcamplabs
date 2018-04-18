Connect-ServiceFabricCluster
Copy-ServiceFabricApplicationPackage -ApplicationPackagePath ..\..\..\Packages\ConsoleGuest
Register-ServiceFabricApplicationType ConsoleGuest