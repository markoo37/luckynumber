var express = require('express')
var bodyParser = require('body-parser')
var mysql = require('mysql')
const swaggerJSDoc = require('swagger-jsdoc')
const swaggerUI = require('swagger-ui-express')




var app = express()

//start mysql connection
var connection = mysql.createConnection({
    host : 'localhost', //mysql database host name
    user : 'root', //mysql database user name
    password : '', //mysql database password
    database : 'u4ufuk' //mysql database name
  });

connection.connect(function(err){
    if(err) throw err
    console.log("A csatlakozás sikerült")
})

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({extended: true}))





var server = app.listen(3000, "127.0.0.1", function() {
    var host = server.address().address
    var port = server.address().port
    console.log("A következő portot figyeljük: http://%s:%s", host, port)
})

const options = {
    definition:{
        openapi : '3.0.0',
        info : {
            title: 'Number Guesser API',
            description: 'OpenApi documentation of the number guesser.',
            version: '1.0.0',   
            servers:["http://localhost:3000"]
    },
    },
    apis: ["app.js"]
}

const swaggerDocs = swaggerJSDoc(options)
app.use('/api-docs', swaggerUI.serve, swaggerUI.setup(swaggerDocs))

/**
 * @swagger
 * components:
 *  schemas:
 *      Users:
 *          type: object
 *          required:
 *              - username
 *              - password
 *          properties:
 *              id:
 *                  type: number
 *                  description: The auto-generated id of the user
 *              username: 
 *                  type: string
 *                  description: The username of the user (must be unique)
 *              password:
 *                  type: string
 *                  description: The password of the user in its MD5 hash value
 *              balance:
 *                  type: number
 *                  description: The amount of money the user has on their account
 *              user_type_id:
 *                  type: number
 *                  description: The account type of the user. ADMIN = 2, USER = 1
 *              how_many_wins:
 *                  type: number
 *                  description: How many wins the user has
 *          example:
 *              id: 20
 *              username: User12
 *              password: abcdefg123456562525
 *              balance: 1000
 *              user_type_id: 1
 *              how_many_wins: 20
 * 
 *      usersRegister:
 *          type: object
 *          required:
 *              - username
 *              - password
 *          properties:
 *              username: 
 *                  type: string
 *                  description: The username of the user (must be unique)
 *              password:
 *                  type: string
 *                  description: The password of the user
 *          example:
 *              username: User12
 *              password: abc
 * 
 *      usersBalanceUpdate:
 *          type: object
 *          required:
 *              - id
 *              - username
 *              - balance
 *          properties:
 *              id:
 *                  type: number
 *                  description: Unique ID of user
 *              username: 
 *                  type: string
 *                  description: The username of the user
 *              balance:
 *                  type: number
 *                  description: The typed in amount of money the user want to upload (must be bigger than 0)
 *          example:
 *              id: 13
 *              username: User12
 *              balance: 500
 *      UsersLogin:
 *          type: object
 *          required:
 *              - username
 *              - password
 *          properties:
 *              username:
 *                  type: string
 *                  description: The username given
 *              password:
 *                  type: string
 *                  description: The password given
 *          example:
 *              username: User123
 *              password: 123
 * 
 *      GameLog:
 *          type: object
 *          required:
 *              - user_id
 *              - game_id
 *              - win
 *              - date
 *          properties:
 *              user_id:
 *                  type: string
 *                  description: The user who played
 *              game_id:
 *                  type: string
 *                  description: What game was played
 *              win:
 *                  type: string
 *                  description: Game outcome, yes/no
 *              date:
 *                  type: string
 *                  description: Date when the game was played
 *          example:
 *              user_id: 1
 *              game_id: 1
 *              win: yes
 *              date: 2024.01.01 20:00
 *      Game:
 *          type: object
 *          required:
 *              - name
 *              - price_to_play
 *              - reward
 *          properties:
 *              game_id:
 *                  type: number
 *                  description: ID of the game
 *              name:
 *                  type: string
 *                  description: Name of the game
 *              price_to_play:
 *                  type: number
 *                  description: Price to play the game
 *              reward:
 *                  type: number
 *                  description: Prize reward if you win.    
 *          example:
 *              game_id: 1
 *              name: game
 *              price_to_play: 400
 *              reward: 1000       
 */




//FELHASZNÁLÓK KEZELÉSE

