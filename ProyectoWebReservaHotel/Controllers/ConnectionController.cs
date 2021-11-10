using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoWebReservaHotel.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ProyectoWebReservaHotel.Controllers
{
    public class ConnectionController
    {
        string conexion = new MongoClient("");
    }
}