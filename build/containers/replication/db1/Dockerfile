FROM mcr.microsoft.com/mssql/server:2019-latest
COPY . /

USER root
# Run mkdir -p /usr/src/app
WORKDIR /usr/src/app/

COPY ./ /usr/src/app/
RUN chmod +x ./db-init.sh
CMD /bin/bash ./entrypoint.sh