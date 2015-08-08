echo merging s3pi
cd ./dlls
ILMerge.exe /target:library /out:../s3pi.dll s3pi.CASPartResource.dll s3pi.CatalogResource.dll s3pi.ComplateResource.dll s3pi.Controls.dll s3pi.CustomForms.dll s3pi.DefaultResource.dll s3pi.Extensions.dll s3pi.GenericRCOLResource.dll s3pi.Helpers.dll s3pi.ImageResource.dll s3pi.Interfaces.dll s3pi.JazzResource.dll s3pi.ModularResource.dll s3pi.NameMapResource.dll s3pi.NGMPHashMapResource.dll s3pi.ObjKeyResource.dll s3pi.Package.dll s3pi.RCOLChunks.dll s3pi.ScriptResource.dll s3pi.Settings.dll s3pi.StblResource.dll s3pi.TextResource.dll s3pi.TxtcResource.dll s3pi.WrapperDealer.dll System.Custom.dll

echo merged to s3pi.dll
pause