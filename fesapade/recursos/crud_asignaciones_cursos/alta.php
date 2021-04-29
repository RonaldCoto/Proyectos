<?php 
  header('Access-Control-Allow-Origin: *'); 
  header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
  
  $json = file_get_contents('php://input');
 
  $params = json_decode($json);
  
  require("../conexion.php");
//pasando a string los parametros recibidos de angular
$id_curso=intval($params->id_curso);
$id_empleado=intval($params->id_empleado);

//verificando si el empleado a asignar ya estaba asignado para evitar duplicación
$registros=$con->prepare("SELECT id_asignacion_curso FROM asignaciones_cursos WHERE (id_curso = :id_curso1 AND id_empleado = :id_empleado1) ");
$registros->bindParam(':id_curso1',$id_curso );
$registros->bindParam(':id_empleado1',$id_empleado );
$registros->execute();
$vec=[];  
$vec=$registros->fetchAll(PDO::FETCH_ASSOC);
//si el empleado no esta asignado al curso se puede asignar
if($vec == null){
     $insertar=$con->prepare("insert into asignaciones_cursos (id_curso,id_empleado) values (:id_curso,:id_empleado)");

$insertar->bindParam(':id_curso',$id_curso);
$insertar->bindParam(':id_empleado',$id_empleado);
$insertar->execute();

  
  class Result {}

  $response = new Result();
  $response->resultado = 'OK';
  $response->mensaje = 'Instructor asignado con éxito.';

  header('Content-Type: application/json');
  echo json_encode($response);  
    
    //si ya estaba asignado muestra una alerta
}else{
    class Result { }
$response = new Result();
$response -> resultado = 'ERROR';
$response -> mensaje = 'ERROR, este empleado ya se encuentra asignado a este curso.';
header('Content-Type: application/json');
echo json_encode($response);
}
 
?>