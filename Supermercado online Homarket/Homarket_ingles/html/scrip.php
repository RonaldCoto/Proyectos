 <script language="javascript"> 
mydate = new Date(); 
myday = mydate.getDay(); 
mymonth = mydate.getMonth(); 
myweekday= mydate.getDate(); 
weekday= myweekday+3; 
     

if(myday == 0) 
day = " Domingo " 

else if(myday == 1) 
day = " Lunes " 

else if(myday == 2) 
day = " Martes " 

else if(myday == 3) 
day = " Miércoles " 

else if(myday == 4) 
day = " Jueves " 

else if(myday == 5) 
day = " Viernes " 

else if(myday == 6) 
day = " Sábado " 

if(mymonth == 0) 
month = "Enero " 

else if(mymonth ==1) 
month = "Febrero " 

else if(mymonth ==2) 
month = "Marzo " 

else if(mymonth ==3) 
month = "Abril " 

else if(mymonth ==4) 
month = "Mayo " 

else if(mymonth ==5) 
month = "Junio " 

else if(mymonth ==6) 
month = "Julio " 

else if(mymonth ==7) 
month = "Agosto " 

else if(mymonth ==8) 
month = "Setiembre " 

else if(mymonth ==9) 
month = "Octubre " 

else if(mymonth ==10) 
month = "Noviembre " 

else if(mymonth ==11) 
month = "Diciembre " 
</script> 
<?php
  session_start();         
      $id= $_SESSION ["usera"];
       $link = new mysqli("localhost","root","","bdd");
           

  function generarCodigo($longitud) {
 $key = '';
 $pattern = '1234567890abcdefghijklmnopqrstuvwxyz';
 $max = strlen($pattern)-1;
 for($i=0;$i < $longitud;$i++) $key .= $pattern{mt_rand(0,$max)};
 return $key;
                     }
 
                 $factura = generarCodigo(6);

     $resss = mysqli_query($link, "UPDATE compras SET factura= '$factura' WHERE id_usuario= '$id' and factura = '' ");
    
    $re="select * from compras where id_usuario =  '$id' " ;
                   $ree=$link ->query($re);
		     while($t=$ree->fetch_assoc() ) {
                
                 $id_cat = $t['id_cat'];
                        $id_compra= $t['id_compra'];
                        $id_user = $_SESSION ['usera'];
                        $id_pro = $t['id_producto'];
                        $produc =  $t['producto'];
                        $precio =  $t['precio'];
                        $imagen =  $t['imagen'];
                        $id_cat = $t['id_cat'];
                        $cant = $t['cantidad'];
                        $fact = $t['factura'];
                         
    $res = mysqli_query($link,"insert into ventas values ('','$id_compra','$id_pro','$id_user','$produc','$cant','$precio','$imagen','$id_cat','$fact','' )"); 
             }

      $del = mysqli_query($link,"delete from compras where id_usuario='$id'");


      echo  "<script>alert('Retirar antes del '+weekday+' de '+month+', SU FACTURA ES: $factura'); window.location.href='../html/inicio.php'</script>";

?>



