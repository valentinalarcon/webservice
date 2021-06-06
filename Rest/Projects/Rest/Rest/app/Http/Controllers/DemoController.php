<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Log;
class DemoController extends Controller
{

            public function rut(Request $request){
                
            Log::info("Comienza Función RUT");
                $gets = $request->json()->all();
                $rut = $gets["rut"];
                $aux = $rut;
                $rut = intval($rut);
                $dv = 0;
                if(strlen($aux)<7 || strlen($aux)>8){
                    
                    Log::info("Rut inválido");
                    return 500;
                }else{
                    $s=1;
                    for($m=0;$rut!=0;$rut/=10){
                        $s=($s+$rut%10*(9-$m++%6))%11;

                    }
                    $dv = chr($s?$s+47:75);
                    if ($dv=='K'){
                        return 100;
                    }
                    else{
                        return $dv;
                    }
                }

            }
            public function nombre(Request $request){
                
            Log::info("Comienza Función Nombre");
                $toma_n = $request->json()->all();
                $nombre = $toma_n["nombreC"];
                $auxn = $nombre;
                $arreglo_nombre = explode(" ",$auxn);
                $arreglojson = array();
                $arreglo_aux = array();
                $ct = count($arreglo_nombre);
                $arregloinv = array();
                $arregloinv[0] = 500;
                if($ct < 3){
                    
                    Log::info("Nombre inválido");
                    return $arregloinv;
                }
                else{
                    if(preg_match("/^[a-zA-Z\s]*$/", $nombre)){
                        $arreglo_aux[0]=$arreglo_nombre[$ct-2];
                        $arreglo_aux[1]=$arreglo_nombre[$ct-1];
                        $arreglo_auxnombres = array();
                        for($i=0; $i<$ct-2 ; $i++){
                            array_push($arreglo_auxnombres,$arreglo_nombre[$i]);
                        }
                        array_push($arreglojson,$arreglo_auxnombres);
                        array_push($arreglojson,$arreglo_aux);
                        return $arreglojson;
                    }
                    else{
                        return $arregloinv;
                    }
                }
                
            }

       
}
