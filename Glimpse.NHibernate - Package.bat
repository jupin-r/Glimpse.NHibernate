@echo off
powershell.exe -NoProfile -ExecutionPolicy unrestricted -Command "& {Import-Module '.\Tools\psake.4.2.0.1\tools\psake.psm1'; invoke-psake .\Glimpse.NHibernate.ps1 package; if ($lastexitcode -ne 0) {write-host "ERROR: $lastexitcode" -fore RED; exit $lastexitcode} }"
pause