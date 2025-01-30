action := ./action/function.cs ./action/globalEntry.cs ./action/library.cs ./action/operation.cs ./action/variable.cs
dataTypes := ./dataTypes/boolean.cs ./dataTypes/dictionary.cs ./dataTypes/dictionaryItem.cs ./dataTypes/list.cs ./dataTypes/numeric.cs ./dataTypes/text.cs
tokenizer := ./tokenizer/textTokenizer.cs 

make:
	mcs ./main.cs ${tokenizer} ${action} -out:SLI.exe

clean:
	rm ./main.exe