action := ./action/function.cs ./action/globalEntry.cs ./action/library.cs ./action/operation.cs ./action/variable.cs
dataTypes := 

make:
	mcs ./main.cs ./action/function.cs ./action/library.cs ./action/operation.cs ./action/variable.cs

clean:
	rm ./main.exe