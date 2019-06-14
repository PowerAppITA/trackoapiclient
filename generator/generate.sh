#!/bin/bash

echo "Ok computer: compile the library!"
docker pull swaggerapi/swagger-codegen-cli
docker run --rm -v ${PWD}:/local swaggerapi/swagger-codegen-cli generate \
    -i https://areariservata.tracko.click/swagger/docs/v1 \
    -l csharp \
    -o /local/compiled  \
    -c /local/config.json
rsync -a --delete --exclude='.git/*' --exclude='generator/*' ./compiled/ ../

echo "Remove old files"
for i in `seq 1 5`;
    do
        echo "wait $i"
        sleep $i
    done 
rm -rf compiled