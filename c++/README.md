# C++

Compile: `g++  hola.cpp -o hola`

Execute: `./hola`

source.bash
```
function c+++ () {
	FILE_CPP=$1
	BIN_CPP=$(echo "$1" | cut -d "." -f1)
	g++ $FILE_CPP -o $BIN_CPP
	./$BIN_CPP
	rm -f $BIN_CPP
}
```

### Guides:
- https://www.geeksforgeeks.org/object-oriented-programming-in-cpp/
- https://www.programiz.com/cpp-programming