#!/usr/bin/env bash
CDIR=$1
if [ -z "$1" ]; then
    CDIR="."
fi
mkdir -p ${CDIR}
cd ${CDIR}
DIR_NAME=$(basename $(pwd))
LIB_NAME=${DIR_NAME}".Autorest"
mkdir -p ${LIB_NAME}
dotnet new sln
pushd ${LIB_NAME}
dotnet new classlib
rm Class1.cs
autorest --input-file=https://www.pixelshift.io/swagger/v1/swagger.json --csharp --output-folder=. --namespace=${LIB_NAME} --generate-empty-classes 
dotnet add package Microsoft.Rest.ClientRuntime --version 2.3.13 
dotnet add package Newtonsoft.Json
dotnet add package Microsoft.AspNet.WebApi.Client
popd
dotnet sln add ${LIB_NAME}/${LIB_NAME}".csproj"
