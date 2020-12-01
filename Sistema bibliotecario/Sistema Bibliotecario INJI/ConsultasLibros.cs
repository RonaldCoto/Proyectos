using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Sistema_Bibliotecario_INJI
{

    public class ConsultasLibros
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlDataReader id;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlCommand comando1 = new SqlCommand();

        public DataTable ListarPorTitulo(string titulo)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as Pais ,Categorias.Nombre as Categoria , Distribuciones.Nombre as Distribucion   from Libros join Autores_Libros on Libros.IDlibro = Autores_Libros.ID_libro join Autores on Autores_Libros.ID_autor = Autores.IDautor join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion join Categorias on Libros.IDcate = Categorias.IDcategoria  where Titulo= '" + titulo+"'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarPorAutor(string autor)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as País ,Categorias.Nombre as Categoría , Distribuciones.Nombre as Distribución   from Libros join Autores_Libros on Libros.IDlibro = Autores_Libros.ID_libro join Autores on Autores_Libros.ID_autor = Autores.IDautor join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion join Categorias on Libros.IDcate = Categorias.IDcategoria  where Nombrecompleto= '" + autor + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarPorCategoria(string categoria)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as País ,Categorias.Nombre as Categoría , Distribuciones.Nombre as Distribución   from Libros join Autores_Libros on Libros.IDlibro = Autores_Libros.ID_libro join Autores on Autores_Libros.ID_autor = Autores.IDautor join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion join Categorias on Libros.IDcate = Categorias.IDcategoria  where Categorias.Nombre = '" + categoria + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarPorEditorial(string editorial)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as País ,Categorias.Nombre as Categoría , Distribuciones.Nombre as Distribución   from Libros join Autores_Libros on Libros.IDlibro = Autores_Libros.ID_libro join Autores on Autores_Libros.ID_autor = Autores.IDautor join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion join Categorias on Libros.IDcate = Categorias.IDcategoria  where Distribuciones.Nombre = '" + editorial  + "'";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Grados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarAlumno()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Alumnos";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable mostrartodoslibros()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IDlibro as Código, Titulo,Editorial,Stock,Ubicacion as País,Categorias.Nombre as Categoría, Distribuciones.Nombre as Distribución from Libros inner join Categorias on Libros.IDcate=Categorias.IDcategoria inner join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void EliminarLibro(string IDlibro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Autores_Libros where ID_libro= '" + IDlibro + "' ";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Libros where IDlibro= '" + IDlibro + "' ";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();

        }
        public void insertaprestamo(string idlibro, string titulo, int nie, string nom1 , string nom2, string ape1, string ape2, string grado, string nombiblio,  string fechentrega, string fechdevo,int idgrado,int Idbiblio )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ingresarprestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDLibros", idlibro );
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@NIE", nie);
            comando.Parameters.AddWithValue("@Nom1", nom1);
            comando.Parameters.AddWithValue("@Nom2", nom2);
            comando.Parameters.AddWithValue("@Ape1", ape1);
            comando.Parameters.AddWithValue("@Ape2", ape2);
            comando.Parameters.AddWithValue("@Grado", grado);
            comando.Parameters.AddWithValue("@Nombiblio", nombiblio);
            comando.Parameters.AddWithValue("@Fechentrega",fechentrega);
            comando.Parameters.AddWithValue("@Fechdevolucion",fechdevo);
            comando.Parameters.AddWithValue("@Idgrado", idgrado);
            comando.Parameters.AddWithValue("@Idbiblio", Idbiblio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void insertarlibro(string codigo, int autor, string titulo, string editorial, int stock, string ubicacion, int distri, int categoria, string nomautor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ingresarlibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDLibros", codigo);
            comando.Parameters.AddWithValue("@IDAutores", autor);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@Editorial", editorial);
            comando.Parameters.AddWithValue("@Stock", stock);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);
            comando.Parameters.AddWithValue("@IDdistri", distri);
            comando.Parameters.AddWithValue("@IDcate", categoria);
            comando.Parameters.AddWithValue("@Nombrecompleto", nomautor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Acatualizarlibro(string codigo, string titulo , string autor, string editorial, int stock, string ubicacion, int categoria, int distri, string autorviejo)
        {

             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "Update Autores set Nombrecompleto= '"+autor +"' where Nombrecompleto='"+autorviejo +"'";
             comando.ExecuteNonQuery(); 
            comando.Connection = conexion.CerrarConexion();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Update Libros set Titulo = '"+titulo +"', Editorial='"+editorial +"', Stock = '"+stock +"' , Ubicacion = '"+ubicacion +"', IDdistri= '"+distri +"' , IDcate='"+categoria +"' where IDlibro = '"+codigo+"'";
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();


        }
        public void Devolucionlib(int codigo, string titulo, string idlib)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "generardevolucion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDprestamo", codigo);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@IDlibros", idlib);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();




        }


        public DataTable ListarTodosLibros()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as País ,Categorias.Nombre as Categoría , Distribuciones.Nombre as Distribución   from Libros join Autores_Libros on Libros.IDlibro = Autores_Libros.ID_libro join Autores on Autores_Libros.ID_autor = Autores.IDautor join Distribuciones on Libros.IDdistri = Distribuciones.IDdistribucion join Categorias on Libros.IDcate = Categorias.IDcategoria ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable mostrardevoluciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IDprestamo as #, NombreLibro as Libro, NIEprestamo as NIE,( NombreAlumno1 + ' ' + ApellidoAlumno1) as [Alumno],Grado, ( Bibliotecarios.nombre1 + ' ' + Bibliotecarios.apellido1) AS [Bibliotecario/a], Fecha_entrega AS [Fecha Entrega],Fecha_devolucion AS [Fecha Devolución] from Prestamos inner join Libros on Prestamos.ID_libro=Libros.IDlibro inner join Grados on Prestamos.IDgra=Grados.IDgrado inner join Bibliotecarios on Prestamos.IDBibliotecarioPrestamo=Bibliotecarios.IDbibliotecario";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarCategorias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Categorias";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

  

        public DataTable Listaralumngra(int nie)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NIE, Nombre1, Nombre2,Apellido1,Apellido2,Grado from Alumnos inner join Grados on Alumnos.Idgrad=Grados.IDgrado where NIE='" + nie + "'  ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Listaralumngra2(string grado)
        {
            leer = null;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NIE, Nombre1, Nombre2,Apellido1,Apellido2,Grado from Alumnos inner join Grados on Alumnos.Idgrad=Grados.IDgrado where Grado='" + grado + "'  ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public SqlDataReader Listaralumngrapres(string nie)
        {
           
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NIE, Nombre1, Nombre2,Apellido1,Apellido2,Grado from Alumnos inner join Grados on Alumnos.Idgrad=Grados.IDgrado where NIE='" + nie + "'  ";
            leer = comando.ExecuteReader();
            leer.Read();
            return leer;
        }


        public DataTable ListarTodosAlumnos()
         {
             comando.Connection = conexion.AbrirConexion();
             comando.CommandText = "select NIE, Nombre1, Nombre2,Apellido1,Apellido2,Grado from Alumnos inner join Grados on Alumnos.Idgrad=Grados.IDgrado ";
             leer = comando.ExecuteReader();
             tabla.Load(leer);
             leer.Close();
             conexion.CerrarConexion();
             return tabla;
         }
        public DataTable ListarEditorial()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Distribuciones";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public SqlDataReader ConvertirCategoria(string Categoria)
        {
            string nombre1;
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDcategoria  from Categorias where Nombre= '"+Categoria+"'";
            leer = comando.ExecuteReader();
            leer.Read();

            return leer;
        }

        public SqlDataReader ConvertirGrado(string Grado)
        {
            string nombre1;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDgrado from Grados where Grado= '"+Grado+"'";
            leer = comando.ExecuteReader();
            leer.Read();

            return leer;
        }

        public SqlDataReader ConvertirDistribucion(string Distribucion)
        {
            string nombre1;

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select IDdistribucion from Distribuciones  where Nombre='"+Distribucion+"'";
            leer = comando.ExecuteReader();
            leer.Read();

            return leer;
        }




        public DataTable ListarGrado()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Grados";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }



        public void insertaralumno(int NIE, string nombre1, string nombre2, string apellido1, string apellido2, int grado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Alumnos values('" + NIE + "','" + nombre1 + "','" + nombre2 + "','" + apellido1 + "','" + apellido2 + "','" + grado + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

        }

      
    
        public void EditarAlumno (int NIE, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string grado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Update Alumnos set Nombre1 = '" + Nombre1 + "' , Nombre2 = '" + Nombre2 + "',Apellido1= '" + Apellido1 + "',Apellido2= '" + Apellido2 + "',Idgrad= "+ grado +" where NIE= " + NIE + " ";
            comando.ExecuteNonQuery();
        }

        public void EliminarAlumno(int nie)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Alumnos where NIE= " + nie + " ";
            comando.ExecuteNonQuery();
        }

        public SqlDataReader MostrarBibliotecario(string datousername, string datocontra)
        {
            string nombre1;
            Actualizarperfilbibliotecaria frmactubibli = new Actualizarperfilbibliotecaria();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Bibliotecarios  where usuario= '" + datousername + "' and contraseña= " + datocontra + " ";
            leer = comando.ExecuteReader();
            leer.Read();

            return leer;
        }

        public SqlDataReader mostrarstock(string idlibro, string libro)
        {
            string nombre1;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarstock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDlibro", idlibro);
            comando.Parameters.AddWithValue("@Titulo", libro);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            leer.Read();

            return leer;
        }

        public void EditarBibliotecario(string nombre1, string nombre2, string apellido1, string apellido2, string usuario, string contra, string datousername, string datocontra)
        {
            comando.Connection = conexion.CerrarConexion();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Update Bibliotecarios set Nombre1 = '" + nombre1 + "' , Nombre2 = '" + nombre2 + "',Apellido1= '" + apellido1 + "',Apellido2= '" + apellido2 + "',usuario= '" + usuario + "',contraseña=" + contra + " where usuario= '" + datousername + "' and contraseña= " + datocontra + " ";
            comando.ExecuteNonQuery();
        }

        public void insertar(string nombre1, string nombre2, string apellido1, string apellido2, string usuario, string contra)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Bibliotecarios values('" + nombre1 + "','" + nombre2 + "','" + apellido1 + "','" + apellido2 + "','" + usuario + "','" + contra + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

        }

       

        public void insertarCate(string nombre, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Categorias values('" + nombre + "','" + descripcion + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void insertarEdito(string nombre, string pais)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Distribuciones values('" + nombre + "','" + pais + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }


        public SqlDataReader iniciarsesion(string user, string pass)
        {
            string sql = "select * from Bibliotecarios where usuario='" + user + "' and contraseña='" + pass + "' ";
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
           
            return leer;

        }
        SesionBibliotecario sesion = new Sistema_Bibliotecario_INJI.SesionBibliotecario();
        string dato;
        public SqlDataReader ObtenerID(string user, string pass)
        {
            string sqlID = "select IDbibliotecario from Bibliotecarios where usuario='" + user + "' and contraseña='" + pass + "' ";
            comando.Connection = conexion.CerrarConexion();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = sqlID;
            id = comando.ExecuteReader();

            while (id.Read() == true)
            {


               dato = id["IDbibliotecario"].ToString();
               


                //MessageBox.Show("El id del bibliotecario logueado es: " + sesion.Idbibliotecario);

            }


        
            comando.Connection = conexion.CerrarConexion();
            return id;
        }


        
    }
}


