<?php 
  header('Access-Control-Allow-Origin: *'); 
  header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
  
  $json = file_get_contents('php://input');
 
  $params = json_decode($json);
  
  require("../conexion.php");
  
$portada = $params->portada;
$archivo = $params->base64textString;
    $archivo = base64_decode($archivo);
//por cada imagen subida se adjuntara el momento actual en segundos con time()
$fecha= time();
$portada = $fecha.$portada;

//validamos si el nombre del curso ya esta utilizado
//-----------------------------INICIANDO VALIDACION-----------------------------
$registros=$con->prepare("SELECT  id_curso FROM cursos WHERE nombre=:nombre" );
$registros->bindParam(':nombre',$params->nombre);
$registros->execute();

//almacenamiento de datos de curso en arreglo en caso de que exista
$vec=[];  
$vec=$registros->fetchAll(PDO::FETCH_ASSOC);
    

//si el nombre no esta registrado se puede crear el nuevo curso
if($vec == null){
    $filePath = $_SERVER['DOCUMENT_ROOT']."/recursos/imagenes/portadas_cursos/".$portada;
    file_put_contents($filePath, $archivo);

  $insertar=$con->prepare("INSERT INTO cursos(nombre,descripcion,portada,estado) VALUES
                  (:nombre,:descripcion,:portada,:estado)");
$insertar->bindParam(':nombre',$params->nombre);
$insertar->bindParam(':descripcion',$params->descripcion);
$insertar->bindParam(':portada',$portada);
$insertar->bindParam(':estado',$params->estado);
$insertar->execute();
  
  class Result {}

  $response = new Result();
  $response->resultado = 'OK';
  $response->mensaje = 'Curso generado con exito.';

  header('Content-Type: application/json');
  echo json_encode($response);  
    //si el nombre ya estaba registrado no se puede crear al nuevo curso
}else{
    class Result {}

  $response = new Result();
  $response->resultado = 'ERROR';
  $response->mensaje = 'Error. El curso ingresado ya esta en uso.';

  header('Content-Type: application/json');
  echo json_encode($response); 
}
?>