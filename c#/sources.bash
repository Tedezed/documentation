function csharp () {
	FILE_CSHARP=$1
	BIN_CSHARP=$(echo "$1" | cut -d "." -f1)
	mcs -out:$BIN_CSHARP $FILE_CSHARP
	./$BIN_CSHARP
	rm -f $BIN_CSHARP
}

