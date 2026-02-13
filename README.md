# dotnet aspire 

## Run the project
```
dotnet run --project AspireSqliteApp.AppHost
```

## Endpoints

### Push Item
```
curl -X POST http://localhost:5384/items \
-H "Content-Type: application/json" \
-d '{"name":"Test Item"}'
```

### Get Item
```
curl http://localhost:5384/items
```