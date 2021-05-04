<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DemoController extends Controller
{
/*             public function rut (Request $request)
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




            }  */
           

            public function valida_rut(Request $request){

/*             $gets = $request->json()->all();
            $rut = $gets["rut"];
            $rut = str_replace(".","",$rut);
 */

            $rut = $request->input('rut');
            $aux = strval($rut);
            $resp = "no es rut";
            if(is_numeric($rut)){
                if(strlen($aux)<7 or strlen($aux)>8){
                    return $resp;
                }
                else{
                    return dv($rut);
                }}
            else{
                return $resp;
            }
        
            $resultado = "hola $resp";

            return json_encode(array(
                'status' => 200,
                'response' => array(
                    'mensaje' => $resultado
                )
            ));


        }
        
            public function dv($r){
                $s=1;
                for($m=0;$r!=0;$r/=10)
                    $s=($s+$r%10*(9-$m++%6))%11;
                return chr($s?$s+47:75);
            }
            
    

       
}
