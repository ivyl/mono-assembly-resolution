all: Test.exe
	mv RenameMe.exe Renamed.exe

RenameMe.exe: RenameMe.cs
	mcs RenameMe.cs

Test.exe: Test.cs RenameMe.exe
	mcs /reference:RenameMe.exe Test.cs

clean:
	rm *.exe

.PHONY: all
