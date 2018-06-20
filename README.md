#REST-API-SelfHosted-for-WeatherServiceApp
Приложение командной строки. Реализует доступ по HTTP к кешу файлов погоды городов России, сгенерированного сервисом https://github.com/dmitrykw/WeatherParser
Так же в данном проекте реализовано приложение командной строки Client для получения этих данных по HTTP и вывода в командную строку.

Пример 

Hosting.exe "c:\WheatherParser\Data" 80
Где c:\WheatherParser\Data - каталог с кэшем городов сгенерированным программой https://github.com/dmitrykw/WeatherParser
80 - TCP порт для размещения Wеb сервера

Client.exe http://localhost:80 Питер Москва
Где http://localhost:80 - URI, к которому следует подключиться
Питер Москва - города для которых, следует извлеч информацию из текстового кэша