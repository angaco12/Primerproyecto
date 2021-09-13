using System.Reflection;
using System.Security.Cryptography;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AspNetCoreWebAPI.Infrastructure.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreWebAPI.Interface;

namespace AspNetCoreWebAPI.Repositories
{
    public class UsersRepository : IUserRepository
    {
        //private string connectionString = "Server=tcp:danielsqlserver.database.windows.net,1433;Initial Catalog=Tutoria;Persist Security Info=False;User ID=useradmin;Password=Tutorias123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //PONGA ACA EL CÓDIGO Y LO USA DESDE EL CONTROLADOR
        //ESTA ES UNA FORMA DE HACERLO PERO NO ES LA MEJOR
        //HAGALO ASÍ Y LUEGO LO HACEMOS CON INYECCIÓN DE DEPENDENCIAS
        //PILLE LE DOY UN EJEMPLO DE COMO SE CONECTA A LA BD

        public UsersRepository(){
                   
                   
        }

        private string connectionString = "Server=tcp:danielsqlserver.database.windows.net,1433;Initial Catalog=Tutoria;Persist Security Info=False;User ID=useradmin;Password=Tutorias123.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        //PARA PARAR LKA EJECCUION ES CON COMMAND C AHI EN LA TERMINAL
        //METODO PARA OBTENER TODOS LOS USUARIOS

        public List<User> GetUsers()
        {  

            List<User> users = new List<User>();
            string query = "SELECT * FROM Users";
            // ACA SE CREA LA CONEXIÓN, SE CREA UN OBJETO SQLCONNECTION Y SE LE ENVIA LA CADENA DE CONEXIÓN
            using(var connection = new SqlConnection(connectionString))
            {
                users = connection.Query<User>(query).ToList();
            }

            return users;
        }

        public void AddUser(Infrastructure.Models.User user)
        {
           ; 

            // ACA SE CREA LA CONEXIÓN, SE CREA UN OBJETO SQLCONNECTION Y SE LE ENVIA LA CADENA DE CONEXIÓN
             
            using(var connection = new SqlConnection(connectionString))
            {
                string queryInsert = "INSERT INTO Users(NickName, Id, FirtsName, LastName, Birthdate) VALUES(@NickName, @Id, @FirtsName, @LastName, @Birthdate)";
                 connection.Execute(queryInsert, user);

            }
                    
               
            }
        public void UpdateUser(Infrastructure.Models.User user){


            using(var connection = new SqlConnection(connectionString))
            {

                string queryUpdate = "UPDATE Users NickName=@NickName, Id=@Id, FirtsName=@FirtsName, LastName=@LastName"+
                                     "Birthdate=@Birthdate where Id=@Id";
                                      
                connection.Execute(queryUpdate, user);
            }
        }
        public void DeleteUser(Infrastructure.Models.User user){


             using(var connection = new SqlConnection(connectionString)){

                 string queryDelete = "DELETE FROM Users where Id=@Id";
                 connection.Execute(queryDelete, user);
             }
        }
    }
}
