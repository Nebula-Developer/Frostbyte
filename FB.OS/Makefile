.PHONY: build
MAKEFLAGS += --silent

ifeq ($(OS),Windows_NT)
	MKDIR = if not exist ..\build mkdir ..\build
else
	MKDIR = mkdir -p ../build
endif

build:
	$(MKDIR)
	@dotnet build -c Release -o ../build -p:Platform=x64 -p:Configuration=Release -p:PublishSingleFile=true -p:PublishTrimmed=true -p:PublishReadyToRun=true -p:PublishReadyToRunShowWarnings=true -p:OutputType=Exe -p:AssemblyName=Frostbyte -nologo -clp:NoSummary -v:q
