FROM mcr.microsoft.com/mssql/server:2019-latest

# Access use root in MSSQl Server
user root
# Run mkdir -p /usr/src/app
WORKDIR /usr/src/app/
COPY ./ /usr/src/app/

user root
RUN chmod +x ./run-initialization.shs

