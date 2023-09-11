#!/bin/bash

typeofvar () {

    local type_signature=$(declare -p "$1" 2>/dev/null)

    if [[ "$type_signature" =~ "declare --" ]]; then
        printf "string"
    elif [[ "$type_signature" =~ "declare -a" ]]; then
        printf "array"
    elif [[ "$type_signature" =~ "declare -A" ]]; then
        printf "map"
    else
        printf "none"
    fi

}


TagIma="{{.Tag}}"
DigestIma="{{.Digest}}"
IdIma="{{.ID}}"
SreatedAtIma="{{.CreatedAt}}"
SizeIma="{{.Size}}"

checkID="d3340c53fdcd"
checkName="latest"
IFS=","
value=$(docker images --format "$IdIma $TagIma,")
# set $value
# echo "$value"

# typeofvar value
arrvalue=($value)
# typeofvar arrvalue
# echo "${#arrvalue[0]}"
for (( i=0; i<=${#arrvalue[@]}; i++));
do
    # arr=($VAR)
    # echo "${arrvalue[$i]}"
    checkarr=(${arrvalue[$i]// /,})
    # arr1=${checkarr[@]//[[:black:]]/}
    
    # echo "${checkarr[0]}"
    if [[ ${checkarr[0]//$'\n'/} = $checkID ]];
    then
        echo "${checkarr[1]}"
    fi 
done




