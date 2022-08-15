Run
```
docker-compose up
```

Test BMI by browsing to http://localhost:5116/swagger or, curl
```
curl -X 'GET' \
  'http://localhost:5116/Bmi?bmi=23' \
  -H 'accept: text/plain'
```