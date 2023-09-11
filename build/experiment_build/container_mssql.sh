#!/bin/bash

nameContainer="mssql_food_api"
isCheckRun=$(docker ps --format "{{.Names}}")
if [ -n $isCheckRun -o ${#isCheckRun} -ne 0 ] 
then
    docker stop $nameContainer
    docker container rm $nameContainer
    echo "da xoa container $@"
fi

isCheckContainer=$(docker ps -aqf "name=$nameContainer")
if [ -z "${isCheckContainer}" -o ${#isCheckContainer} -eq 0 ] 
then
    # --net mySqlServer --ip 172.20.80.1
    docker run --name $nameContainer \
    -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Bombim239@2000" \
    -e "MSSQL_PID=Standard" -p 1433:1433 \
    -e --restart=always \
    -d mcr.microsoft.com/mssql/server:2019-latest
else
    docker start $nameContainer
fi

docker exec $nameContainer /opt/mssql-tools/bin/sqlcmd \
-S localhost -U sa -P "Bombim239@2000" 


