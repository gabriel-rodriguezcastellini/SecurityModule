using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Services.Common
{
    public class Constantes
    {
        public class Acciones
        {
            public const string Leer = "Leer";
            public const string Agregar = "Agregar";
            public const string Modificar = "Modificar";
            public const string Eliminar = "Eliminar";
            public const string ResetearClave = "ResetearClave";
        }
        
        public class Modulos
        {
            public const string Usuarios = "Usuarios";
            public const string Grupos = "Grupos";
        }
    }
}