/**
 * @swagger
 * /users:
 *  get:
 *      description: Use to request all users
 *      responses:
 *          '200':
 *              description: Successful request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Users'
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */
app.get("/users", function(req, res) {
    console.log(req)
    connection.query('SELECT * FROM users',  function (error, results, fields){
        if(results.lenght === 0){
            res.sendStatus(400)
        }
        else{
            res.send(JSON.stringify({'users' : results}))
        }
        
        
        //res.json(results)
    })
})

/**
 * @swagger
 * /users:
 *  post:
 *      description: Registers a user to the platform
 *      requestBody:
 *          required: true
 *          content:
 *              applications/json:
 *                  schema:
 *                      $ref: '#/components/schemas/usersRegister'
 *      responses:
 *          '200':
 *              description: Successful request
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */

app.post("/users", function(req, res){
    var data = req.body
    var username = req.body.username
    var password = req.body.password
    var balance = 0
    var user_type_id = 1
    var how_many_wins = 0


    if(!data["username"] || !data["password"]){
        res.send({
            "error": 1,
            "message": "Bad Args!"
        })
    }
    else{
        connection.query("SELECT COUNT(*) AS userCount FROM users WHERE username = ?", username, function(err, result, field){
            if(parseInt(result[0].userCount) == 0){
                connection.query('INSERT INTO users (username, password, balance, user_type_id, how_many_wins) VALUES (?, MD5(?), ?, ?, ?)', [username, password, balance, user_type_id, how_many_wins], function(error, results, fields){
                    if(error) throw err
                    res.send({
                        "error": 0,
                        "message": `${username} has been registered!`
                    })
                    console.log(`${username} has been registered!`)
                    //res.json(results)
                    //res.send(JSON.stringify(results))
                })
            } else
            {  res.send({
                "error": 1,
                "message": "Username already exists!"
            })
            }
        })
    }
     ////
    
    
})

/**
 * @swagger
 * /users:
 *  put:
 *      description: Updates the balance of the user by the entered amount
 *      requestBody:
 *          required: true
 *          content:
 *              applications/json:
 *                  schema:
 *                      $ref: '#/components/schemas/usersBalanceUpdate'
 *      responses:
 *          '200':
 *              description: Successful request
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */


app.put("/users", function(req, res){
    var data = req.body
    var id = req.body.id
    var username = req.body.username
    var balance = req.body.balance 
    

    if(data["id"] && data["username"] && data["balance"]){
        if(!isNaN(data["balance"]) && parseInt(data["balance"]) > 0){
            connection.query("UPDATE users SET balance = balance + ? WHERE username = ? AND id = ?", [parseInt(balance), username, id], function(err, result, field){
                if(err) throw err
                res.send({
                    "error": 0,
                    "message": "Balance updated succesfully!"
                })
            })
        }
        else{
            res.send({
                "error": 1,
                "message": "Please enter an integer or a number bigger than 0!"
            })
        }
    }
    else{ res.send({
        "error": 1,
        "message": "Bad args!"
    })}
})

/**
 * @swagger
 * /users:
 *  delete:
 *      description: Deletes a specific user (Only available if you are logged in as admin)
 *      requestBody:
 *          required: true
 *          content:
 *              applications/json:
 *                  schema:
 *                      type: object
 *                      requiered:
 *                          - id
 *                          - username
 *                      properties:
 *                          id:
 *                              type: number
 *                              description: ID of the user
 *                          username:
 *                              type: string
 *                              description: username of the user
 *                      example:
 *                          id: 20
 *                          username: User123
 *      responses:
 *          '200':
 *              description: Successful request
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */

app.delete("/users", function(req, res){
    var data = req.body
    var id = req.body.id
    var username = req.body.username
    

    if(data["id"] && data["username"]){
        connection.query("SELECT COUNT(*) as userCount FROM users WHERE username  = ?", username, function(err, result, field){
            if(parseInt(result[0].userCount) > 0){
                connection.query("DELETE FROM users WHERE id = ? AND username = ? AND user_type_id <> 2", [id, username], function(err, result, field){
                    if(err) throw err
                    res.send({
                        "error": 0,
                        "message": "User deleted!"
                    })
                })
            }
            else{
                res.send({
                    "error": 1,
                    "message": "User does not exist!"
                })
            }
        })
    }
    else{ res.send({
        "error": 1,
        "message": "Bad args!"
    })}
})

