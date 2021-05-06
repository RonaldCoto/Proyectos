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
$fecha_publicacion = date('Y-m-d');
$id_asignacion_curso=intval($params->id_asignacion_curso);

    $filePath = $_SERVER['DOCUMENT_ROOT']."/recursos/archivos/".$portada;
    file_put_contents($filePath, $archivo);

  $insertar=$con->prepare("INSERT INTO publicaciones(titulo,descripcion,archivo,fecha_publicacion,id_asignacion_curso) VALUES
                  (:titulo,:descripcion,:portada,:fecha_publicacion,:id_asignacion_curso)");
$insertar->bindParam(':titulo',$params->titulo);
$insertar->bindParam(':descripcion',$params->descripcion);
$insertar->bindParam(':portada',$portada);
$insertar->bindParam(':fecha_publicacion',$fecha_publicacion);
$insertar->bindParam(':id_asignacion_curso',$id_asignacion_curso);
$insertar->execute();
  
  class Result {}

  $response = new Result();
  $response->resultado = 'OK';
  $response->mensaje = 'Publicación creada con éxito.';

  header('Content-Type: application/json');
  echo json_encode($response);  

?>