## executar as seguintes linhas de comando para inicializar a aplicação:

```bash
## inicializar o restaurante service
docker run --name restaurante-service -p 8081:80 --network restaurante-bridge restauranteservice:1.4
```

```bash
## inicializar o banco de dados mysql
docker run --name=mysql -e MYSQL_ROOT_PASSWORD=root -d --network restaurante-bridge mysql:5.6
```

```bash
## inicializar o item service
docker run --name item-service  -d -p 8080:80 --network restaurante-bridge itemservice:1.1
```
