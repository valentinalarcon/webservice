<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DemoController extends Controller
{
      public function rut (Request $request)
     {
         $nombre = $request->input('nombre');
         $RUT = $request->input('RUT');

         $resultado = "Hola, como estas $nombre $RUT";

         return json_encode(array(
             'status' => 200,
             'response' => array(
                 'mensaje' => $resultado
             )
         ));




     } 
 
/*     public function valida_rut($rut){
        $aux = strval($rut);
        $resp = "Rut invalido";
        if(is_numeric($rut)){
            if(strlen($aux)<7 or strlen($aux)>8){
                echo $resp;
            }
            else{
                echo dv($rut);
            }
        }
        else{
            echo $resp;
        }
    }
    
    public function dv($r){
        $s=1;
        for($m=0;$r!=0;$r/=10)
            $s=($s+$r%10*(9-$m++%6))%11;
        echo 'El digito verificador es: ',chr($s?$s+47:75);
   }
 */

}
