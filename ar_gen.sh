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
pushd ${LIB_NAME}
autorest --input-file=https://www.pixelshift.io/swagger/v1/swagger.json --csharp --output-folder=. --namespace=${LIB_NAME} --generate-empty-classes 
popd
