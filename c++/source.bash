function c+++ () {
	FILE_CPP=$1
	BIN_CPP=$(echo "$1" | cut -d "." -f1)
	g++ $FILE_CPP -o $BIN_CPP
	./$BIN_CPP
	rm -f $BIN_CPP
}
