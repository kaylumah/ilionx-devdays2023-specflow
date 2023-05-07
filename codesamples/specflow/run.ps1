$SpecflowPath = "./Test/Specflow/bin/Debug/net7.0"
dotnet test && dotnet livingdoc test-assembly "$SpecflowPath/Test.Specflow.dll" -t "$SpecflowPath/TestExecution.json"