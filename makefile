make:
	mcs ./main.cs ./action/function.cs ./action/library.cs ./action/operation.cs ./action/variable.cs

clean:
	rm ./main.exe