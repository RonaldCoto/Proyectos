using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Bibliotecario_INJI
{
    public class MostrarLibros
    {
        private ConsultasLibros objetoconsultas = new ConsultasLibros();

        public void EliminarLibro(string IDlibro)
        {
            objetoconsultas.EliminarLibro((IDlibro));
        }

        public DataTable mostrarlibro()
        {
            DataTable tabla = new DataTable();
            tabla = objetoconsultas.mostrartodoslibros();
            return tabla;
        }

        public DataTable mostrarDevolucion()
        {
            DataTable tabla = new DataTable();
            tabla = objetoconsultas.mostrardevoluciones();
            return tabla;
        }

        public void EditarAlumno(string NIE, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string grado)
        {
            objetoconsultas.EditarAlumno(Convert.ToInt32(NIE), Nombre1, Nombre2, Apellido1, Apellido2, grado);
        }

        public void EliminarAlumno(string NIE)
        {
            objetoconsultas.EliminarAlumno(Convert.ToInt32(NIE));
        }
        public DataTable mostrarAlumno()
        {
            DataTable tabla = new DataTable();
            tabla = objetoconsultas.MostrarAlumno();
            return tabla;

        }
        public void EditarBibliotecario(string nombre1, string nombre2, string apellido1, string apellido2, string nombreusuario, string contraseña, string datousername, string datopassword)
        {
            objetoconsultas.EditarBibliotecario(nombre1, nombre2, apellido1, apellido2, nombreusuario , contraseña, datousername, datopassword  );
        }
        public void insertarbibliotecaria(string nombre1, string nombre2, string apellido1, string apellido2, string usuario, string contra)
        {
            objetoconsultas.insertar(nombre1, nombre2, apellido1, apellido2, usuario, contra);
        }

        public SqlDataReader Mostrarbibliotecaria(string usuario, string contra)
        {
            SqlDataReader leer;
            leer = objetoconsultas.MostrarBibliotecario(usuario, contra);
            return leer;
        }

        public SqlDataReader ConvertirCategoria(string Categoria)
        {
            SqlDataReader leer;
            leer = objetoconsultas.ConvertirCategoria(Categoria);
            return leer;
        }

        public SqlDataReader ConvertirDistribucion(string Distribucion)
        {
            SqlDataReader leer;
            leer = objetoconsultas.ConvertirDistribucion(Distribucion);
            return leer;
        }

        public SqlDataReader ConvertirGrado(string Grado)
        {
            SqlDataReader leer;
            leer = objetoconsultas.ConvertirGrado(Grado);
            return leer;
        }


        //public void insertarlibronuevo(string codigo, string autor, string titulo, string editorial, string stock, string ubicacion, string distri, string categoria, string nomautor)
        // {
        //    objetoconsultas.insertarlibro(codigo,Convert.ToInt32(autor), titulo, editorial, Convert.ToInt32(stock), ubicacion, Convert.ToInt32(distri), Convert.ToInt32(categoria), nomautor);
        // }

        public void insertarCategorianueva(string nombre, string descripcion)
        {
            objetoconsultas.insertarCate(nombre, descripcion);
        }

        public void insertareditorialnueva(string nombre, string pais)
        {
            objetoconsultas.insertarEdito(nombre, pais);
        }

     

        private string _Usuario;
        private string _Contraseña;
        private string _IdBibliotecario;
        public string Usuario
        {
            

            get
            {
                return  _Usuario;
            }
            set
            {
                //if (value == "USUARIO")
                //{
                 //   _Usuario = "No ha ingresado su usuario";
                //}
                //else
                //{
                    _Usuario = value;
               
                //}
            }
        }

        public string Contraseña
        {
            set {
                //if (value == "CONTRASEÑA")
                //{
                  //  _Contraseña = "No ha ingresado su contraseña";
                //}
                //else
                //{
                    _Contraseña = value;

                //}
            }
            get { return _Contraseña; }
        }

        public string IdBibliotecario
        {
            get
            {
                return _IdBibliotecario;
            }

            set
            {
                _IdBibliotecario = value;
            }
        }

        public SqlDataReader Iniciarsesion()
        {
            SqlDataReader loguear;
            loguear = objetoconsultas.iniciarsesion(Usuario, Contraseña);


            return loguear;
        }

        public SqlDataReader ObtenerID()
        {
            SqlDataReader id;
            id = objetoconsultas.ObtenerID(Usuario, Contraseña);

        
            return id ;
        }

        

    }
}
