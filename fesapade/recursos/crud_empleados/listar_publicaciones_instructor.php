<?php 
  header('Access-Control-Allow-Origin: *'); 
  header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
  
  require("../conexion.php");
  
//preparando consulta que traera los datos del curso a editar
  $registros=$con->prepare("SELECT publi.titulo , publi.descripcion,publi.archivo,publi.fecha_publicacion, cur.nombre, publi.id_publicacion FROM matriculas as matri INNER JOIN federados AS fed ON fed.id_federado = matri.id_federado INNER JOIN asignaciones_cursos AS asig ON asig.id_asignacion_curso = matri.id_asignacion_curso INNER JOIN cursos AS cur ON cur.id_curso=asig.id_curso INNER JOIN publicaciones AS publi ON publi.id_asignacion_curso = asig.id_asignacion_curso WHERE asig.id_empleado=:codigo");
//asignando datos
  $registros->bindParam(':codigo',$_GET['codigo']);
//ejecutando consulta
  $registros->execute();
    
  //almacenamiento de datos de usuario en arreglo en caso de que exista
$vec=[];  
 $vec=$registros->fetchAll(PDO::FETCH_ASSOC);
  
  $cad=json_encode($vec);
  echo $cad;
  //header('Content-Type: application/json');
?>