//Login

/**
 * @swagger
 * /login:
 *  get:
 *      description: Find out if a user exists with the given credentials
 *      responses:
 *          '200':
 *              description: Successful request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/UsersLogin'
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */


app.get("/login", function(req, res){
    var data = req.body
    var username = data.username
    var password = data.password

    if(data["username"] && data["password"]){
        connection.query("SELECT COUNT(*) as userCount FROM users WHERE username = ? AND password = MD5(?)", [username, password], function(err, result, field){
            if(parseInt(result[0].userCount) > 0){
                res.send({
                    "error": 0,
                    "message": "Succesfully logged in!"
                })
                //res.sendStatus(200)
            }
            else{
                res.send({
                    "error": 1,
                    "message": "User not found!"
                })
                //res.sendStatus(400)

            }
        })
    }
    else{ res.send({
        "error": 1,
        "message": "Bad args!"
    }) }
})

// GAME

/**
 * @swagger
 * /game:
 *  get:
 *      description: Use to request all users
 *      responses:
 *          '200':
 *              description: Successful request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: array
 *                          items:
 *                              $ref: '#/components/schemas/Game'
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */


app.get("/game", function(req, res){
    console.log(req)
    connection.query('SELECT * FROM game',  function (error, results, fields){
        if(error) throw error
        if(results.lenght === 0){
            res.statusCode(400)
        }
        else{
            res.send(JSON.stringify({'games' : results}))
        }
        
        //res.json(results)
    })
})

/**
 * @swagger
 * /game:
 *  post:
 *      description: Posts a log about game
 *      requestBody:
 *          required: true
 *          content:
 *              applications/json:
 *                  schema:
 *                      $ref: '#/components/schemas/GameLog'
 *      responses:
 *          '200':
 *              description: Successful request
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */


app.post("/game", function(req, res){
    var data = req.body
    var userID = data.user_id
    var gameID = data.game_id
    var win = data.win
    var date = data.date

    if(data["user_id"] && data["game_id"] && data["win"] && data["date"]){
        //insert log
        connection.query("INSERT INTO game_switch (user_id, game_id, win, date) VALUES (?, ?, ?, ?)", [userID, gameID, win, date], function(err, result, field){
            if(err) throw err
            res.send({
                "error": 0,
                "message": "Game log updated!"
            })
        })
        
    }
    else{
        res.send({
            "error": 1,
            "message": "Bad Args!"
        })
    }
})

/**
 * @swagger
 * /game:
 *  put:
 *      description: Updates the data of a user after a played game
 *      requestBody:
 *          required: true
 *          content:
 *              applications/json:
 *                  schema:
 *                      type: object
 *                      required:
 *                          - id
 *                          - money
 *                          - win
 *                      properties:
 *                          id:
 *                              type: number
 *                              description: id of the current user
 *                          money:
 *                              type: number
 *                              description: Amount of money that is going to be added to the user's account (can be +/-)
 *                          win:
 *                              type: string
 *                              description: Tells if the player has won or not
 *      responses:
 *          '200':
 *              description: Successful request
 *          '400':
 *              description: Invalid request
 *              content:
 *                  application/json:
 *                      schema:
 *                          type: object
 *                          properties:
 *                              error:
 *                                  type: number
 *                              message:
 *                                  type: string
 */

app.put("/game", function(req, res){
    var data = req.body
    var id = data.id
    var money = data.money
    var win = data.win
    
    if(data["id"] && data["money"] && data["win"]){
        //update user's money
        if(data.win == "yes"){
            connection.query("UPDATE users SET balance=balance + ?, how_many_wins = how_many_wins + 1 WHERE id = ?", [parseInt(money), id], function(err, result, field){
                if(err) throw err
                res.send({
                    "error": 0,
                    "message": "Balance updated succesfully!"
                })
            })
        }
        else{
            connection.query("UPDATE users SET balance=balance + ? WHERE id= ?", [parseInt(money), id], function(err, result, field){
                if(err) res.sendStatus(400)
                res.send({
                    "error": 0,
                    "message": "Balance updated succesfully!"
                })
            })
        }


        
    }
    else{
        res.send({
            "error": 1,
            "message": "Bad Args!"
        })
    }

})


