#!/bin/bash

nameDb1=$1
nameDb2=$2
nameDb3=$3
declare -a nameDbs
declare -a lisNameDb

nameDbs[0]=$nameDb1
nameDbs[1]=$nameDb2
nameDbs[2]=$nameDb3

#echo "${nameDbs[@]}"
# arrLength=${#nameDbs[@]}
#get name container
isExists=$(docker ps -a --format "{{.Names}}")
res1=${isExists[@]}
res=$(${res1[@]} ${nameDbs[@]} | tr '' '\n' | sort | uniq -u)
echo "${res[@]}"


# if [ -n $isExists ]
# then 
#     for item in "${nameDbs[@]}"
#         do
#             if [$item -eq ]
#             docker stop $item
#             docker rm $item
#             echo "Was Remove Container $@"
#         done
# fi


