Run
```
docker-compose build
docker-compose up
```

Test BMI by browsing to http://localhost:5116/swagger or, curl
```
curl -X 'GET' \
  'http://localhost:5116/Bmi/23.5/description' \
  -H 'accept: text/plain'
```

