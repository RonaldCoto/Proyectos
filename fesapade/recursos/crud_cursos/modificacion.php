<?php 
  header('Access-Control-Allow-Origin: *'); 
  header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
  
  $json = file_get_contents('php://input');
 
  $params = json_decode($json);
  
  require("../conexion.php");
 

//el metodo subscribe que llena el formulario de actualizacion convierte a los parametros de los objetos en Strings
//se convierte el id_curso en valor entero para ejecutar el query
  $codigo=intval($params->id_curso);

$portada = $params->portada;

    
//validamos si el nombre del curso ya esta utilizado y si el nombre la imagen ya esta registrada para evitar que se reescriba
//-----------------------------INICIANDO VALIDACION-----------------------------
$registros=$con->prepare("SELECT  nombre, portada FROM cursos WHERE id_curso=:codigo" );
$registros->bindParam(':codigo',$codigo);
$registros->execute();

//almacenamiento de datos de curso en arreglo en caso de que exista
$vec=[];  
$vec=$registros->fetchAll(PDO::FETCH_ASSOC);

//variable que será true si el curso ingresado esta disponible
$const = false;
foreach($vec as $datos){
    //si la portada es nueva se puede almacenar en el servidor
if($datos["portada"] != $portada){
    //por cada imagen subida se adjuntara el momento actual en segundos con time()
$fecha= time();
$portada = $fecha.$portada;
    $archivo = $params->base64textString;
$archivo = base64_decode($archivo);
  $filePath = $_SERVER['DOCUMENT_ROOT']."/recursos/imagenes/portadas_cursos/".$portada;
    file_put_contents($filePath, $archivo,FILE_APPEND);

}
    //si el curso fue modificado..
if($datos["nombre"] != $params->nombre){
     //se verifica que el nuevo curso no este ocupado
   $reg=$con->prepare("SELECT id_curso FROM cursos WHERE id_curso=:codigo ");
$reg->bindParam(':codigo',$codigo);
$reg->execute();
$vec2=[];  
$vec2=$reg->fetchAll(PDO::FETCH_ASSOC);
//si el curso no esta registrado se puede actualizar 
if($vec2 == null){
$const=true;
}
    //si el nombre del curso no se cambio se guarda como esta
}else{
    $const=true;
}
}   
//-----------------------------FINALIZANDO VALIDACION-----------------------------


    
//-----------------------------REALIZANDO ACTUALIZACION-----------------------------
//si $const es verdadero se puede actualizar
if($const){
  $modificacion=$con->prepare("UPDATE cursos SET nombre=:nombre, descripcion=:descripcion,portada=:portada,estado=:estado WHERE id_curso=:codigo");
$modificacion->bindParam(':nombre',$params->nombre);
$modificacion->bindParam(':descripcion',$params->descripcion);
$modificacion->bindParam(':portada',$portada);
$modificacion->bindParam(':estado',$params->estado);
$modificacion->bindParam(':codigo',$codigo);

$modificacion->execute();
  
  class Result {}

  $response = new Result();
  $response->resultado = 'OK';
  $response->mensaje = 'Curso modificado.';

  header('Content-Type: application/json');
  echo json_encode($response);  
     
}else{
     class Result {}

  $response = new Result();
  $response->resultado = 'ERROR';
  $response->mensaje = 'ERROR, el curso ingresado ya esta registrado.';

  header('Content-Type: application/json');
  echo json_encode($response); 
}    
 //-----------------------------FINALIZANDO ACTUALIZACION-----------------------------
?>