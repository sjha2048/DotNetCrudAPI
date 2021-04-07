# .NET Core Rest API (CRUD)

## Methods

- GET (One Record)
- GET (All Records)
- POST 
- PATCH
- DELETE

## Run Via Docker

```docker pull sjha2048/hanu-student-api``` 

The solution will run on PORT 8080 if run via docker.

## Method Definitions

### GET (One Record)

```/api/student/<id>```

### GET (All Records)

```/api/student/```

### POST (Add Student)

```/api/student/```

Body: 

```
{
    "name" : "Sahil",
    "LastName": "Jha",
    "rollNo": 3
}
```

### PATCH (Update Student)

```/api/student/<id>```

```
{
    "name" : "sahil",
    "LastName": "jha",
    "rollNo": 5
}
```

### DEL (Delete Student)

```/api/student/<id>```